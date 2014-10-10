namespace Hugo.UI
{
    using Helpers;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ConsoleDrawingEngine : IDrawingEngine
    {
        public Coord TopLeft
        {
            get { throw new NotImplementedException(); }
        }

        public Coord BottomRight
        {
            get { throw new NotImplementedException(); }
        }
       

        public string UIContent
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

        public void DrawPlayers(IList<Players.IPlayer> players)
        {
            throw new NotImplementedException();
        }

        public void DrawObjects(IList<GameObjects.IGameObject> gameObjects)
        {
            throw new NotImplementedException();
        }


    }
}