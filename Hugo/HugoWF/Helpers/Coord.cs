namespace Hugo.Helpers
{
    public struct Coord
    {
        public Coord(int x, int y)
            : this()
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public static Coord operator +(Coord first, Coord second)
        {
            Coord sum = new Coord(first.X + second.X, first.Y + second.Y);
            return sum;
        }

        public static Coord operator -(Coord first, Coord second)
        {
            Coord subtract = new Coord(first.X - second.X, first.Y - second.Y);
            return subtract;
        }

        public static Coord operator /(Coord first, int divisor)
        {
            Coord divisionResult = new Coord(first.X / divisor, first.Y / divisor);
            return divisionResult;
        }

        public static Coord operator *(Coord first, int multiplier)
        {
            Coord multiplicationResult = new Coord(first.X * multiplier, first.Y * multiplier);
            return multiplicationResult;
        }

        public void ChangeToLeft(int step)
        {
            this.X -= step;
            if (this.X < 0)
            {
                this.X = 0;
            }
        }

        public void ChangeToRight(int step)
        {
            this.X += step;
        }

        public void ChangeToDown(int step)
        {
            this.Y += step;
        }

        public void ChangeToUp(int step)
        {
            this.Y -= step;
            if (this.Y < 0)
            {
                this.Y = 0;
            }
        }
    }
}