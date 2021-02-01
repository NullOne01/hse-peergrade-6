using Peergrade6.Utilities.Serialize;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Text.Json.Serialization;

namespace Peergrade6.Model.Style
{
    /// <summary>
    /// Basically color scheme.
    /// </summary>
    class BaseTheme
    {
        public SerializedFont DefaultTabFont { get; set; } = new Font("Segoe UI", 9);

        public virtual string Name { get; set; } = "BaseTheme";

        // We need to save colors in HEX to make them serialized. 
        // I don't fucking know, but default json cannot deserialize
        // (but can serialize) colors, but strings can.

        public virtual string BackgroundColorHex { get; set; }
        public virtual string ForegroundColorHex { get; set; }
        public virtual string AssistColorHex { get; set; }

        [JsonIgnore]
        public Color BackgroundColor {
            get {
                return ColorTranslator.FromHtml(BackgroundColorHex);
            }
            set {
                BackgroundColorHex = ColorHelper.FromColorToHex(value);
            }
        }
        [JsonIgnore]
        public Color ForegroundColor {
            get {
                return ColorTranslator.FromHtml(ForegroundColorHex);
            }
            set {
                ForegroundColorHex = ColorHelper.FromColorToHex(value);
            }
        }
        [JsonIgnore]
        public Color AssistColor {
            get {
                return ColorTranslator.FromHtml(AssistColorHex);
            }
            set {
                AssistColorHex = ColorHelper.FromColorToHex(value);
            }
        }

    }
}
