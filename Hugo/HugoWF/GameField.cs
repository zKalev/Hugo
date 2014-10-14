﻿using Hugo.Engine;
using Hugo.Helpers;
using Hugo.Players;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HugoWF
{
    public partial class GameField : Form
    {

        private const float ElementSize = 50;
        private const float PlayerSize = ElementSize / 2;
        private const float MovingUnit = ElementSize / 2;

        private const int XStartDrawingPoint = 5;
        private const int XEndDrawingPoint = 25;

        private const int YStartDrawingPoint = 2;
        private const int YEndDrawingPoint = 23;

        private const int FontSize = 15;

        private const char StraightButtonChar = 'w';
        private const char LeftButtonChar = 'a';
        private const char RigthButtonChar = 'd';

        private Dictionary<Colors, Brush> colors;

        public GameField()
        {
            LoadColors();
            InitializeComponent();
        }

        private void GameField_Paint(object sender, PaintEventArgs e)
        {
            DrawField(e.Graphics);
            Engine.GetInstance().SetStartPositionForPlayers();
            DrawPlayersOnStartPosition(e.Graphics);
        }
        /// <summary>
        /// This method dwraw the field starts from x=5 y=2 and ends to x=25 y=23
        /// </summary>
        /// <param name="g"></param>
        private void DrawField(Graphics g)
        {
            for (int x = XStartDrawingPoint; x <= XEndDrawingPoint; x++)
            {
                for (int y = YStartDrawingPoint; y <= YEndDrawingPoint; y++)
                {
                    g.DrawRectangle(new Pen(Brushes.Brown), x * MovingUnit, y * MovingUnit, ElementSize, ElementSize);

                    if ((x != XEndDrawingPoint && y != YEndDrawingPoint) && (x != XStartDrawingPoint && y != YStartDrawingPoint))
                    {
                        g.FillRectangle(Brushes.Chocolate, x * MovingUnit + 1, y * MovingUnit + 1, ElementSize, ElementSize);
                    }
                }
            }
        }
        /// <summary>
        /// This method draw players on the field and players name and resuld right from the field
        /// </summary>
        /// <param name="g"></param>
        private void DrawPlayersOnStartPosition(Graphics g)
        {
            Engine engine = Engine.GetInstance();
            LinkedList<IPlayer> players = engine.Players;

            for (int player = 0; player < players.Count; player++)
            {
                IPlayer currentPlayer = players.ElementAt(player);
                Brush currentPlayerColor = colors[currentPlayer.Color];

                float x = 28 * MovingUnit + 1;
                float y = 4 * MovingUnit + 1 + 35 * player;

                g.FillRectangle(currentPlayerColor, x, y, PlayerSize, PlayerSize);

                //draw player's name and result
                float xStartPointForPrintingName = x + 40;
                PointF playerNamePrintStartPoint = new PointF(xStartPointForPrintingName, y);
                Font playerNameFont = new Font(String.Empty, FontSize);

                g.DrawString(currentPlayer.Name + " : " + currentPlayer.Points, playerNameFont, Brushes.Black, playerNamePrintStartPoint);

                //draw player on the field
                g.FillRectangle(currentPlayerColor, currentPlayer.Location.X, currentPlayer.Location.Y, PlayerSize, PlayerSize);
            }
        }

        /// 
        /// <summary>
        /// Loads colors in hashMap it's a mapper between Hugo.Colors and Brush 
        /// </summary>
        private void LoadColors()
        {
            colors = new Dictionary<Colors, Brush>();
            colors.Add(Colors.Black, Brushes.Black);
            colors.Add(Colors.Blue, Brushes.Blue);
            colors.Add(Colors.Green, Brushes.Green);
            colors.Add(Colors.Orange, Brushes.Orange);
            colors.Add(Colors.Red, Brushes.Red);
            colors.Add(Colors.White, Brushes.White);
        }

        private void NavigationKey(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == StraightButtonChar)
            {
                MoveStraight();
            }
            else if (e.KeyChar == LeftButtonChar)
            {
                MoveLeft();
            }
            else if (e.KeyChar == RigthButtonChar)
            {
                MoveRigth();
            }
            else
            {
                MessageBox.Show("Unvalid key!");
            }
        }
        
        /// <summary>
        /// Move straight this method is almost the same as MoveLeft and MoveRight it needs refactoring
        /// </summary>
        private void MoveStraight()
        {
            IPlayer currentPlayer = Engine.GetInstance().Players.First.Value;
            Coord currLocationOfCurrPlayer = currentPlayer.Location;
            currLocationOfCurrPlayer.Y = currLocationOfCurrPlayer.Y - MovingUnit;
            currentPlayer.Location = currLocationOfCurrPlayer;
            currentPlayer.Path.AddLast(currLocationOfCurrPlayer);
            DrawNewStep(currentPlayer.Color, currLocationOfCurrPlayer.X, currLocationOfCurrPlayer.Y);
            Engine.GetInstance().ChangeTurn();
        }
        
        private void MoveLeft()
        {
            IPlayer currentPlayer = Engine.GetInstance().Players.First.Value;
            Coord currLocationOfCurrPlayer = currentPlayer.Location;
            currLocationOfCurrPlayer.X = currLocationOfCurrPlayer.X - MovingUnit;
            currentPlayer.Location = currLocationOfCurrPlayer;
            currentPlayer.Path.AddLast(currLocationOfCurrPlayer);
            DrawNewStep(currentPlayer.Color, currLocationOfCurrPlayer.X, currLocationOfCurrPlayer.Y);
            Engine.GetInstance().ChangeTurn();
        }

        private void MoveRigth()
        {
            IPlayer currentPlayer = Engine.GetInstance().Players.First.Value;
            Coord currLocationOfCurrPlayer = currentPlayer.Location;
            currLocationOfCurrPlayer.X = currLocationOfCurrPlayer.X + MovingUnit;
            currentPlayer.Location = currLocationOfCurrPlayer;
            currentPlayer.Path.AddLast(currLocationOfCurrPlayer);
            DrawNewStep(currentPlayer.Color, currLocationOfCurrPlayer.X, currLocationOfCurrPlayer.Y);
            Engine.GetInstance().ChangeTurn();
        }

        private void DrawNewStep(Colors color, float x, float y)
        {
            Brush curentColor = colors[color];
            Graphics g = this.CreateGraphics();

            g.FillRectangle(curentColor, x, y, PlayerSize, PlayerSize);
        }

    }
}
