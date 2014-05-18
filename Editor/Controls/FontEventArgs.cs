﻿namespace Qisi.Editor.Controls
{
    using System;
    using System.Drawing;
    using System.Runtime.CompilerServices;

    public class FontEventArgs : EventArgs
    {
        public FontEventArgs(System.Drawing.Font font)
        {
            this.Font = font;
        }

        public System.Drawing.Font Font { get; set; }
    }
}
