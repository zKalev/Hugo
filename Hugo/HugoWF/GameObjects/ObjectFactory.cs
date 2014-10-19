namespace Hugo.GameObjects
{
    using Hugo.GameObjects.Enemies;
    using Hugo.Helpers;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GameObjectFactory : IObjectFactory
    {
        private static readonly IObjectFactory gameObjectFactory = new GameObjectFactory();
        private static Random random = new Random();

        private GameObjectFactory()
        {
        }

        public static IObjectFactory GetInstance()
        {
            if (null == GameObjectFactory.gameObjectFactory)
            {
                return new GameObjectFactory();
            }

            return GameObjectFactory.gameObjectFactory;
        }

        public virtual IEnemy CreateBomb(IList<IGameObject> gameObjects, Coord location)
        {
            IEnemy enemy = new ObstacleBomb(location);
            gameObjects.Add((IGameObject)enemy);

            return enemy;
        }

        public virtual IEnemy CreateStone(IList<IGameObject> gameObjects, Coord location)
        {
            IEnemy enemy = new ObstacleStone(location);
            gameObjects.Add((IGameObject)enemy);

            return enemy;
        }

        public virtual IEnemy CreateRepulser(IList<IGameObject> gameObjects, Coord location)
        {
            IEnemy enemy = new Repulser(location);
            gameObjects.Add((IGameObject)enemy);

            return enemy;
        }

        public virtual IFriend CreateApproacher(IList<IGameObject> gameObjects, Coord location)
        {
            IFriend approacher = new Approacher(location);
            gameObjects.Add(approacher);
            return approacher;
        }

        public virtual ITarget CreateTarget(IList<IGameObject> gameObjects, Coord location)
        {
            var target = new Target(location);

            gameObjects.Add(target);
            return target;
        }

        public virtual void CreateRandomObjects(Coord minLocation, Coord maxLocation, int objectsCount, IList<IGameObject> gameObjects)
        {
            for (int objType = 0; objType < objectsCount; objType++)
            {
                Coord location = new Coord(
                    random.Next(minLocation.X, maxLocation.X),
                    random.Next(minLocation.Y, maxLocation.Y));

                int objTypesCount = 4;

                switch (random.Next(objTypesCount))
                {
                    case 0:
                        CreateBomb(gameObjects, location);
                        break;
                    case 1:
                        CreateStone(gameObjects, location);
                        break;
                    case 2:
                        CreateRepulser(gameObjects, location);
                        break;
                    case 3:
                        CreateApproacher(gameObjects, location);
                        break;

                    default:
                        break;
                }
            }
        }


    }
}