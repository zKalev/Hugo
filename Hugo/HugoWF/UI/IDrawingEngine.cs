﻿namespace Hugo.UI
{
    using GameObjects;
    using Helpers;
    using GameObjects.Players;
    using System.Collections.Generic;

    public interface IDrawingEngine
    {
        Coord TopLeft { get; }

        Coord BottomRight { get; }

		IList<Coord> InitialCoords { get; }

        int Margin { get; }

        float CellSize { get; set; }

        void DrawBoardFields();

        void DrawPlayers(IEnumerable<IPlayer> players);

        void DrawObjects(IList<IGameObject> gameObjects);

    }
}