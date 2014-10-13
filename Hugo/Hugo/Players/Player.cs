﻿using Hugo.Exceptions;
using Hugo.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo.Players
{
   public class Player : IPlayer
    {
        private char[] shape;
        private Coord location;
        private string name;
        private Gender gender;
        private int points = 20;
        private LinkedList<Coord> path;
        private Colors color;

        public Player(string name, Gender gender,Colors color)
        {
            this.Path = new LinkedList<Coord>();
            this.Name = name;
            this.Gender = gender;
            this.Color = color;
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

       public  Colors Color
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
