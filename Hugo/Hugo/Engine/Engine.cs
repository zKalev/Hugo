namespace Hugo.Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Players;
    using GameObjects;
    using UI;

    public class Engine : IEngine
    {
        // TODO: Implement as Singleton

        IList<IPlayer> players;

        IList<IGameObject> gameObjects;

        IDrawingEngine drawingEngine;
    }
}