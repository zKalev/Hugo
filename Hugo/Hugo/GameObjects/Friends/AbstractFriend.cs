using Hugo.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo.GameObjects.Friends
{
   public abstract class AbstractFriend:AbstractGameObject,IFriend
    {

       public AbstractFriend(Coord coord):base(coord)
       {
       }

        public void Apply(Players.IPlayer player)
        {
            throw new NotImplementedException();
        }
    }
}
