﻿using System;
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

        Rectangle m_rectangle = Rectangle.Empty;

        const int c_renderSize = 2;
        const int c_defaultSize = 14;

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

        public PointF GetDrawingPoint(int X, int Y)
        {
            return new PointF(m_xOffset + X * size, m_yOffset + Y * size);
        }

        public Point GetMapIndex(int X, int Y)
        {
            double _x = Math.Truncate((X - m_xOffset) / size);
            double _y = Math.Truncate((Y - m_yOffset) / size);

            return new Point(Convert.ToInt32(_x), Convert.ToInt32(_y));
        }

        public int gridSizeX
        {
            get
            {
                float s = (rectangle.Width - xOffset) / size;
                return Convert.ToInt32(s);
            }
        }

        public int gridSizeY
        {
            get
            {
                float s = (rectangle.Height - yOffset) / size;
                return Convert.ToInt32(s);
            }
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
