﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo.GameObjects.Questions
{
	interface IQuestion
	{
		IList<IAnswer> Answers { get; }

		IAnswer CorrectAnswer { get; }

		string Text { get; }

		bool IsAnswerCorrect(IAnswer answer);

	}
}
