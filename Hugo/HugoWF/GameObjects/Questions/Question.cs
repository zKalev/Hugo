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
		private IList<IAnswer> answers;

		public Question(Coord location, string text, IList<IAnswer> answers) : base(location, Color.Yellow, false)
		{
			this.text = text;
			this.answers = answers;
		}

		public IList<IAnswer> Answers
		{
			get { return answers; }
		}
		
		public string Text
		{
			get { return text; }
		}
	}
}
