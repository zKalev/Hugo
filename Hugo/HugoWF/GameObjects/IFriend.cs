namespace Hugo.GameObjects
{
    using Hugo.GameObjects.Players;

    public interface IFriend : IGameObject
    {
        void ApplyEffects(IPlayer player);
    }
}