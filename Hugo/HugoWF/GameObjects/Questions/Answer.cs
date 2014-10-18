using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo.GameObjects.Questions
{
	class Answer: IAnswer
	{
		private int number;
		private string text;
		public Answer(int number, string text)
		{
			this.number = number;
			this.text = text;
		}
		public string Text
		{
			get { return text; }
		}

		public int Number
		{
			get { return number; }
		}
		
	}
}
