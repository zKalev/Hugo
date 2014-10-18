namespace Hugo.UI
{

    partial class CreateCharacterForm
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
                this.components.Dispose();
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
			this.saveCharacterButton = new System.Windows.Forms.Button();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.characterName = new System.Windows.Forms.Label();
			this.genderGroupBox = new System.Windows.Forms.GroupBox();
			this.femaleRadioButton = new System.Windows.Forms.RadioButton();
			this.maleRadioButton = new System.Windows.Forms.RadioButton();
			this.lableTitleCreateCharacter = new System.Windows.Forms.Label();
			this.BackButton = new System.Windows.Forms.Button();
			this.ColorLabel = new System.Windows.Forms.Label();
			this.DialogPickColor = new System.Windows.Forms.ColorDialog();
			this.ButtonPickColor = new System.Windows.Forms.Button();
			this.InputPreviewColor = new System.Windows.Forms.TextBox();
			this.genderGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// saveCharacterButton
			// 
			this.saveCharacterButton.Location = new System.Drawing.Point(48, 211);
			this.saveCharacterButton.Name = "saveCharacterButton";
			this.saveCharacterButton.Size = new System.Drawing.Size(195, 29);
			this.saveCharacterButton.TabIndex = 1;
			this.saveCharacterButton.Text = "Save";
			this.saveCharacterButton.UseVisualStyleBackColor = true;
			this.saveCharacterButton.Click += new System.EventHandler(this.SaveCharacterButton_Click);
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(100, 74);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(143, 20);
			this.nameTextBox.TabIndex = 0;
			// 
			// characterName
			// 
			this.characterName.AutoSize = true;
			this.characterName.Location = new System.Drawing.Point(51, 77);
			this.characterName.Name = "characterName";
			this.characterName.Size = new System.Drawing.Size(35, 13);
			this.characterName.TabIndex = 2;
			this.characterName.Text = "Name";
			// 
			// genderGroupBox
			// 
			this.genderGroupBox.Controls.Add(this.femaleRadioButton);
			this.genderGroupBox.Controls.Add(this.maleRadioButton);
			this.genderGroupBox.Location = new System.Drawing.Point(48, 110);
			this.genderGroupBox.Name = "genderGroupBox";
			this.genderGroupBox.Size = new System.Drawing.Size(195, 60);
			this.genderGroupBox.TabIndex = 3;
			this.genderGroupBox.TabStop = false;
			this.genderGroupBox.Text = "Gender";
			// 
			// femaleRadioButton
			// 
			this.femaleRadioButton.AutoSize = true;
			this.femaleRadioButton.Location = new System.Drawing.Point(104, 19);
			this.femaleRadioButton.Name = "femaleRadioButton";
			this.femaleRadioButton.Size = new System.Drawing.Size(59, 17);
			this.femaleRadioButton.TabIndex = 1;
			this.femaleRadioButton.TabStop = true;
			this.femaleRadioButton.Text = "Female";
			this.femaleRadioButton.UseVisualStyleBackColor = true;
			// 
			// maleRadioButton
			// 
			this.maleRadioButton.AutoSize = true;
			this.maleRadioButton.Checked = true;
			this.maleRadioButton.Location = new System.Drawing.Point(6, 19);
			this.maleRadioButton.Name = "maleRadioButton";
			this.maleRadioButton.Size = new System.Drawing.Size(48, 17);
			this.maleRadioButton.TabIndex = 0;
			this.maleRadioButton.TabStop = true;
			this.maleRadioButton.Text = "Male";
			this.maleRadioButton.UseVisualStyleBackColor = true;
			// 
			// lableTitleCreateCharacter
			// 
			this.lableTitleCreateCharacter.AutoSize = true;
			this.lableTitleCreateCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lableTitleCreateCharacter.Location = new System.Drawing.Point(45, 38);
			this.lableTitleCreateCharacter.Name = "lableTitleCreateCharacter";
			this.lableTitleCreateCharacter.Size = new System.Drawing.Size(143, 16);
			this.lableTitleCreateCharacter.TabIndex = 4;
			this.lableTitleCreateCharacter.Text = "Create Your Character:";
			this.lableTitleCreateCharacter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// BackButton
			// 
			this.BackButton.Location = new System.Drawing.Point(48, 246);
			this.BackButton.Name = "BackButton";
			this.BackButton.Size = new System.Drawing.Size(195, 29);
			this.BackButton.TabIndex = 5;
			this.BackButton.Text = "Back";
			this.BackButton.UseVisualStyleBackColor = true;
			this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
			// 
			// ColorLabel
			// 
			this.ColorLabel.AutoSize = true;
			this.ColorLabel.Location = new System.Drawing.Point(51, 187);
			this.ColorLabel.Name = "ColorLabel";
			this.ColorLabel.Size = new System.Drawing.Size(31, 13);
			this.ColorLabel.TabIndex = 7;
			this.ColorLabel.Text = "Color";
			// 
			// ButtonPickColor
			// 
			this.ButtonPickColor.Location = new System.Drawing.Point(152, 182);
			this.ButtonPickColor.Name = "ButtonPickColor";
			this.ButtonPickColor.Size = new System.Drawing.Size(91, 23);
			this.ButtonPickColor.TabIndex = 8;
			this.ButtonPickColor.Text = "Choose";
			this.ButtonPickColor.UseVisualStyleBackColor = true;
			this.ButtonPickColor.Click += new System.EventHandler(this.ButtonPickColor_Click);
			// 
			// InputPreviewColor
			// 
			this.InputPreviewColor.Location = new System.Drawing.Point(100, 183);
			this.InputPreviewColor.Name = "InputPreviewColor";
			this.InputPreviewColor.ReadOnly = true;
			this.InputPreviewColor.Size = new System.Drawing.Size(43, 20);
			this.InputPreviewColor.TabIndex = 9;
			this.InputPreviewColor.TextChanged += new System.EventHandler(this.InputPreviewColor_TextChanged);
			this.InputPreviewColor.BackColor = Hugo.Utils.ColorUtil.GenerateRandomColor();
			// 
			// CreateCharacterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 287);
			this.Controls.Add(this.InputPreviewColor);
			this.Controls.Add(this.ButtonPickColor);
			this.Controls.Add(this.ColorLabel);
			this.Controls.Add(this.BackButton);
			this.Controls.Add(this.lableTitleCreateCharacter);
			this.Controls.Add(this.genderGroupBox);
			this.Controls.Add(this.characterName);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.saveCharacterButton);
			this.Name = "CreateCharacterForm";
			this.Text = "CreateCharacter";
			this.Load += new System.EventHandler(this.CreateCharacterForm_Load);
			this.genderGroupBox.ResumeLayout(false);
			this.genderGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveCharacterButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label characterName;
        private System.Windows.Forms.GroupBox genderGroupBox;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.Label lableTitleCreateCharacter;
		private System.Windows.Forms.Button BackButton;
		private System.Windows.Forms.Label ColorLabel;
		private System.Windows.Forms.ColorDialog DialogPickColor;
		private System.Windows.Forms.Button ButtonPickColor;
		private System.Windows.Forms.TextBox InputPreviewColor;
    }

}