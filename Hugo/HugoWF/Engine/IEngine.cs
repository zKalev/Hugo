﻿namespace Hugo.Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GameObjects;
    using Players;
    using UI;
    using Hugo.Helpers;
    using System.Drawing;

    public interface IEngine
    {
        LinkedList<IPlayer> Players { get; set; }

        IList<IGameObject> GameObjects { get; set; }

        IDrawingEngine DrawingEngine { get; }

        IList<Color> ExistingColors { get; }

        void StartGame();

        IPlayer GetCurrentPlayer();

        void ChangeTurn();

        void CreatePlayer(string name, Gender gender, Color color);
    }
}