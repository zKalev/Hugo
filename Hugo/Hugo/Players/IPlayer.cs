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
    }
}