namespace Hugo.GameObjects
{
    using Hugo.Helpers;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class GameObject : IGameObject
    {
        private Coord location;
        private Color objectColor;
        private bool isVisible;

        public GameObject(Coord location)
        {
            this.Location = location;
            this.Color = Color.Black;
        }

        public GameObject(Coord location, Color objectColor, bool isVisible = false)
            : this(location)
        {
            this.Color = objectColor;
            this.IsVisible = isVisible;
        }

        public char[] Shape
        {
            get { throw new NotImplementedException(); }
        }

        public Coord Location
        {
            get
            {
                return this.location;
            }
            set
            {
                this.location = value;
            }
        }

        public IList<IEffect> Effects
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool IsVisible
        {
            get
            {
                return this.isVisible;
            }
            set
            {
                this.isVisible = value;
            }
        }

        public Color Color
        {
            get { return this.objectColor; }
            set { this.objectColor = value; }
        }
    }
}
