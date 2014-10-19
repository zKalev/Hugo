namespace Hugo.GameObjects
{
    using Hugo.GameObjects.Players;
    using Hugo.Helpers;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Approacher : Friend
    {
        protected const int DefaultForwardSteps = 2;

        public Approacher(Coord coord)
            : base(coord)
        {
        }

        public override void ApplyEffects(IPlayer player)
        {
        }
    }
}