namespace HugoWF
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
			this.StartGame = new System.Windows.Forms.Button();
			this.CreateNewCharacter = new System.Windows.Forms.Button();
			this.HowToPlay = new System.Windows.Forms.Button();
			this.About = new System.Windows.Forms.Button();
			this.ExitGame = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// StartGame
			// 
			this.StartGame.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.StartGame.BackColor = System.Drawing.Color.Silver;
			this.StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
			this.StartGame.ForeColor = System.Drawing.Color.OrangeRed;
			this.StartGame.Location = new System.Drawing.Point(464, 201);
			this.StartGame.Name = "StartGame";
			this.StartGame.Size = new System.Drawing.Size(294, 43);
			this.StartGame.TabIndex = 0;
			this.StartGame.Text = "Start";
			this.StartGame.UseCompatibleTextRendering = true;
			this.StartGame.UseVisualStyleBackColor = false;
			this.StartGame.Click += new System.EventHandler(this.Start_Click);
			// 
			// CreateNewCharacter
			// 
			this.CreateNewCharacter.BackColor = System.Drawing.Color.Silver;
			this.CreateNewCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
			this.CreateNewCharacter.ForeColor = System.Drawing.Color.OrangeRed;
			this.CreateNewCharacter.Location = new System.Drawing.Point(464, 250);
			this.CreateNewCharacter.Name = "CreateNewCharacter";
			this.CreateNewCharacter.Size = new System.Drawing.Size(294, 43);
			this.CreateNewCharacter.TabIndex = 1;
			this.CreateNewCharacter.Text = "Create Character";
			this.CreateNewCharacter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.CreateNewCharacter.UseVisualStyleBackColor = false;
			this.CreateNewCharacter.Click += new System.EventHandler(this.Create_Click);
			// 
			// HowToPlay
			// 
			this.HowToPlay.BackColor = System.Drawing.Color.Silver;
			this.HowToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
			this.HowToPlay.ForeColor = System.Drawing.Color.OrangeRed;
			this.HowToPlay.Location = new System.Drawing.Point(464, 299);
			this.HowToPlay.Name = "HowToPlay";
			this.HowToPlay.Size = new System.Drawing.Size(294, 43);
			this.HowToPlay.TabIndex = 2;
			this.HowToPlay.Text = "How To Play\r\n";
			this.HowToPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.HowToPlay.UseVisualStyleBackColor = false;
			this.HowToPlay.Click += new System.EventHandler(this.HowToPlay_Click);
			// 
			// About
			// 
			this.About.BackColor = System.Drawing.Color.Silver;
			this.About.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
			this.About.ForeColor = System.Drawing.Color.OrangeRed;
			this.About.Location = new System.Drawing.Point(464, 348);
			this.About.Name = "About";
			this.About.Size = new System.Drawing.Size(294, 43);
			this.About.TabIndex = 3;
			this.About.Text = "About";
			this.About.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.About.UseVisualStyleBackColor = false;
			this.About.Click += new System.EventHandler(this.About_Click);
			// 
			// ExitGame
			// 
			this.ExitGame.BackColor = System.Drawing.Color.Silver;
			this.ExitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
			this.ExitGame.ForeColor = System.Drawing.Color.OrangeRed;
			this.ExitGame.Location = new System.Drawing.Point(464, 397);
			this.ExitGame.Name = "ExitGame";
			this.ExitGame.Size = new System.Drawing.Size(294, 43);
			this.ExitGame.TabIndex = 4;
			this.ExitGame.Text = "Exit Game";
			this.ExitGame.UseVisualStyleBackColor = false;
			this.ExitGame.Click += new System.EventHandler(this.ExitGame_Click);
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(818, 451);
			this.Controls.Add(this.ExitGame);
			this.Controls.Add(this.About);
			this.Controls.Add(this.HowToPlay);
			this.Controls.Add(this.CreateNewCharacter);
			this.Controls.Add(this.StartGame);
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.Color.Lime;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
			this.Name = "MainMenu";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hugo";
			this.TransparencyKey = System.Drawing.Color.Black;
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.Load += new System.EventHandler(this.MainMenu_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Button CreateNewCharacter;
        private System.Windows.Forms.Button HowToPlay;
        private System.Windows.Forms.Button About;
		private System.Windows.Forms.Button ExitGame;


    }
}

