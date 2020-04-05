using System;
using System.Drawing;

namespace ConwaysGameLife
{
    public class DrawingGrid
    {
        bool _visible = false;
        float _size = c_defaultSize;
        float _xOffset = 0;
        float _yOffset = 0;

        public DrawingGrid(bool visible)
        {
            _visible = visible;
        }

        Rectangle _rectangle = Rectangle.Empty;

        const int c_renderSize = 2;
        const int c_defaultSize = 14;

        #region === public ===       

        public float xOffset
        {
            get { return _xOffset; }
            set { _xOffset = value; }
        }

        public float yOffset
        {
            get { return _yOffset; }
            set { _yOffset = value; }
        }

        public bool visible
        {
            get { return _visible; }
            set { _visible = value; }
        }

        public Rectangle rectangle
        {
            get { return _rectangle; }
            set { _rectangle = value; }
        }

        public float size => _size;

        public Point GetMapIndex(int X, int Y)
        {
            double _x = Math.Truncate((X - _xOffset) / size);
            double _y = Math.Truncate((Y - _yOffset) / size);

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
            PointF[] points = new PointF[4];

            for (float x = xOffset; x < rectangle.Width; x += size)
            {
                points[0].X = x - c_renderSize;
                points[1].X = x + c_renderSize;
                points[2].X = x;
                points[3].X = x;

                for (float y = yOffset; y < rectangle.Height; y += size)
                {
                    points[0].Y = y;                    
                    points[1].Y = y;                    
                    points[2].Y = y - c_renderSize;                    
                    points[3].Y = y + c_renderSize;

                    g.DrawLines(pen, points);
                }
            }
        }

        #endregion
    }
}
