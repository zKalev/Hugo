﻿namespace Hugo.UI
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
			this.PlayerColor = new System.Windows.Forms.TextBox();
			this.PlayerPoints = new System.Windows.Forms.TextBox();
			this.PlayerLabel = new System.Windows.Forms.TextBox();
			this.PlayerInfo = new System.Windows.Forms.TextBox();
			this.AdditionalInfoPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// AdditionalInfoPanel
			// 
			this.AdditionalInfoPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.AdditionalInfoPanel.Controls.Add(this.PlayerInfo);
			this.AdditionalInfoPanel.Controls.Add(this.PlayerLabel);
			this.AdditionalInfoPanel.Controls.Add(this.PlayerPoints);
			this.AdditionalInfoPanel.Controls.Add(this.PlayerColor);
			this.AdditionalInfoPanel.Location = new System.Drawing.Point(584, 0);
			this.AdditionalInfoPanel.Name = "AdditionalInfoPanel";
			this.AdditionalInfoPanel.Size = new System.Drawing.Size(342, 587);
			this.AdditionalInfoPanel.TabIndex = 0;
			// 
			// PlayerColor
			// 
			this.PlayerColor.Enabled = false;
			this.PlayerColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PlayerColor.ForeColor = System.Drawing.SystemColors.Window;
			this.PlayerColor.Location = new System.Drawing.Point(26, 114);
			this.PlayerColor.Name = "PlayerColor";
			this.PlayerColor.ReadOnly = true;
			this.PlayerColor.Size = new System.Drawing.Size(286, 32);
			this.PlayerColor.TabIndex = 0;
			this.PlayerColor.TextChanged += new System.EventHandler(this.PlayerColor_TextChanged);
			// 
			// PlayerPoints
			// 
			this.PlayerPoints.Enabled = false;
			this.PlayerPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PlayerPoints.ForeColor = System.Drawing.SystemColors.Window;
			this.PlayerPoints.Location = new System.Drawing.Point(26, 152);
			this.PlayerPoints.Name = "PlayerPoints";
			this.PlayerPoints.ReadOnly = true;
			this.PlayerPoints.Size = new System.Drawing.Size(286, 32);
			this.PlayerPoints.TabIndex = 1;
			this.PlayerPoints.TextChanged += new System.EventHandler(this.PlayerPoints_TextChanged);
			// 
			// PlayerLabel
			// 
			this.PlayerLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.PlayerLabel.Enabled = false;
			this.PlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PlayerLabel.ForeColor = System.Drawing.SystemColors.Window;
			this.PlayerLabel.Location = new System.Drawing.Point(26, 38);
			this.PlayerLabel.Name = "PlayerLabel";
			this.PlayerLabel.ReadOnly = true;
			this.PlayerLabel.Size = new System.Drawing.Size(286, 32);
			this.PlayerLabel.TabIndex = 2;
			this.PlayerLabel.Text = "Next player:";
			this.PlayerLabel.TextChanged += new System.EventHandler(this.PlayerLabel_TextChanged);
			// 
			// PlayerInfo
			// 
			this.PlayerInfo.Enabled = false;
			this.PlayerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PlayerInfo.ForeColor = System.Drawing.SystemColors.Window;
			this.PlayerInfo.Location = new System.Drawing.Point(26, 76);
			this.PlayerInfo.Name = "PlayerInfo";
			this.PlayerInfo.ReadOnly = true;
			this.PlayerInfo.Size = new System.Drawing.Size(286, 32);
			this.PlayerInfo.TabIndex = 3;
			// 
			// GameFieldForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(924, 583);
			this.Controls.Add(this.AdditionalInfoPanel);
			this.Name = "GameFieldForm";
			this.Text = "GameField";
			this.Load += new System.EventHandler(this.GameFieldForm_Load);
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

    }
}