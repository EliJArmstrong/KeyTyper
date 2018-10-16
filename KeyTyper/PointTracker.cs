using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyTyper
{
    class PointTracker
    {
        private int blue = 0;
        private int red = 0;

        public int Blue { get => blue; private set => blue = value; }
        public int Red { get => red; private set => red = value; }

        public void ResetPoints()
        {
            Blue = 0;
            Red = 0;
        }

        public void OnePointRed()
        {
            Red++;
        }

        public void OnePointBlue()
        {
            Blue++;
        }
    }
}
