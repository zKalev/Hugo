using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo.GameObjects.Questions
{
	class Question
	{
		private string text;
		private Answer correctAnswer;
		private IList<Answer> answers;
		public Question(string text, Answer correctAnswer, IList<Answer> answers)
		{
			this.Text = text;
			this.CorrectAnswer = correctAnswer;
			this.Answers = answers;
		}

		public IList<Answer> Answers
		{
			get { return answers; }
			set { answers = value; }
		}

		public Answer CorrectAnswer
		{
			get { return correctAnswer; }
			set { correctAnswer = value; }
		}
		
		public string Text
		{
			get { return text; }
			set { text = value; }
		}

		public bool IsAnswerCorrect(Answer answer)
		{
			return this.CorrectAnswer.Number == answer.Number;
		}
	}
}
