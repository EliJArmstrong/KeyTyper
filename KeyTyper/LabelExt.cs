// <author>Eli Armstrong</author>
// <remarks>I pledge my word of honor that I have abided
// by the CSN Academic Integrity Policy while completing
// this assignment.</remarks>
// <file>LabelExt.cs</file>
// <date>2018-10-16</date>
// <summary>This class is to represents the abstract idea of a Two Dimensional 
// Shape.</summary> 
// <remarks>Time taken to develop, write, test and debug
// solution. About 4 hours. </remarks>

using System.Windows.Forms;

// ----------------------------------------------------------------------------
// The Name Space for KeyTyper.
// ----------------------------------------------------------------------------
namespace KeyTyper
{
    /// -----------------------------------------------------------------------
    /// <summary>
    /// The LabelExt (Label Extension) class with base of Label.
    /// </summary>
    /// -----------------------------------------------------------------------
    class LabelExt : Label
    {
        /// -------------------------------------------------------------------
        /// <summary>Gets or sets the key associated with the label.</summary>
        /// 
        /// <remarks>The key can be set in the properties window in the 
        /// design file.</remarks>
        /// -------------------------------------------------------------------
        public Keys Key { get; set; }
    }
}

