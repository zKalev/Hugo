namespace Hugo.GameObjects
{
	using Hugo.Exceptions;
	using Hugo.Helpers;
	using Hugo.UI;
	using System;
	using System.Collections.Generic;

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
            Coord targetCoord = GetTargetCoordinates(gameObjects);
            IEnemy enemy = new Repulser(location, targetCoord);
            gameObjects.Add((IGameObject)enemy);

            return enemy;
        }

        public virtual IFriend CreateApproacher(IList<IGameObject> gameObjects, Coord location)
        {
            Coord targetCoord = GetTargetCoordinates(gameObjects);
            IFriend approacher = new Approacher(location, targetCoord);
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
			int margin = WFormDrawingEngine.margin;
            for (int objType = 0; objType < objectsCount; objType++)
            {
                Coord location = new Coord(
					random.Next(minLocation.X + margin, maxLocation.X + margin),
					random.Next(minLocation.Y + margin, maxLocation.Y + margin));

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

        private static Coord GetTargetCoordinates(IList<IGameObject> gameObjects)
        {
            Coord targetCoord;
            foreach (var obj in gameObjects)
            {
                if (obj as ITarget != null)
                {
                    targetCoord = obj.Location;
                    return targetCoord;
                }
            }
            throw new TargetMissingException();
        }
    }
}