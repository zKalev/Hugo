﻿namespace Hugo.GameObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Helpers;
    using System.Drawing;

    public class Target : GameObject, ITarget
    {
        public Target(Coord location)
            : base(location)
        {
            this.IsVisible = true;
            this.Location = location;
        }

        public Target(Coord location, Color objectColor)
            : this(location)
        {
            this.ObjectColor = objectColor;
        }
    }
}