using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConwaysGameLife
{
    public class DrawingGrid
    {
        bool m_visible = false;
        float m_size = c_defaultSize;
        float m_xOffset = 0;
        float m_yOffset = 0;

        public DrawingGrid(bool visible)
        {
            m_visible = visible;
        }

        Rectangle m_rectangle = new Rectangle();

        const int c_renderSize = 2;
        const int c_defaultSize = 16;

        #region === private ===

        int GetValue(int X, int width, float offset)
        {
            if (X < 0)
            {
                return 0;
            }

            int N1 = 0;
            int N2 = Convert.ToInt32(width / size);

            if (X > width)
            {
                return Convert.ToInt32(N2 * size);
            }

            int N = 0;
            float x1;

            while (N2 - N1 > 1)
            {
                N = (N1 + N2) / 2;
                x1 = N * size + offset;

                if (x1 > X)
                {
                    N2 = N;
                }
                else
                {
                    N1 = N;
                }
            }

            float d1 = Math.Abs(X - (N1 * size + offset));
            float d2 = Math.Abs(X - (N2 * size + offset));

            x1 = ((d1 < d2) ? N1 : N2) * size + offset;

            return Convert.ToInt32(x1);
        }

        #endregion

        #region === public ===       

        public float xOffset
        {
            get { return m_xOffset; }
            set { m_xOffset = value; }
        }

        public float yOffset
        {
            get { return m_yOffset; }
            set { m_yOffset = value; }
        }

        public bool visible
        {
            get { return m_visible; }
            set { m_visible = value; }
        }

        public Rectangle rectangle
        {
            get { return m_rectangle; }
            set { m_rectangle = value; }
        }

        public float size
        {
            get { return m_size; }
        }

        public PointF GetPoint(int X, int Y)
        {
            int x1 = GetValue(X, rectangle.Width, m_xOffset);
            int y1 = GetValue(Y, rectangle.Height, m_yOffset);

            return new PointF(x1, y1);
        }

        public PointF GetPoint(float X, float Y)
        {
            return GetPoint((int)X, (int)Y);
        }

        public void Render(Graphics g)
        {
            if (!visible)
                return;

            Pen pen = new Pen(Color.LightGray);

            for (float x = xOffset; x < rectangle.Width; x += size)
            {
                for (float y = yOffset; y < rectangle.Height; y += size)
                {
                    g.DrawLine(pen, x - c_renderSize, y, x + c_renderSize, y);
                    g.DrawLine(pen, x, y - c_renderSize, x, y + c_renderSize);
                }
            }
        }

        #endregion
    }
}
