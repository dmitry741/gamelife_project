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
    public partial class frmPresetMap : Form
    {
        public frmPresetMap()
        {
            InitializeComponent();
        }
    }

    class PresetMaps
    {
        private static int[,] Transform(int[,] m)
        {
            int xBound = m.GetUpperBound(0) + 1;
            int yBound = m.GetUpperBound(1) + 1;

            int[,] map = new int[yBound, xBound];

            for (int i = 0; i < xBound; i++)
            {
                for (int j = 0; j < yBound; j++)
                {
                    map[j, i] = m[i, j];
                }
            }

            return map;
        }

        static public int[,] glider
        {
            get
            {
                int[,] map = {  { 0, 1, 0 },
                                { 0, 0, 1 },
                                { 1, 1, 1 },
                };

                return Transform(map);
            }
        }

        static public int[,] steamTrain
        {
            get
            {
                int[,] map =  { { 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 1, 0, 1, 0, 0, 0 },
                                { 0, 0, 1, 1, 0, 1, 1, 0, 0, 1, 1, 0, 1, 1, 1, 1, 0 },
                                { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 0, 0, 1, 1 },
                                { 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 0, 1, 0, 0, 1, 1 },
                                { 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0 },
                                { 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };

                return Transform(map);
            }
        }
    }
}
