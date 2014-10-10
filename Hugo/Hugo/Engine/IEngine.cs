namespace Hugo.Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GameObjects;
    using Players;
    using UI;

    public interface IEngine
    {
        IList<IPlayer> Players { get; set; }

        IList<IGameObject> GameObjects { get; set; }

        IDrawingEngine DrawingEngine { get; set; }
    }
}
