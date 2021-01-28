using Peergrade6.Model.Style;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Peergrade6.Model.Themes
{
    class WhiteTheme : BaseTheme
    {
        public override Color BackgroundColor { get; set; } = Color.White;
        public override Color ForegroundColor { get; set; } = Color.Black;
        public override Color AssistColor { get; set; } = Color.DarkOrange;
    }
}
