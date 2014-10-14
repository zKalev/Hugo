namespace Hugo.UI
{
    using GameObjects;
    using Helpers;
    using Players;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IDrawingEngine
    {
        Coord TopLeft { get; }
        Coord BottomRight { get; }

        string UIContent { get; set; }

        void DrawPlayers(IList<IPlayer> players);

        void DrawObjects(IList<IGameObject> gameObjects);

    }
}