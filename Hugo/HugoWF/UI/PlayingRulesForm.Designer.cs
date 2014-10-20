namespace Hugo.UI
{
    partial class PlayingRulesForm
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
            this.HowToPlayText = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HowToPlayText
            // 
            this.HowToPlayText.AcceptsTab = true;
            this.HowToPlayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.HowToPlayText.Location = new System.Drawing.Point(1, 23);
            this.HowToPlayText.Multiline = true;
            this.HowToPlayText.Name = "HowToPlayText";
            this.HowToPlayText.ReadOnly = true;
            this.HowToPlayText.Size = new System.Drawing.Size(281, 197);
            this.HowToPlayText.TabIndex = 0;
            this.HowToPlayText.Text = "   This wondow should explains to player how to play.";
            this.HowToPlayText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HowToPlayText.TextChanged += new System.EventHandler(this.HowToPlayText_TextChanged);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(207, 226);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // HowToPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.HowToPlayText);
            this.Name = "HowToPlay";
            this.Text = "HowToPlay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HowToPlayText;
        private System.Windows.Forms.Button BackButton;

    }
}