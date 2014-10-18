namespace Hugo.GameObjects
{
	using Hugo.Helpers;
	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

    public abstract class Friend : GameObject, IFriend
    {
        public Friend(Coord coord)
            : base(coord)
        {
        }

        public void Apply(GameObjects.Players.IPlayer player)
        {
            throw new NotImplementedException();
        }

    }
}
