﻿namespace Hugo.Engine
{
    using System.Collections.Generic;
    using GameObjects.Players;
    using GameObjects;
    using UI;
    using Helpers;
    using System.Drawing;
    using System.Windows.Forms;

    public class Engine : IEngine
    {
        private static Engine engine;

        private const string DefaultPlayerNameOne = "player1";
        private const string DefaultPlayerNameTwo = "player2";

        private LinkedList<IPlayer> players;
        private IList<IGameObject> gameObjects;
        private IList<Color> existingColors;

        private Engine()
        {
            this.Players = new LinkedList<IPlayer>();
            this.ExistingColors = new List<Color>();
            this.GameObjects = new List<IGameObject>();
        }

        public LinkedList<IPlayer> Players
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
                return this.gameObjects;
            }

            set
            {
                this.gameObjects = value;
            }
        }

        public IDrawingEngine DrawingEngine
        {
            get
            {
                return WFormDrawingEngine.GetDrawingEngine();
            }

        }

        public IObjectFactory ObjectFactory
        {
            get { return GameObjectFactory.GetInstance(); }
        }

        public static Engine GetInstance()
        {
            if (Engine.engine == null)
            {
                Engine.engine = new Engine();
            }

            return Engine.engine;
        }

        private void SetStartPositionForPlayers()
        {
            foreach (IPlayer p in this.Players)
            {
                p.Location = new Coord(5 * WFormDrawingEngine.CellSize, 6 * WFormDrawingEngine.CellSize);
            }
        }

        public IList<Color> ExistingColors
        {
            get { return this.existingColors; }
            set { this.existingColors = value; }
        }

        public void StartGame()
        {
            // Clear object from previous start
            this.GameObjects = new List<IGameObject>();

            // Create a target
            this.ObjectFactory.CreateTarget(this.GameObjects, DrawingEngine.InitialCoords[0]);

            // TODO: Create a random number of game objects of random types and on random locations
            this.ObjectFactory.CreateRandomObjects(DrawingEngine.TopLeft, DrawingEngine.BottomRight, 20, this.GameObjects);

            if (this.Players.Count == 0)
            {
                CreatePlayer(DefaultPlayerNameOne, Gender.Male,
                            Color.Blue);
                CreatePlayer(DefaultPlayerNameTwo, Gender.Female,
                            Color.Pink);
            }
            else if (this.Players.Count == 1)
            {
                CreatePlayer(DefaultPlayerNameTwo, Gender.Female,
                            Color.Pink);
            }
        }

        public void Run()
        {
            GameFieldForm gf = new GameFieldForm();
            gf.Show();
            (DrawingEngine as WFormDrawingEngine).Form = gf;

            DrawingEngine.DrawBoardFields();
            DrawingEngine.DrawPlayers(this.Players);

            DrawingEngine.DrawObjects(this.GameObjects);
        }

        public void CreatePlayer(string name, Gender gender, Color color)
        {
            Coord location = DrawingEngine.InitialCoords[this.Players.Count + 1];
            this.Players.AddLast(new Player(name, location, gender, color));
        }

        public IPlayer GetCurrentPlayer()
        {
            return this.Players.First.Value;
        }

        public void ChangeTurn()
        {
            IPlayer holder = GetCurrentPlayer();
            this.Players.RemoveFirst();
            this.Players.AddLast(holder);
        }

        public void MoveCurrentPlayer(int x, int y)
        {
            IPlayer currentPlayer = GetCurrentPlayer();
            Coord nextStep = currentPlayer.CalculateNextStep(x, y);
            bool isInGameField = DrawingEngine.IsInGameField(nextStep);

            if (isInGameField)
            {
                Graphics graphics = ((DrawingEngine as WFormDrawingEngine).Form).CreateGraphics();
                currentPlayer.Move(graphics, nextStep);

                ChangeTurn();
            }
            else
            {
                DrawingEngine.ShowMessage("You can't move outside the field! Try again!");
            }
        }
    }
}