using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace Peergrade6.Model.Style
{
    class BaseTheme
    {
        public virtual Color BackgroundColor { get; set; }
        public virtual Color ForegroundColor { get; set; }
        public virtual Color AssistColor { get; set; }

    }
}
