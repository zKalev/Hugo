using Hugo.GameObjects.Questions;
using Hugo.Helpers;
using Hugo.Properties;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Hugo.Utils
{
	/**
	 * Singleton design pattern - loads the questions file only once and it is used when necessery
	 */
	class QuestionsReader
	{
		private static readonly QuestionsReader instance = new QuestionsReader();

		private static int lastQuestionNumber = -1;

		private List<IQuestion> questions = new List<IQuestion>();

		private QuestionsReader()
		{
			loadQuestions();
		}

		public static QuestionsReader Instance
		{
			get { return instance; }
		}

		public IQuestion getNextQuestion()
		{
			if (lastQuestionNumber >= questions.Count - 1)
			{
				// start from the beginning
				lastQuestionNumber = -1;
			}
			lastQuestionNumber++;

			return questions[lastQuestionNumber];
		}

		private void loadQuestions()
		{
			Excel.Application excelApp = new Excel.Application();

			string filePath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName, "Questions.xlsx");

			Excel.Workbook workbook = excelApp.Workbooks.Open(filePath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

			Worksheet sheet = null;
			if (workbook != null)
			{
				try
				{
					sheet = workbook.Worksheets[1];
					Range excelRange = sheet.UsedRange;
					string questionText = "";
					string answerText = "";
					int answerNumber = 0;
					int correctNumber = 0;
					IList<IAnswer> answers = null;

					Excel.Range last = sheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);

					foreach (Range row in excelRange.Rows)
					{
						int rowNumber = row.Row;
						if (rowNumber > 1 && rowNumber < last.Row)
						{
							int maxColNumber = 7;
							answers = new List<IAnswer>();
							for (int colNumber = 1; colNumber <= maxColNumber; colNumber++)
							{
								Range cell = sheet.Cells[rowNumber, colNumber];
								string value = cell.Value2.ToString();
									switch (colNumber)
									{
										case 1:
											questionText = value;
											break;

										case 2:
											correctNumber = int.Parse(value);
											break;

										default:
											answerNumber = colNumber - 2;
											answerText = value;

											IAnswer answer = new Answer(answerNumber, answerText, correctNumber == answerNumber);
											answers.Add(answer);
											break;
									}
							}
							IQuestion question = new Question(new Coord(), questionText, answers);
							questions.Add(question);
						}
					}
				}
				finally
				{
					if (sheet != null)
					{
						Marshal.ReleaseComObject(sheet);
					}

					if (workbook != null)
					{
						Marshal.ReleaseComObject(workbook);
					}
				}
			}
		}
	}
}
