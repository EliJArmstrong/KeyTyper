using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyTyper
{
    class LabelExt : Label
    {
        private Keys key;

        public Keys Key { get => key; set => key = value; }

        public LabelExt() : base()
        {

        }

    }
}

