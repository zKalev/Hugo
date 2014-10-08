namespace Hugo.GameObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Helpers;

    public interface IEnemy : IGameObject
    {
        IDamage Damage { get; set; }
    }
}