using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo.GameObjects.Questions
{
	class Answer : IAnswer
	{
		private int number;
		private string text;
		public bool IsCorrect { get; set; }

		public Answer(int number, string text, bool isCorrect)
		{
			this.number = number;
			this.text = text;
			this.IsCorrect = isCorrect;
		}
		public string Text
		{
			get { return text; }
		}

		public int Number
		{
			get { return number; }
		}

		public override string ToString()
		{
			return this.Text;
		}

	}
}
