namespace Hugo.Players
{
    using Helpers;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IPlayer
    {
        char[] Shape { get; set; }

        Coord Location { get; set; }

        string Name { get; set; }

        Gender Gender { get; set; }

        int Points { get; set; }

        LinkedList<Coord> Path { get; set; }
    }
}