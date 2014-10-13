using Hugo.Exceptions;
using Hugo.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo.Players
{
    class Player : IPlayer
    {
        private char[] shape;
        private Coord location;
        private string name;
        private Gender gender;
        private int points;
        private LinkedList<Coord> path;

        public Player(string name, Gender gender)
        {
            this.Path = new LinkedList<Coord> ();
            this.Name = name;
            this.Gender = gender;
        }

        public char[] Shape
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

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidNameException();
                }
                this.name = value;
            }
        }

        public Gender Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
        }

        public int Points
        {
            get
            {
                return this.points;
            }
            set
            {
                this.points = value;
            }
        }

        public LinkedList<Coord> Path
        {
            get
            {
                return this.path;
            }
            set
            {
                this.path = value;
            }
        }
    }
}
