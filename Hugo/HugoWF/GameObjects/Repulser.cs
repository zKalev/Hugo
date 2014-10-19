namespace Hugo.GameObjects
{
    using Hugo.GameObjects.Enemies;
    using Hugo.GameObjects.Players;
    using Hugo.Helpers;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Repulser : Enemy
    {
         public Repulser(Coord coord)
            : base(coord)
        {
        }

         public override void Apply(IPlayer player)
         {
             base.Apply(player);
         }
    }
}