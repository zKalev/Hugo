namespace Hugo.UI
{
	partial class GameFieldForm
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
            this.AdditionalInfoPanel = new System.Windows.Forms.Panel();
            this.AnswerE = new System.Windows.Forms.Button();
            this.AnswerD = new System.Windows.Forms.Button();
            this.AnswerB = new System.Windows.Forms.Button();
            this.AnswerC = new System.Windows.Forms.Button();
            this.AnswerA = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.TextBox();
            this.PlayerPointsLabel = new System.Windows.Forms.TextBox();
            this.PlayerInfo = new System.Windows.Forms.TextBox();
            this.PlayerLabel = new System.Windows.Forms.TextBox();
            this.PlayerPoints = new System.Windows.Forms.TextBox();
            this.PlayerColor = new System.Windows.Forms.TextBox();
            this.AdditionalInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdditionalInfoPanel
            // 
            this.AdditionalInfoPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AdditionalInfoPanel.Controls.Add(this.AnswerE);
            this.AdditionalInfoPanel.Controls.Add(this.AnswerD);
            this.AdditionalInfoPanel.Controls.Add(this.AnswerB);
            this.AdditionalInfoPanel.Controls.Add(this.AnswerC);
            this.AdditionalInfoPanel.Controls.Add(this.AnswerA);
            this.AdditionalInfoPanel.Controls.Add(this.Question);
            this.AdditionalInfoPanel.Controls.Add(this.PlayerPointsLabel);
            this.AdditionalInfoPanel.Controls.Add(this.PlayerInfo);
            this.AdditionalInfoPanel.Controls.Add(this.PlayerLabel);
            this.AdditionalInfoPanel.Controls.Add(this.PlayerPoints);
            this.AdditionalInfoPanel.Controls.Add(this.PlayerColor);
            this.AdditionalInfoPanel.ForeColor = System.Drawing.SystemColors.Window;
            this.AdditionalInfoPanel.Location = new System.Drawing.Point(584, 0);
            this.AdditionalInfoPanel.Name = "AdditionalInfoPanel";
            this.AdditionalInfoPanel.Size = new System.Drawing.Size(368, 587);
            this.AdditionalInfoPanel.TabIndex = 0;
            // 
            // AnswerE
            // 
            this.AnswerE.Enabled = false;
            this.AnswerE.ForeColor = System.Drawing.SystemColors.MenuText;
            this.AnswerE.Location = new System.Drawing.Point(6, 442);
            this.AnswerE.Name = "AnswerE";
            this.AnswerE.Size = new System.Drawing.Size(362, 23);
            this.AnswerE.TabIndex = 10;
            this.AnswerE.UseVisualStyleBackColor = true;
            this.AnswerE.Click += new System.EventHandler(this.AnswerA_Click);
            // 
            // AnswerD
            // 
            this.AnswerD.Enabled = false;
            this.AnswerD.ForeColor = System.Drawing.SystemColors.MenuText;
            this.AnswerD.Location = new System.Drawing.Point(3, 413);
            this.AnswerD.Name = "AnswerD";
            this.AnswerD.Size = new System.Drawing.Size(362, 23);
            this.AnswerD.TabIndex = 9;
            this.AnswerD.UseVisualStyleBackColor = true;
            this.AnswerD.Click += new System.EventHandler(this.AnswerA_Click);
            // 
            // AnswerB
            // 
            this.AnswerB.Enabled = false;
            this.AnswerB.ForeColor = System.Drawing.SystemColors.MenuText;
            this.AnswerB.Location = new System.Drawing.Point(3, 355);
            this.AnswerB.Name = "AnswerB";
            this.AnswerB.Size = new System.Drawing.Size(362, 23);
            this.AnswerB.TabIndex = 8;
            this.AnswerB.UseVisualStyleBackColor = true;
            this.AnswerB.Click += new System.EventHandler(this.AnswerA_Click);
            // 
            // AnswerC
            // 
            this.AnswerC.Enabled = false;
            this.AnswerC.ForeColor = System.Drawing.SystemColors.MenuText;
            this.AnswerC.Location = new System.Drawing.Point(3, 384);
            this.AnswerC.Name = "AnswerC";
            this.AnswerC.Size = new System.Drawing.Size(362, 23);
            this.AnswerC.TabIndex = 7;
            this.AnswerC.UseVisualStyleBackColor = true;
            this.AnswerC.Click += new System.EventHandler(this.AnswerA_Click);
            // 
            // AnswerA
            // 
            this.AnswerA.CausesValidation = false;
            this.AnswerA.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.AnswerA.Enabled = false;
            this.AnswerA.ForeColor = System.Drawing.SystemColors.MenuText;
            this.AnswerA.Location = new System.Drawing.Point(3, 330);
            this.AnswerA.Name = "AnswerA";
            this.AnswerA.Size = new System.Drawing.Size(362, 23);
            this.AnswerA.TabIndex = 6;
            this.AnswerA.TabStop = false;
            this.AnswerA.UseVisualStyleBackColor = true;
            this.AnswerA.Click += new System.EventHandler(this.AnswerA_Click);
            // 
            // Question
            // 
            this.Question.Enabled = false;
            this.Question.Location = new System.Drawing.Point(3, 283);
            this.Question.Multiline = true;
            this.Question.Name = "Question";
            this.Question.ReadOnly = true;
            this.Question.Size = new System.Drawing.Size(365, 40);
            this.Question.TabIndex = 5;
            // 
            // PlayerPointsLabel
            // 
            this.PlayerPointsLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PlayerPointsLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayerPointsLabel.Enabled = false;
            this.PlayerPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerPointsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlayerPointsLabel.Location = new System.Drawing.Point(31, 126);
            this.PlayerPointsLabel.Name = "PlayerPointsLabel";
            this.PlayerPointsLabel.ReadOnly = true;
            this.PlayerPointsLabel.Size = new System.Drawing.Size(286, 25);
            this.PlayerPointsLabel.TabIndex = 4;
            this.PlayerPointsLabel.Text = "Player hitpoints:";
            // 
            // PlayerInfo
            // 
            this.PlayerInfo.Enabled = false;
            this.PlayerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.PlayerInfo.Location = new System.Drawing.Point(31, 50);
            this.PlayerInfo.Name = "PlayerInfo";
            this.PlayerInfo.ReadOnly = true;
            this.PlayerInfo.Size = new System.Drawing.Size(286, 32);
            this.PlayerInfo.TabIndex = 3;
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PlayerLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayerLabel.Enabled = false;
            this.PlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlayerLabel.Location = new System.Drawing.Point(31, 12);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.ReadOnly = true;
            this.PlayerLabel.Size = new System.Drawing.Size(286, 25);
            this.PlayerLabel.TabIndex = 2;
            this.PlayerLabel.Text = "Current player:";
            // 
            // PlayerPoints
            // 
            this.PlayerPoints.Enabled = false;
            this.PlayerPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerPoints.ForeColor = System.Drawing.SystemColors.Window;
            this.PlayerPoints.Location = new System.Drawing.Point(31, 157);
            this.PlayerPoints.Name = "PlayerPoints";
            this.PlayerPoints.ReadOnly = true;
            this.PlayerPoints.Size = new System.Drawing.Size(286, 32);
            this.PlayerPoints.TabIndex = 1;
            // 
            // PlayerColor
            // 
            this.PlayerColor.Enabled = false;
            this.PlayerColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerColor.ForeColor = System.Drawing.SystemColors.Window;
            this.PlayerColor.Location = new System.Drawing.Point(31, 88);
            this.PlayerColor.Name = "PlayerColor";
            this.PlayerColor.ReadOnly = true;
            this.PlayerColor.Size = new System.Drawing.Size(286, 32);
            this.PlayerColor.TabIndex = 0;
            // 
            // GameFieldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(973, 583);
            this.Controls.Add(this.AdditionalInfoPanel);
            this.Name = "GameFieldForm";
            this.Text = "GameField";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NavigationKey);
            this.AdditionalInfoPanel.ResumeLayout(false);
            this.AdditionalInfoPanel.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel AdditionalInfoPanel;
		private System.Windows.Forms.TextBox PlayerColor;
		private System.Windows.Forms.TextBox PlayerPoints;
		private System.Windows.Forms.TextBox PlayerLabel;
		private System.Windows.Forms.TextBox PlayerInfo;
		private System.Windows.Forms.TextBox PlayerPointsLabel;

        private System.Windows.Forms.TextBox Question;
        private System.Windows.Forms.Button AnswerA;
        private System.Windows.Forms.Button AnswerC;
        private System.Windows.Forms.Button AnswerD;
        private System.Windows.Forms.Button AnswerB;
        private System.Windows.Forms.Button AnswerE;

	}
}