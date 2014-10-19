namespace Hugo.GameObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GameObjects;
    using Hugo.Helpers;

    public interface IObjectFactory
    {
        IEnemy CreateBomb(IList<IGameObject> gameObjects, Coord location);

		IEnemy CreateStone(IList<IGameObject> gameObjects, Coord location);

        IEnemy CreateRepulser(IList<IGameObject> gameObjects);

        IFriend CreateApproacher(IList<IGameObject> gameObjects);

        ITarget CreateTarget(IList<IGameObject> gameObjects, Coord location);

        IGameObject CreateRandomObjects(Coord minLocation, Coord maxLocation, int objectsCount, IList<IGameObject> gameObjects);
    }
}