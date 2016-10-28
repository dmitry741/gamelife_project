using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace ConwaysGameLife
{
    class Map
    {
        int[,] m_map;
        int[,] m_tempMap;
        int m_width, m_height;
        string m_name;

        public Map()
        {
            m_map = m_tempMap = null;
            m_width = m_height = 0;
            m_name = "Empty";
        }

        public Map(int _width, int _height, string _name)
        {
            CreateEmptyMap(_width, _height, _name);
        }

        #region === private ===

        int GetNeighbors(int X, int Y)
        {
            int indexX, indexY;
            int counter = 0;

            for (int i = 0; i < 3; i++)
            {
                indexX = X - 1 + i;

                if (indexX < 0)
                    continue;

                if (indexX >= m_width)
                    break;

                for (int j = 0; j < 3; j++)
                {
                    if (i == 1 && j == 1)
                        continue;

                    indexY = Y - 1 + j;

                    if (indexY < 0)
                        continue;

                    if (indexY >= m_height)
                        break;

                    if (m_map[indexX, indexY] > 0)
                        counter++;
                }
            }

            return counter;
        }

        #endregion

        #region === public ===

        public void CreateEmptyMap(int _width, int _height, string _name)
        {
            m_width = _width;
            m_height = _height;
            m_name = _name;

            m_map = new int[m_width, m_height];
            m_tempMap = new int[m_width, m_height];
            Array.Clear(m_map, 0, m_map.Length);
        }

        public void CopyMap(int[,] map, int xStart, int yStart)
        {
            int xBound = map.GetUpperBound(0) + 1;
            int yBound = map.GetUpperBound(1) + 1;
            int xIndex, yIndex;

            for (int i = 0; i < xBound; i++)
            {
                xIndex = xStart + i;

                if (xIndex < 0 || xIndex >= m_width)
                    continue;

                for (int j = 0; j < yBound; j++)
                {
                    yIndex = yStart + j;

                    if (yIndex < 0 || yIndex >= m_height)
                        continue;

                    m_map[xIndex, yIndex] = map[i, j];
                }
            }
        }

        public void Render(Graphics g, float gridSize, float xOffset, float yOffset)
        {
            Brush brushOld = new SolidBrush(Color.Red);
            Brush brushYoung = new SolidBrush(Color.DarkGreen);
            RectangleF r = new RectangleF(0, 0, gridSize, gridSize);

            for (int i = 0; i < m_width; i++)
            {
                for (int j = 0; j < m_height; j++)
                {
                    if (m_map[i, j] == 0)
                        continue;

                    r.X = xOffset + i * gridSize;
                    r.Y = yOffset + j * gridSize;

                    g.FillEllipse((m_map[i, j] == 1) ? brushYoung : brushOld, r);
                }
            }
        }

        public int GetValue(int i, int j)
        {
            return m_map[i, j];
        }

        public void SetValue(int val, int i, int j)
        {
            m_map[i, j] = val;
        }

        public void Clear()
        {
            Array.Clear(m_map, 0, m_map.Length);
        }

        public void Next(ILifeRule irules)
        {
            int neighbors;
            Array.Clear(m_tempMap, 0, m_tempMap.Length);

            for (int i = 0; i < m_width; i++)
            {
                for (int j = 0; j < m_height; j++)
                {
                    neighbors = GetNeighbors(i, j);
                    m_tempMap[i, j] = irules.GetCellStatuc(neighbors, m_map[i, j]);
                }
            }

            Array.Copy(m_tempMap, m_map, m_map.Length);
        }

        public void Next(ILifeRule irules, int count)
        {
            int neighbors;            

            for (int index = 0; index < count; index++)
            {
                Array.Clear(m_tempMap, 0, m_tempMap.Length);

                for (int i = 0; i < m_width; i++)
                {
                    for (int j = 0; j < m_height; j++)
                    {
                        neighbors = GetNeighbors(i, j);
                        m_tempMap[i, j] = irules.GetCellStatuc(neighbors, m_map[i, j]);
                    }
                }

                Array.Copy(m_tempMap, m_map, m_map.Length);
            }
        }

        public override string ToString()
        {
            return m_name;
        }        

        static public bool operator ==(Map map1, Map map2)
        {
            if (map1.m_map == null && map2.m_map == null)
                return true;

            if (map1.m_map != null && map2.m_map == null)
                return false;

            if (map1.m_map == null && map2.m_map != null)
                return false;

            if (map1.m_width != map2.m_width || map1.m_height != map2.m_height)
                return false;

            for (int i = 0; i < map1.m_width; i++)
            {
                for (int j = 0; j < map1.m_height; j++)
                {
                    if (map1.m_map[i, j] != map2.m_map[i, j])
                        return false;
                }
            }

            return true;
        }

        static public bool operator !=(Map map1, Map map2)
        {
            return !(map1 == map2);
        }

        public override int GetHashCode()
        {
            return m_width + m_height;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Map))
                return false;

            return (obj as Map == this);
        }

        public string name
        {
            get { return m_name; }
        }

        public void Save(string path)
        {
            DataTable dt = new DataTable("Map");

            dt.Columns.Add("map", typeof(int[]));
            dt.Columns.Add("width", typeof(int));
            dt.Columns.Add("height", typeof(int));
            dt.Columns.Add("name", typeof(string));

            DataRow dr = dt.NewRow();
            int[] map = new int[m_width * m_height];

            for (int i = 0; i < m_width; i++)
            {
                for (int j = 0; j < m_height; j++)
                {
                    map[j + i * m_height] = m_map[i, j];
                }
            }

            int index = 0;

            dr[index++] = map;
            dr[index++] = m_width;
            dr[index++] = m_height;
            dr[index++] = m_name;

            dt.Rows.Add(dr);

            try
            {
                dt.WriteXml(path, XmlWriteMode.WriteSchema);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Load(string path)
        {
            DataTable dt = new DataTable();
            int[] map = null;
            
            try
            {
                dt.ReadXml(path);

                DataRow dr = dt.Rows[0];
                int index = 0;

                map = (int[])dr[index++];
                m_width = (int)dr[index++];
                m_height = (int)dr[index++];
                m_name = (string)dr[index++];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            m_map = new int[m_width, m_height];
            m_tempMap = new int[m_width, m_height];

            for (int i = 0; i < m_width; i++)
            {
                for (int j = 0; j < m_height; j++)
                {
                    m_map[i, j] = map[j + i * m_height];
                }
            }
        }

        #endregion
    }
}
