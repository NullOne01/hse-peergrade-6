using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Peergrade6.Utilities.Serialize
{
    /// <summary>
    /// This class uses default Font class. We need it to make possible
    /// json serialization. It needs to have zero argument constructor.
    /// </summary>
    class SerializedFont
    {
        public Font font;

        public SerializedFont() {
            font = new Font("Segoe UI", 9);
        }

        public static implicit operator Font(SerializedFont d) => d.font;

        public static implicit operator SerializedFont(Font v) {
            SerializedFont newFont = new SerializedFont();
            newFont.font = v;
            return newFont;
        }
    }
}
