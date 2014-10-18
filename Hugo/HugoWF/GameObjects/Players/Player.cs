﻿namespace Hugo.GameObjects.Players
{
	using Hugo.Exceptions;
	using Hugo.Helpers;
	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class Player : GameObject, IPlayer
	{
		private string name;
		private Gender gender;
		private int points = 20;
		private LinkedList<Coord> path;

		public Player(string name, Coord location, Gender gender, Color color)
			: base(location, color, true)
		{
			this.Path = new LinkedList<Coord>();
			this.Path.AddLast(location);
			this.Name = name;
			this.Gender = gender;
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

		public Coord Move(Graphics graphics, Coord destination)
		{
			this.Location = destination;
			this.Path.AddLast(this.Location);
			Draw(graphics);

			return this.Location;
		}

		public Coord CalculateNextStep(float x, float y)
		{
			float nextX = this.Location.X + x;
			float nextY = this.Location.Y + y;

			return new Coord(nextX, nextY);
		}
	}
}
