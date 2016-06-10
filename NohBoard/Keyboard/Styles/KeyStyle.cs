﻿/*
Copyright (C) 2016 by Eric Bataille <e.c.p.bataille@gmail.com>

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 2 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

namespace ThoNohT.NohBoard.Keyboard.Styles
{
    using System.Drawing;
    using System.Runtime.Serialization;
    using Extra;

    /// <summary>
    /// The style for a key definition.
    /// </summary>
    [DataContract(Name = "KeyStyle", Namespace = "")]
    public class KeyStyle : ElementStyle
    {
        [DataMember]
        public SerializableColor BackgroundLoose { get; set; } = Color.FromArgb(100, 100, 100);

        [DataMember]
        public SerializableColor BackgroundPressed { get; set; } = Color.FromArgb(255, 255, 255);

        [DataMember] 
        public SerializableColor TextLoose { get; set; } = Color.FromArgb(0, 0, 0);

        [DataMember]
        public SerializableColor TextPressed { get; set; } = Color.FromArgb(0, 0, 0);

        [DataMember]
        public SerializableColor OutlineLoose { get; set; } = Color.FromArgb(0, 255, 0);

        [DataMember]
        public SerializableColor OutlinePressed { get; set; } = Color.FromArgb(0, 255, 0);

        [DataMember]
        public bool ShowOutlineLoose { get; set; }

        [DataMember]
        public bool ShowOutlinePressed { get; set; }

        [DataMember]
        public SerializableFont UnpressedFont { get; set; } = new Font(FontFamily.GenericMonospace, 10);

        [DataMember]
        public SerializableFont PressedFont { get; set; } = new Font(FontFamily.GenericMonospace, 10);

        public override ElementStyle Clone()
        {
            return new KeyStyle
            {
                BackgroundLoose = this.BackgroundLoose.Clone(),
                BackgroundPressed = this.BackgroundPressed.Clone(),
                TextLoose = this.TextLoose.Clone(),
                TextPressed = this.TextPressed.Clone(),
                OutlineLoose = this.OutlineLoose.Clone(),
                OutlinePressed = this.OutlinePressed.Clone(),
                ShowOutlineLoose = this.ShowOutlineLoose,
                ShowOutlinePressed = this.ShowOutlinePressed,
                UnpressedFont = this.UnpressedFont.Clone(),
                PressedFont = this.PressedFont.Clone()
            };
        }
    }
}