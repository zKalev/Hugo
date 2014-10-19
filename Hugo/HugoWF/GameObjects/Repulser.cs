namespace Hugo.GameObjects
{
    using Hugo.GameObjects.Enemies;
    using Hugo.GameObjects.Players;
    using Hugo.Helpers;
    using System;

    public class Repulser : Enemy
    {
        private Coord targetCoord;
        protected const int DefaultBackwardSteps = 2;

        public Repulser(Coord coord)
            : base(coord)
        {
        }
        public Repulser(Coord coord, Coord targetCoord)
            : this(coord)
        {
            this.TargetCoord = targetCoord;
        }

        public Coord TargetCoord
        {
            get { return this.targetCoord; }
            set { this.targetCoord = value; }
        }

        public override void ApplyEffects(IPlayer player)
        {
            base.ApplyEffects(player);

            Coord diffCoord = this.TargetCoord - player.Location;
            int newX = diffCoord.X / Math.Abs(diffCoord.X);
            int newY = diffCoord.Y / Math.Abs(diffCoord.Y);
            player.Location = new Coord(newX, newY) * DefaultBackwardSteps;
        }
    }
}