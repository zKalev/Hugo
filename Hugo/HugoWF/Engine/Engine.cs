namespace Hugo.Engine
{
    using System.Collections.Generic;
    using Players;
    using GameObjects;
    using UI;
    using Helpers;
    using System.Drawing;

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
                p.Location = new Coord(5 * this.DrawingEngine.CellSize, 6 * this.DrawingEngine.CellSize);
            }
        }

        public IList<Color> ExistingColors
        {
            get { return this.existingColors; }
            set { this.existingColors = value; }
        }

        public void StartGame()
        {
            switch (this.Players.Count)
            {
                // TODO: Implement other cases: 1 player, between 1 and 8 players
                // When one player added you should add a second player and give them both the correct initial locations
                // When more than two players are given by the user, you shoud assign them all the correct location so that they are symetric from the target which is on the center of the board
                case 0:
                    {
                        this.Players.AddLast(new Player(
                            DefaultPlayerNameOne,
                            this.DrawingEngine.TopLeft + new Coord(
                                this.DrawingEngine.Margin,
                                this.DrawingEngine.Margin),
                            Gender.Male,
                            Color.Red));

                        this.Players.AddLast(new Player(
                            DefaultPlayerNameTwo,
                            this.DrawingEngine.BottomRight + new Coord(
                                this.DrawingEngine.Margin,
                                this.DrawingEngine.Margin),
                            Gender.Female,
                            Color.Blue));

                        break;
                    }
                default:
                    break;
            }

            // Create a target
            Coord targetLocation = (
                DrawingEngine.BottomRight +
                DrawingEngine.TopLeft +
                new Coord(DrawingEngine.Margin, DrawingEngine.Margin) * 2) / 2;

            this.ObjectFactory.CreateTarget(this.GameObjects, targetLocation);

            // TODO: Create a random number of game objects of random types and on random locations

        }

        public void Run()
        {
            GameFieldForm gf = new GameFieldForm();
            gf.Show();
            (DrawingEngine as WFormDrawingEngine).Form = gf;

            DrawingEngine.DrawBoardFields();
            DrawingEngine.DrawPlayers(this.Players);

            // TODO: Draw gameObjects
            DrawingEngine.DrawObjects(this.GameObjects);
        }

        public void CreatePlayer(string name, Gender gender, Color color)
        {
            this.Players.AddLast(new Player(name, gender, color));
        }

        public IPlayer GetCurrentPlayer()
        {
            return this.Players.First.Value;
        }

        public void ChangeTurn()
        {
            IPlayer holder = this.Players.First.Value;
            this.Players.RemoveFirst();
            this.Players.AddLast(holder);
        }
    }
}