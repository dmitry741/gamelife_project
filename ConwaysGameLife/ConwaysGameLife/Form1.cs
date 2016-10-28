using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConwaysGameLife
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region === members ===

        Bitmap m_bitmap = null;
        DrawingGrid m_grid = new DrawingGrid(true);
        Map m_map = new Map();
        List<ILifeRule> m_lifeRules = new List<ILifeRule>();
        int m_currentRulesIndex = 0;
        Timer m_timer = new Timer();
        List<Control> m_controlsForDisabling = new List<Control>();

        #endregion

        #region === private ===

        void EnableControls(bool b)
        {
            foreach (Control c in m_controlsForDisabling)
            {
                c.Enabled = b;
            }
        }

        void RenderMap(Graphics g)
        {
            m_grid.Render(g);
            m_map.Render(g, m_grid.size, m_grid.xOffset, m_grid.yOffset);
        }

        void Render()
        {
            // check for valid bitmap
            if (m_bitmap == null)
                return;

            // create new graphics object
            Graphics g = Graphics.FromImage(m_bitmap);

            // clear content
            g.Clear(Color.White);

            // render the current map
            RenderMap(g);

            // "BitBlt"
            pictureBox1.Image = m_bitmap;
        }

        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;

            m_bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            m_grid.rectangle = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);

            cmbSceneMode.Items.Add("View");
            cmbSceneMode.Items.Add("Add cell");
            cmbSceneMode.Items.Add("Remove cell");
            cmbSceneMode.SelectedIndex = 1;

            cmbAnimateMode.Items.Add(new PresetInterval("Fast", 250));
            cmbAnimateMode.Items.Add(new PresetInterval("Normal", 500));
            cmbAnimateMode.Items.Add(new PresetInterval("Slow", 1000));
            cmbAnimateMode.SelectedIndex = 1;

            m_map.CreateEmptyMap(m_grid.gridSizeX, m_grid.gridSizeY, "New");

            m_lifeRules.Add(new ClassicConwaysRules());
            m_lifeRules.Add(new MyLifeMyRules());

            m_controlsForDisabling.Add(btnSave);
            m_controlsForDisabling.Add(btnLoad);
            m_controlsForDisabling.Add(btnRandom);
            m_controlsForDisabling.Add(btnClear);

            m_timer.Tick += timer_Tick;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ILifeRule irules = m_lifeRules[m_currentRulesIndex];
            m_map.Next(irules);
            Render();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout dlg = new frmAbout();
            dlg.ShowDialog();
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            if (pictureBox1.Width > 0 && pictureBox1.Height > 0)
            {
                m_bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                m_grid.rectangle = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
                m_map.CreateEmptyMap(m_grid.gridSizeX, m_grid.gridSizeY, "New");
            }
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            Render();
        }

        private void cbGridView_CheckedChanged(object sender, EventArgs e)
        {
            m_grid.visible = cbGridView.Checked;
            Render();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (cmbSceneMode.SelectedIndex == 0) // view
                return;

            Point point = m_grid.GetMapIndex(e.X, e.Y);

            if (point.X >= m_grid.gridSizeX || point.Y >= m_grid.gridSizeY)
                return;

            if (cmbSceneMode.SelectedIndex == 1) // add new cell
            {
                if (m_map.GetValue(point.X, point.Y) == 0)
                {
                    m_map.SetValue(1, point.X, point.Y);
                }
            }
            else // remove
            {
                m_map.SetValue(0, point.X, point.Y);
            }

            Render();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string message = "Are you sure that you want to clear the map?";
            string caption = " Conway's Game of Life";

            if (MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                m_map.Clear();
                Render();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ILifeRule irules = m_lifeRules[m_currentRulesIndex];
            m_map.Next(irules);
            Render();
        }

        private void btnNext10_Click(object sender, EventArgs e)
        {
            ILifeRule irules = m_lifeRules[m_currentRulesIndex];

            for (int i = 0; i < 10; i++)
            {
                m_map.Next(irules);
            }

            Render();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (m_timer.Enabled)
            {
                m_timer.Stop();
                btnStart.Text = "Start";
                EnableControls(true);
            }
            else
            {
                btnStart.Text = "Stop";
                EnableControls(false);

                PresetInterval pi = cmbAnimateMode.SelectedItem as PresetInterval;
                m_timer.Interval = pi.interval;
                m_timer.Start();
            }
        }

        private void cmbAnimateMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_timer.Enabled)
            {
                m_timer.Stop();

                PresetInterval pi = cmbAnimateMode.SelectedItem as PresetInterval;
                m_timer.Interval = pi.interval;
                m_timer.Start();
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            frmPresetMap dlg = new frmPresetMap();

            dlg.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Life map files (*.lmf)|*.lmf|All files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                m_map.Save(dlg.FileName);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Life map files (*.lmf)|*.lmf|All files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                m_map.Load(dlg.FileName);
                Render();
            }
        }
    }

    class PresetInterval
    {
        public string name = string.Empty;
        public int interval = 500;

        public PresetInterval(string _name, int _interval)
        {
            name = _name;
            interval = _interval;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
