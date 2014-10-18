namespace Hugo.UI
{
	using Hugo.Engine;
	using System;
	using System.Windows.Forms;
	using System.Media;

	public partial class MainMenuForm : Form
	{
		private SoundPlayer soundPlayer;

		public MainMenuForm()
		{
			soundPlayer = new SoundPlayer("barebear.wav");
			soundPlayer.Play();
			InitializeComponent();
		}

		private void MainMenu_Load(object sender, EventArgs e)
		{
		}

		private void Start_Click(object sender, EventArgs e)
		{
			soundPlayer.Stop();

			Engine engine = Engine.GetInstance();

			engine.StartGame();

			engine.Run();
		}

		private void Create_Click(object sender, EventArgs e)
		{
			if (Engine.GetInstance().Players.Count == 8)
			{
				MessageBox.Show("The maximum number of players is 8! You could not create another player!");
			}
			else
			{
				CreateCharacterForm cch = new CreateCharacterForm();
				cch.Show();
			}
		}

		private void HowToPlay_Click(object sender, EventArgs e)
		{
			PlayingRulesForm htp = new PlayingRulesForm();
			htp.Show();
		}

		private void About_Click(object sender, EventArgs e)
		{
			AboutForm about = new AboutForm();
			about.Show();
		}

		private void ExitGame_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
