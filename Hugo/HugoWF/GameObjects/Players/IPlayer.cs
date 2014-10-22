namespace Hugo.GameObjects.Players
{
    using Utils;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IPlayer : IGameObject

    {
        string Name { get; set; }

        Gender Gender { get; set; }

        int Points { get; set; }

        LinkedList<Coord> Path { get; set; }

		Coord Move(Graphics graphics, Coord destination);

		Coord CalculateNextStep(int x, int y);
    }
}