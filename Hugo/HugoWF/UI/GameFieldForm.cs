namespace Hugo.UI
{
    using Hugo.Engine;
    using Hugo.Helpers;
    using Hugo.GameObjects.Players;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class GameFieldForm : Form
    {

        private const int ElementSize = 50;
        private const int PlayerSize = ElementSize / 2;
        private const int MovingUnit = ElementSize / 2;

        private const int XStartDrawingPoint = 5;
        private const int XEndDrawingPoint = 25;

        private const int YEndDrawingPoint = 23;
        private const int YStartDrawingPoint = 2;

        private const int FontSize = 15;

        private const char UpButtonChar = 'w';
        private const char LeftButtonChar = 'a';
        private const char RigthButtonChar = 'd';
		private const char DownButtonChar = 's';

        private Dictionary<Color, Brush> colors;

        public GameFieldForm()
        {
            //LoadColors();
            InitializeComponent();
			updatePlayerInfo();
        }

     private void LoadColors()
        {
            colors = new Dictionary<Color, Brush>();
            colors.Add(Color.Black, Brushes.Black);
            colors.Add(Color.Blue, Brushes.Blue);
            colors.Add(Color.Green, Brushes.Green);
            colors.Add(Color.Orange, Brushes.Orange);
            colors.Add(Color.Red, Brushes.Red);
            colors.Add(Color.White, Brushes.White);
        }

	 private void NavigationKey(object sender, KeyPressEventArgs e)
        {
			if (e.KeyChar == UpButtonChar)
            {
                MoveUp();
            }
			else if (e.KeyChar == LeftButtonChar)
            {
                MoveLeft();
            }
			else if (e.KeyChar == RigthButtonChar)
            {
                MoveRigth();
			}
			else if (e.KeyChar == DownButtonChar)
			{
				MoveDown();
			}
            else
            {
                MessageBox.Show("Unvalid key!");
            }
        }

        private void MoveUp()
        {
			Engine.GetInstance().MoveCurrentPlayer(0, -1);
			updatePlayerInfo();
        }

        private void MoveLeft()
        {
			Engine.GetInstance().MoveCurrentPlayer(-1, 0);
			updatePlayerInfo();
        }

        private void MoveRigth()
        {
			Engine.GetInstance().MoveCurrentPlayer(1, 0);
			updatePlayerInfo();
        }

		private void MoveDown()
		{
			Engine.GetInstance().MoveCurrentPlayer(0, 1);
			updatePlayerInfo();
		}

		private void GameFieldForm_Load(object sender, System.EventArgs e)
		{

		}

		private void PlayerInfo_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void updatePlayerInfo()
		{
			IPlayer currentPlayer = Engine.GetInstance().GetCurrentPlayer();
			this.PlayerColor.BackColor = currentPlayer.Color;
			this.PlayerPoints.Text = currentPlayer.Points + "";
			this.PlayerInfo.Text = currentPlayer.Name;
		}

		private void PlayerLabel_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void PlayerColor_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void PlayerPoints_TextChanged(object sender, System.EventArgs e)
		{

		}
    }
}
