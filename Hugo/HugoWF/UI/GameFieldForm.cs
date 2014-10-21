
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
             QuestionsReader questionReader = QuestionsReader.Instance;
             IQuestion currentQuestion = questionReader.getNextQuestion();

             IList<IAnswer> answers = currentQuestion.Answers;

             this.Question.Text = currentQuestion.Text;
             this.AnswerA.Text = answers[0].Text;
             this.AnswerB.Text = answers[1].Text;
             this.AnswerC.Text = answers[2].Text;
             this.AnswerD.Text = answers[3].Text;
             this.AnswerE.Text = answers[4].Text;

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
             else if (answers[2].IsCorrect)
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
                 Engine.GetInstance().MoveCurrentPlayer(this.x, this.y);
                 updatePlayerInfo();
                 MessageBox.Show("Youuu good you!");

             }
             else
             {
                 Engine.GetInstance().ChangeTurn();
                 updatePlayerInfo();
                 MessageBox.Show("Sorry the correct answer is: " + this.corectAnswer);
             }

             ClearQuestune();
             AnswerA.TabIndex = 0;
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
             this.AnswerE.Text = String.Empty;
             this.Question.Text = String.Empty;

             this.AnswerA.Hide();
             this.AnswerB.Hide();
             this.AnswerC.Hide();
             this.AnswerD.Hide();
             this.AnswerE.Hide();
         }
     }
 }

