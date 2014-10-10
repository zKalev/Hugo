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

        private Engine()
        {
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

        }


        public void CreatePlayer(string name, string gender)
        {

        }


        public IList<IPlayer> Players
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