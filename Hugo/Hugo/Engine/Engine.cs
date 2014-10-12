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
        private static Engine engine;

        private IList<IPlayer> players;

        private IList<IGameObject> gameObjects;

        private IDrawingEngine drawingEngine;

        private const string DefaultPlayerNameOne="player 1";
        private const string DefaultPlayerNameTwo="player 2";

        private Engine()
        {
            this.Players = new List<IPlayer>();
        }

        public static Engine GetInstance()
        {
            if (engine == null)
            {
                engine = new Engine();
            }
            return engine;
        }

        public void StartGame()
        {
            if (this.Players.Count == 0)
            {
                this.Players.Add(new Player(DefaultPlayerNameOne,Gender.Male));
                this.Players.Add(new Player(DefaultPlayerNameTwo,Gender.Female));
            }


        }


        public void CreatePlayer(string name, Gender gender)
        {
			this.Players.Add(new Player(name, gender));
        }

        public IList<IPlayer> Players
        {
            get
            {
                return this.players;
            }
            set
            {
                this.players = value;
            }
        }

        public IList<IGameObject> GameObjects
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IDrawingEngine DrawingEngine
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}