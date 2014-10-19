namespace Hugo.GameObjects
{
    using Hugo.GameObjects.Players;
    using Hugo.Helpers;

    public abstract class Friend : GameObject, IFriend
    {
        protected const int DefaultHelp = 20;

        public Friend(Coord coord)
            : base(coord)
        {
        }

        public virtual void ApplyEffects(IPlayer player)
        {
            player.Points = player.Points - DefaultHelp;
        }
    }
}
