using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConwaysGameLife
{
    interface ILifeRule
    {
        int NewCell(int neighbors);
        int ContinueLife(int neighbors);
    }

    class ClassicConwaysRules : ILifeRule
    {
        public int NewCell(int neighbors)
        {
            return (neighbors == 3) ? 1 : 0;
        }

        public int ContinueLife(int neighbors)
        {
            return (neighbors == 2 || neighbors == 3) ? 2 : 0;
        }
    }
}
