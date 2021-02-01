using Peergrade6.Model.Style;
using Peergrade6.Utilities.Serialize;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Peergrade6.Model.Themes
{
    /// <summary>
    /// Dark color scheme.
    /// </summary>
    class DarkTheme : BaseTheme
    {
        public override string Name { get; set; } = "DarkTheme";
        public override string BackgroundColorHex { get; set; } = ColorHelper.FromColorToHex(Color.FromArgb(30, 30, 30));
        public override string ForegroundColorHex { get; set; } = ColorHelper.FromColorToHex(Color.White);
        public override string AssistColorHex { get; set; } = ColorHelper.FromColorToHex(Color.Orange);
    }
}
