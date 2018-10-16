
using System.Windows.Forms;

namespace KeyTyper
{
    class LabelExt : Label
    {
        private Keys key;
        public Keys Key { get => key; set => key = value; }
    }
}

