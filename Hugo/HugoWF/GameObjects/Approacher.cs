namespace Hugo.GameObjects
{
    using Hugo.GameObjects.Players;
    using Hugo.Utils;
    using System;

    public class Approacher : Friend
    {
        private Coord targetCoord;
        protected const int DefaultForwardSteps = 2;

        public Approacher(Coord coord)
            : base(coord)
        {
        }

        public Approacher(Coord coord, Coord targetCoord)
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

            Coord diffCoord = player.Location - this.TargetCoord;
            int newX = diffCoord.X / Math.Abs(diffCoord.X);
            int newY = diffCoord.Y / Math.Abs(diffCoord.Y);
            player.Location += new Coord(newX, newY) * (-DefaultForwardSteps);
        }
    }
}