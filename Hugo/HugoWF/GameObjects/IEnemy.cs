namespace Hugo.GameObjects
{
    using Hugo.GameObjects.Players;

    public interface IEnemy :IGameObject
    {
        void ApplyEffects(IPlayer player);
    }
}