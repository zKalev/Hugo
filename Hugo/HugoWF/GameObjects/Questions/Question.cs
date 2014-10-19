using Hugo.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo.GameObjects.Questions
{
	class Question: GameObject, IQuestion
	{
		private string text;
		private IAnswer correctAnswer;
		private IList<IAnswer> answers;

		public Question(Coord location, string text, IAnswer correctAnswer, IList<IAnswer> answers) : base(location, Color.Yellow, false)
		{
			this.text = text;
			this.correctAnswer = correctAnswer;
			this.answers = answers;
		}

		public IList<IAnswer> Answers
		{
			get { return answers; }
		}

		public IAnswer CorrectAnswer
		{
			get { return correctAnswer; }
		}
		
		public string Text
		{
			get { return text; }
		}

		public bool IsAnswerCorrect(IAnswer answer)
		{
			return this.correctAnswer.Number == answer.Number;
		}
	}
}
