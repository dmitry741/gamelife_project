using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConwaysGameLife
{
    interface ILifeRule
    {
        int GetCellStatuc(int neighbors, int currentStatus);
    }

    class ClassicConwaysRules : ILifeRule
    {
        public int GetCellStatuc(int neighbors, int currentStatus)
        {
            // 0 -no cell
            // 1 - new cell
            // 2 - old cell

            int status;

            if (currentStatus == 0)
            {
                status = (neighbors == 3) ? 1 : 0;
            }
            else
            {
                status = (neighbors == 2 || neighbors == 3) ? 2 : 0;
            }

            return status;
        }
    }

    class MyLifeMyRules : ILifeRule
    {
        public int GetCellStatuc(int neighbors, int currentStatus)
        {
            // 0 -no cell
            // 1 - new cell
            // 2 - old cell

            int status;

            if (currentStatus == 0)
            {
                status = (neighbors == 3) ? 1 : 0;
            }
            else
            {
                status = (neighbors == 3 || neighbors == 5) ? 2 : 0;
            }

            return status;
        }
    }       
}
