using System;
using System.Collections.Generic;
using System.Text;

namespace Peergrade6.Utilities.Serialize
{
    public class ColorHelper
    {
        /// <summary>
        /// Converts Color into Hex.
        /// </summary>
        /// <param name="c"> Some color to convert from. </param>
        /// <returns> HEX of the color. </returns>
        public static string FromColorToHex(System.Drawing.Color c) {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }
    }
}
