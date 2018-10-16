// https://www.academy.rootsofts.org/post?post_id=42

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace KeyTyper
{
    class GradientGroup : GroupBox
    {
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(
                this.ClientRectangle, this.ColorTop, this.ColorBottom, this.Width);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
