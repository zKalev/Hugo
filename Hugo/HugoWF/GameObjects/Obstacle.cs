using Hugo.GameObjects.Enemies;
using Hugo.GameObjects.Players;
using Hugo.Helpers;
using Hugo.Properties;
using Hugo.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo.GameObjects
{
    public abstract class Obstacle : Enemy
    {

        public Obstacle(Coord location)
            : base(location)
        {
            this.IsVisible = true;
        }

        public override void ApplyEffects(IPlayer player)
        {
            // The obstacle does no damage
        }
    }
}
