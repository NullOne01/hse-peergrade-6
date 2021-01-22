using Peergrade6.Model.Style;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Peergrade6.Model.Themes
{
    class DarkTheme : BaseTheme
    {
        public override Color BackgroundColor { get; set; } = Color.Gray;
        public override Color ForegroundColor { get; set; } = Color.Black;
        public override Color AssistColor { get; set; } = Color.White;
    }
}
