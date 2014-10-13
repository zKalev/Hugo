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

        private const string DefaultPlayerNameOne = "player1";
        private const string DefaultPlayerNameTwo = "player2";

        private  IList<Colors> colors;

        private Engine()
        {
            this.Players = new List<IPlayer>();
            this.colors = new List<Colors>();
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
                this.Players.Add(new Player(DefaultPlayerNameOne, Gender.Male, Colors.Red));
                this.Players.Add(new Player(DefaultPlayerNameTwo, Gender.Female, Colors.Blue));
            }
        }

        public IList<Colors> ExistingColors
        {
            get
            {
                return this.colors;
            }
        }

        public void CreatePlayer(string name, Gender gender, Colors color)
        {

            this.Players.Add(new Player(name, gender, color));

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

        IList<IPlayer> IEngine.Players
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

        IList<IGameObject> IEngine.GameObjects
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

        IDrawingEngine IEngine.DrawingEngine
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

        void IEngine.StartGame()
        {
            throw new NotImplementedException();
        }
    }
}