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

		public virtual IEnemy CreateObstacle(IList<IGameObject> gameObjects, Coord location)
        {
			IEnemy enemy = new Obstacle(location);
			gameObjects.Add((IGameObject)enemy);

			return enemy;
        }

        public virtual IEnemy CreateRepulser(IList<IGameObject> gameObjects)
        {
            throw new NotImplementedException();
        }

        public virtual IFriend CreateApproacher(IList<IGameObject> gameObjects)
        {
            throw new NotImplementedException();
        }

        public virtual ITarget CreateTarget(IList<IGameObject> gameObjects, Coord location)
        {
            var target = new Target(location);

            gameObjects.Add(target);
            return target;
        }

        public virtual IGameObject CreateRandomObjects(Helpers.Coord minLocation, Helpers.Coord maxLocation, int objectsCount, IList<IGameObject> gameObjects)
        {
            throw new NotImplementedException();
        }
    }
}