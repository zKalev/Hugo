namespace Hugo.GameObjects.Enemies
{
    using Hugo.Helpers;
    using Hugo.GameObjects.Players;
    using System.Linq;
    using System.Drawing;
    using System.Collections.Generic;

    public abstract class Enemy : GameObject, IEnemy
    {
        protected const int DefautDamage = 20;

        public Enemy(Coord coordinates)
            : base(coordinates)
        {
        }

        /// <summary>
        /// By default all enemies will demage 20 points. 
        /// </summary>
        /// <param name="player"></param>
        public virtual void ApplyEffects(IPlayer player)
        {
            if (player.Points >= DefautDamage)
            {
                player.Points = player.Points - DefautDamage;
            }
        }
    }
}
