namespace Hugo.GameObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Helpers;
    using System.Drawing;

    public interface IGameObject
    {
        Coord Location { get; set; }

        IList<IEffect> Effects { get; set; }

        bool IsVisible { get; set; }

        Color Color { get; set; }

		void Draw(Graphics graphics);
    }
}