﻿namespace Hugo.UI
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
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.genderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveCharacterButton
            // 
            this.saveCharacterButton.Location = new System.Drawing.Point(48, 211);
            this.saveCharacterButton.Name = "saveCharacterButton";
            this.saveCharacterButton.Size = new System.Drawing.Size(195, 29);
            this.saveCharacterButton.TabIndex = 0;
            this.saveCharacterButton.Text = "Save";
            this.saveCharacterButton.UseVisualStyleBackColor = true;
            this.saveCharacterButton.Click += new System.EventHandler(this.SaveCharacterButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(100, 74);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(143, 20);
            this.nameTextBox.TabIndex = 1;
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
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Items.AddRange(new object[] {
            "Green",
            "Blue",
            "Orange",
            "Black",
            "White",
            "Red"});
            this.ColorComboBox.Location = new System.Drawing.Point(100, 184);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(143, 21);
            this.ColorComboBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Color";
            // 
            // CreateCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 287);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.lableTitleCreateCharacter);
            this.Controls.Add(this.genderGroupBox);
            this.Controls.Add(this.characterName);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.saveCharacterButton);
            this.Name = "CreateCharacter";
            this.Text = "CreateCharacter";
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
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.Label label1;
    }
}