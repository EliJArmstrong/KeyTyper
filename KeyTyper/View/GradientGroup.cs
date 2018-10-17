// <author>Eli Armstrong</author>
// <remarks>I pledge my word of honor that I have abided
// by the CSN Academic Integrity Policy while completing
// this assignment.</remarks>
// <file>GradientGroup.cs</file>
// <date>2018-10-16</date>
// <summary>This is an "Extension" of the GroupBox to change the background 
// color to a two tone color.</summary> 
// <remarks>Time taken to develop, write, test and debug
// solution. About 4 hours. </remarks>
// <note>Gradient code from here: 
// https://www.academy.rootsofts.org/post?post_id=42 </note>


using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

// ----------------------------------------------------------------------------
// The Name Space for KeyTyper.
// ----------------------------------------------------------------------------
namespace KeyTyper
{
    /// -----------------------------------------------------------------------
    /// <summary>The GradientGroup class with base of GroupBox.</summary>
    /// -----------------------------------------------------------------------
    class GradientGroup : GroupBox
    {
        /// -------------------------------------------------------------------
        /// <summary>Gets or sets the top color for the gradient.</summary>
        /// 
        /// <remarks>The color can be set in the properties window in the 
        /// design file.</remarks>
        /// -------------------------------------------------------------------
        public Color ColorTop { get; set; }

        /// -------------------------------------------------------------------
        /// <summary>Gets or sets the bottom color for the gradient.</summary>
        /// 
        /// <remarks>The color can be set in the properties window in the 
        /// design file.</remarks>
        /// -------------------------------------------------------------------
        public Color ColorBottom { get; set; }


        /// -------------------------------------------------------------------
        /// <summary>This overrides the OnPaint method to give the background 
        /// is two tone color</summary>
        /// 
        /// <param name="e">The event arguments to be passed to the base on 
        /// paint method.</param>
        /// -------------------------------------------------------------------
        protected override void OnPaint(PaintEventArgs e)
        {
            // The linear gradient brush to show the two tones.
            LinearGradientBrush lgb = new LinearGradientBrush(
            this.ClientRectangle, this.ColorTop, this.ColorBottom, this.Width);

            // gets and stores the graphics for the passed PaintEventArgs.
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle); // fills the group.

            base.OnPaint(e);
        }
    }
}
