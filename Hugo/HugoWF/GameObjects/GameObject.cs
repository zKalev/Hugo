﻿namespace Hugo.GameObjects
{
    using Hugo.Utils;
    using Hugo.UI;
    using System;
    using System.Collections.Generic;

    using System.Drawing;

    public abstract class GameObject : IGameObject
    {
        private Coord location;
        private Color objectColor;
        private bool isVisible;

        public GameObject(Coord location)
            : this(location, Color.Black, false)
        {
        }

        public GameObject(Coord location, Color objectColor, bool isVisible = false)
        {
            this.Location = location;
            this.Color = objectColor;
            this.IsVisible = isVisible;
        }

        public Coord Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        public bool IsVisible
        {
            get { return this.isVisible; }
            set { this.isVisible = value; }
        }

        public Color Color
        {
            get { return this.objectColor; }
            set { this.objectColor = value; }
        }

        public virtual void Draw(Graphics graphics)
        {
            int cellSize = WFormDrawingEngine.CellSize;
            if (this.IsVisible)
            {
                graphics.FillRectangle(new SolidBrush(this.Color), this.Location.X * cellSize, this.Location.Y * cellSize, cellSize, cellSize);
            }
        }

    }
}
