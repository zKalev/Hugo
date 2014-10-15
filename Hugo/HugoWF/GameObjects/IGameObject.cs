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
        char[] Shape { get; }

        Coord Location { get; set; }

        IList<IEffect> Effects { get; set; }

        bool IsVisible { get; set; }

        Color ObjectColor { get; set; }
    }
}