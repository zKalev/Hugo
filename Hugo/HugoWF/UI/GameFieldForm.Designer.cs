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
			this.PlayerInfo = new System.Windows.Forms.TextBox();
			this.AdditionalInfoPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// AdditionalInfoPanel
			// 
			this.AdditionalInfoPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.AdditionalInfoPanel.Controls.Add(this.PlayerInfo);
			this.AdditionalInfoPanel.Location = new System.Drawing.Point(584, 0);
			this.AdditionalInfoPanel.Name = "AdditionalInfoPanel";
			this.AdditionalInfoPanel.Size = new System.Drawing.Size(342, 587);
			this.AdditionalInfoPanel.TabIndex = 0;
			// 
			// PlayerInfo
			// 
			this.PlayerInfo.Enabled = false;
			this.PlayerInfo.Location = new System.Drawing.Point(32, 23);
			this.PlayerInfo.Name = "PlayerInfo";
			this.PlayerInfo.ReadOnly = true;
			this.PlayerInfo.Size = new System.Drawing.Size(286, 20);
			this.PlayerInfo.TabIndex = 0;
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
		private System.Windows.Forms.TextBox PlayerInfo;

    }
}