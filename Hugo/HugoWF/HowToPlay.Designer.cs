namespace HugoWF
{
    partial class HowToPlay
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
            this.SuspendLayout();
            // 
            // HowToPlayText
            // 
            this.HowToPlayText.AcceptsTab = true;
            this.HowToPlayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.HowToPlayText.Location = new System.Drawing.Point(0, 43);
            this.HowToPlayText.Multiline = true;
            this.HowToPlayText.Name = "HowToPlayText";
            this.HowToPlayText.ReadOnly = true;
            this.HowToPlayText.Size = new System.Drawing.Size(283, 218);
            this.HowToPlayText.TabIndex = 0;
            this.HowToPlayText.Text = "   This wondow should explains to player how to play.";
            this.HowToPlayText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HowToPlayText.TextChanged += new System.EventHandler(this.HowToPlayText_TextChanged);
            // 
            // HowToPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.HowToPlayText);
            this.Name = "HowToPlay";
            this.Text = "HowToPlay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HowToPlayText;

    }
}