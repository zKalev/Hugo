using Hugo.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo.GameObjects
{
 public  class AbstractGameObject:IGameObject
    {
        private Coord location;
        public AbstractGameObject(Coord location)
        {
            this.Location = location;
        }


        public char[] Shape
        {
            get { throw new NotImplementedException(); }
        }

        public Coord Location
        {
            get
            {
                return this.location;
            }
            set
            {
                this.location = value;
            }
        }

        public IList<IEffect> Effects
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

        public bool isVisible
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
    }
}
