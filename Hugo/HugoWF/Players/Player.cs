namespace Hugo.Players
{
    using Hugo.Exceptions;
    using Hugo.Helpers;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Player : IPlayer
    {
        private char[] shape;
        private Coord location;
        private string name;
        private Gender gender;
        private int points = 20;
        private LinkedList<Coord> path;
        private Color color;

        public Player(string name, Coord location, Gender gender, Color color)
        {
            this.Path = new LinkedList<Coord>();
            this.Name = name;
            this.Gender = gender;
            this.Color = color;
            this.Location = location;
        }

        public Player(string name, Gender gender, Color color)
            : this(name, new Coord(), gender, color)
        {
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
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
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

        char[] IPlayer.Shape
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

        Coord IPlayer.Location
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

        public Color Color
        {
            get
            {
                return this.color;
            }

            set
            {
                this.color = value;
            }
        }
    }
}
