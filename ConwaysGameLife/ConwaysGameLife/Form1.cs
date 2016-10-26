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

        Bitmap m_bitmap = null;
        DrawingGrid m_grid = new DrawingGrid(true);
        int[,] m_map = null;

        #region === private ===

        void RenderMap(Graphics g)
        {
            // render grid
            m_grid.Render(g);

            // render map
            Brush brushOld = new SolidBrush(Color.Red);
            Brush brushYoung = new SolidBrush(Color.DarkGreen);

            for (int i = 0; i < m_grid.gridSizeX; i++)
            {
                for (int j = 0; j < m_grid.gridSizeY; j++)
                {
                    if (m_map[i, j] == 0)
                        continue;

                    PointF point = m_grid.GetDrawingPoint(i, j);
                    RectangleF r = new RectangleF(point.X, point.Y, m_grid.size, m_grid.size);

                    if (m_map[i, j] == 1)
                        g.FillEllipse(brushYoung, r);
                    else
                        g.FillEllipse(brushOld, r);
                }
            }
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
            cmbSceneMode.SelectedIndex = 0;

            cmbAnimateMode.Items.Add("Fast");
            cmbAnimateMode.Items.Add("Normal");
            cmbAnimateMode.Items.Add("Slow");
            cmbAnimateMode.SelectedIndex = 1;

            m_map = new int[m_grid.gridSizeX, m_grid.gridSizeY];
            Array.Clear(m_map, 0, m_map.Length);

            m_map[1, 1] = 1;
            m_map[2, 2] = 2;
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
                if (m_map[point.X, point.Y] == 0)
                {
                    m_map[point.X, point.Y] = 1;
                }
            }
            else // remove
            {
                m_map[point.X, point.Y] = 0;
            }

            Render();
        }
    }
}
