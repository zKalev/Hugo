namespace Hugo.Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GameObjects;

    public interface IObjectFactory
    {
        IEnemy CreateObstacle();

        IEnemy CreateRepulser();

        IFriend CreateApproacher();

        ITarget CreateTarget();
    }
}