namespace Hugo.Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Players;
    using GameObjects;

    public class Engine : IEngine
    {
        // TODO: Implement as Singleton

        IList<IPlayer> Players = new List<IPlayer>();

        IList<IGameObject> GameObjects = new List<IGameObject>();

    }
}