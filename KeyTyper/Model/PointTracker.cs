// <author>Eli Armstrong</author>
// <remarks>I pledge my word of honor that I have abided
// by the CSN Academic Integrity Policy while completing
// this assignment.</remarks>
// <file>PointTracker.cs</file>
// <date>2018-10-16</date>
// <summary>This class is to track and set the point of a game with two players
// or team</summary> 
// <remarks>Time taken to develop, write, test and debug
// solution. About 4 hours. </remarks>

// ----------------------------------------------------------------------------
// The Name Space for KeyTyper.
// ----------------------------------------------------------------------------
namespace KeyTyper
{
    /// -----------------------------------------------------------------------
    /// <summary>The PointTracker class.</summary>
    /// -----------------------------------------------------------------------
    class PointTracker
    {

        /// -------------------------------------------------------------------
        /// <summary>Constructor</summary>
        ///
        /// <remarks>
        /// The constructor sets the points to zero for both teams
        /// </remarks>
        /// -------------------------------------------------------------------
        public PointTracker()
        {
            ResetPoints();
        }

        /// -------------------------------------------------------------------
        /// <summary>Gets or sets the blue team points.</summary>
        ///
        /// <remarks>The set is private.</remarks>
        /// -------------------------------------------------------------------
        public int Blue { get; private set; }

        /// -------------------------------------------------------------------
        /// <summary>Gets or sets the red team points.</summary>
        ///
        /// <remarks>The set is private.</remarks>
        /// -------------------------------------------------------------------
        public int Red { get; private set; }

        /// -------------------------------------------------------------------
        /// <summary>Resets the points for both teams.</summary>
        /// -------------------------------------------------------------------
        public void ResetPoints()
        {
            Blue = 0;
            Red = 0;
        }

        /// -------------------------------------------------------------------
        /// <summary>Adds one point for the red team</summary>
        /// -------------------------------------------------------------------
        public void OnePointRed()
        {
            Red++;
        }

        /// -------------------------------------------------------------------
        /// <summary>Adds one point for the blue team</summary>
        /// -------------------------------------------------------------------
        public void OnePointBlue()
        {
            Blue++;
        }
    }
}
