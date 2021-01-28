using Peergrade6.Model.Style;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Peergrade6.Model.Themes
{
    class DarkTheme : BaseTheme
    {
        public override Color BackgroundColor { get; set; } = Color.FromArgb(30, 30, 30);
        public override Color ForegroundColor { get; set; } = Color.White;
        public override Color AssistColor { get; set; } = Color.Orange;
    }
}
