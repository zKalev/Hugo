﻿using Hugo.Helpers;
using Hugo.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo.GameObjects.Enemies
{
  abstract  class AbstractEnemy : AbstractGameObject, IEnemy
    {
        private int enemyDamage;
        protected const int DefautDamage = 20;
        protected const int DefaultBackSteps = 2;

        public AbstractEnemy(Coord coordinates)
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
                int playerPathLenght=player.Path.Count;
                player.Location = player.Path.ElementAt(playerPathLenght-DefaultBackSteps);
            }
            else
            {
                player.Points = player.Points - DefautDamage;
            }
        }

        public int  EnemyDamage
        {
            get
            {
               return  this.enemyDamage;
            }
            set
            {
                this.enemyDamage = value;
            }
        }
    }
}
