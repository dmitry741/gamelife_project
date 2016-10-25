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

        #region === private ===

        void RenderMap(Graphics g)
        {

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
            m_bitmap = null;

            if (this.Width > 0 && this.Height > 0)
            {
                m_bitmap = new Bitmap(this.Width, this.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            }
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            RenderMap(e.Graphics);
        }
    }
}
