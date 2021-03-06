﻿namespace Hugo.GameObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Utils;
    using System.Drawing;

    public interface IGameObject
    {
        Coord Location { get; set; }

        bool IsVisible { get; set; }

        Color Color { get; set; }

        void Draw(Graphics graphics);
    }
}