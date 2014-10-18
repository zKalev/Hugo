namespace Hugo.GameObjects.Enemies
{
    using Hugo.Helpers;
    using Hugo.GameObjects.Players;
    using System.Linq;
	using System.Drawing;

    public abstract class Enemy : GameObject, IEnemy
    {
        private int enemyDamage;
        protected const int DefautDamage = 20;
        protected const int DefaultBackSteps = 2;

        public Enemy(Coord coordinates)
            : base(coordinates)
        {
        }

        /// <summary>
        /// By default all enemies will demage 20 points. If player's  points are less than 20, he must go 2 steps back  
        /// </summary>
        /// <param name="player"></param>
        public void Apply(IPlayer player)
        {
            if (player.Points < DefautDamage)
            {
                int playerPathLenght = player.Path.Count;
                player.Location = player.Path.ElementAt(playerPathLenght - DefaultBackSteps);
            }
            else
            {
                player.Points = player.Points - DefautDamage;
            }
        }

        public int EnemyDamage
        {
            get
            {
                return this.enemyDamage;
            }

            set
            {
                this.enemyDamage = value;
            }
        }

		public override void Draw(Graphics graphics)
		{
			object obstacle = Properties.Resources.ResourceManager.GetObject("obstacle.png");
			if (obstacle is Image)
			{
				Image obstacleImg = obstacle as Image;
				Point point = new Point(Location.X, Location.Y);
				graphics.DrawImage(obstacleImg, point);
			}
		}
    }
}
