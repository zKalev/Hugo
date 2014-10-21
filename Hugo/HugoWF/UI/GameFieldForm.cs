
﻿namespace Hugo.UI
{
    using Hugo.Engine;
    using Hugo.Helpers;
    using Hugo.GameObjects.Players;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using Hugo.Utils;
    using Hugo.GameObjects.Questions;
    using System;
    using System.Threading;
    using System.ComponentModel;

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

        
        private string corectAnswer;
        private bool isCurrentAnswerCorrect;

        private QuestionsReader questionReader = QuestionsReader.Instance;
        private int x;
        private int y;
       

        public GameFieldForm()
        {
            InitializeComponent();
            updatePlayerInfo();
            
        }

        private void NavigationKey(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == UpButtonChar)
            {
                StartDrawingQuestionIfMoveIsPossible(0, -1);
                this.x = 0;
                this.y = -1;
            }
            else if (e.KeyChar == LeftButtonChar)
            {
                StartDrawingQuestionIfMoveIsPossible(-1, 0);
                this.x = -1;
                this.y = 0;
            }
            else if (e.KeyChar == RigthButtonChar)
            {
                StartDrawingQuestionIfMoveIsPossible(1, 0);
                this.x = 1;
                this.y = 0;
            }
            else if (e.KeyChar == DownButtonChar)
            {
                StartDrawingQuestionIfMoveIsPossible(0, 1);
                this.x = 0;
                this.y = 1;
            }
            else
            {
                MessageBox.Show("Unvalid key!");
            }
        }

        private void StartDrawingQuestionIfMoveIsPossible(int x, int y)
        {
            bool canMove = Engine.GetInstance().CanMove(x, y);
            if (canMove)
            {
                DrawQuestion();
                EnableQuestionAnswerButton();
            }
        }

        private void EnableQuestionAnswerButton()
        {
            AnswerA.Enabled = true;
            AnswerB.Enabled = true;
            AnswerC.Enabled = true;
            AnswerD.Enabled = true;
            AnswerE.Enabled = true;
            this.AnswerA.Visible = true;
            this.AnswerB.Visible = true;
            this.AnswerC.Visible = true;
            this.AnswerD.Visible = true;
             this.AnswerE.Visible = true;
            this.Question.Visible = true;
        }

        private void DrawQuestion()
        {
            IQuestion currentQuestion = questionReader.getNextQuestion();
            
            this.SetQuestionText(currentQuestion.Text);
            IList<IAnswer> answers = currentQuestion.Answers;
            this.SetAnswerAText(answers[0].Text);
            this.SetAnswerBText(answers[1].Text);
            this.SetAnswerCText(answers[2].Text);

            this.SetAnswerDText(answers[3].Text);
            this.SetAnswerEText(answers[4].Text);
            setCorectAnswer(answers);
        }

        private void setCorectAnswer(IList<IAnswer> answers)
        {

            if (answers[0].IsCorrect)
            {
                this.corectAnswer = answers[0].Text;
            }
            else if (answers[1].IsCorrect)
            {
                this.corectAnswer = answers[0].Text;
            }
            else  if (answers[2].IsCorrect)
            {
                this.corectAnswer = answers[2].Text;
            }
            else if (answers[3].IsCorrect)
            {
                this.corectAnswer = answers[3].Text;
            }
            else if (answers[4].IsCorrect)
            {
                this.corectAnswer = answers[4].Text;
            }
            else 
            {
               throw new ArgumentException("No correct answer in possible answers!");
            }
        }

        private void AnswerA_Click(object sender, System.EventArgs e)
        {
            string rowButtonValue = sender.ToString();
            int startPositionForCorrectAswer = rowButtonValue.IndexOf(":") + 1;
            string currentAnswer = rowButtonValue.Substring(startPositionForCorrectAswer).Trim();
            if (this.corectAnswer.Equals(currentAnswer))
            {
                this.isCurrentAnswerCorrect = true;
            }
            if (isCurrentAnswerCorrect)
            {
                Engine.GetInstance().MoveCurrentPlayer(this.x, this.y);
                updatePlayerInfo();
                MessageBox.Show("Youuu good you!");
            }
            else
            {
                MessageBox.Show("Loser");
            }

            ClearQuestune();
            AnswerA.TabIndex = 0;
            MessageBox.Show("Correct answer: "+this.corectAnswer );
            this.KeyPreview = true;
        }

        private void updatePlayerInfo()
        {
            IPlayer currentPlayer = Engine.GetInstance().GetCurrentPlayer();
            this.PlayerColor.BackColor = currentPlayer.Color;
            this.PlayerPoints.Text = currentPlayer.Points + "";
            this.PlayerInfo.Text = currentPlayer.Name;
        }
        private void ClearQuestune()
        {
            this.AnswerA.Text = String.Empty;
            this.AnswerB.Text = String.Empty;
            this.AnswerC.Text = String.Empty;
            this.AnswerD.Text = String.Empty;
            this.Question.Text = String.Empty;

            this.AnswerA.Visible = false;
            this.AnswerB.Visible = false;
            this.AnswerC.Visible = false;
            this.AnswerD.Visible = false;
            this.AnswerE.Visible = false;
            this.Question.Visible = false;

            this.AnswerA.Enabled = false;
            this.AnswerB.Enabled = false;
            this.AnswerC.Enabled = false;
            this.AnswerD.Enabled = false;
            this.AnswerE.Enabled = false;
        }


        //------------- start methods  to set value in multithreading enviaronment  it may not needed-----

        delegate void SetTextCallback(string text);
        private void SetQuestionText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.Question.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetQuestionText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.Question.Text = text;
            }
        }

        private void SetAnswerAText(string text)
        {
            if (this.AnswerA.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetAnswerAText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.AnswerA.Text = text;
            }
        }
        private void SetAnswerBText(string text)
        {
            if (this.AnswerA.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetAnswerBText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.AnswerB.Text = text;
            }
        }
        private void SetAnswerCText(string text)
        {
            if (this.AnswerA.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetAnswerCText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.AnswerC.Text = text;
            }
        }

        private void SetAnswerDText(string text)
        {
            if (this.AnswerD.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetAnswerDText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.AnswerD.Text = text;
            }
        }
        private void SetAnswerEText(string text)
        {
            if (this.AnswerE.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetAnswerEText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.AnswerE.Text = text;
            }
        }

        //------------- End methods  to set value in multithreading enviaronment-----

        private void GameFieldForm_Load(object sender, System.EventArgs e)
        {

        }

        private void PlayerInfo_TextChanged(object sender, System.EventArgs e)
        {

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

        private void AdditionalInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

