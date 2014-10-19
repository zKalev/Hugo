namespace Hugo.GameObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Helpers;
    using GameObjects;
    using Hugo.GameObjects.Players;

    public interface IFriend : IGameObject
    {
       void ApplyEffects(IPlayer player);
    }
}