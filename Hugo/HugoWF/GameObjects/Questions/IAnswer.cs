﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo.GameObjects.Questions
{
	interface IAnswer
	{
		bool IsCorrect { get; }

		string Text { get; }

		int Number { get; }

	}
}
