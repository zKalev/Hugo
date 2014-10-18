using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo.GameObjects.Questions
{
	class Answer
	{
		private int number;
		private string text;
		public Answer(int number, string text)
		{
			this.Number = number;
			this.Text = text;
		}
		public string Text
		{
			get { return text; }
			set { text = value; }
		}
		

		public int Number
		{
			get { return number; }
			set { number = value; }
		}
		
	}
}
