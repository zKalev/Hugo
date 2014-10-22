namespace Hugo.GameObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GameObjects;
    using Hugo.Utils;

    public interface IObjectFactory
    {
        IEnemy CreateBomb(IList<IGameObject> gameObjects, Coord location);

        IEnemy CreateStone(IList<IGameObject> gameObjects, Coord location);

        IEnemy CreateRepulser(IList<IGameObject> gameObjects, Coord location);

        IFriend CreateApproacher(IList<IGameObject> gameObjects, Coord location);

        ITarget CreateTarget(IList<IGameObject> gameObjects, Coord location);

        void CreateRandomObjects(Coord minLocation, Coord maxLocation, int objectsCount, IList<IGameObject> gameObjects);
    }
}