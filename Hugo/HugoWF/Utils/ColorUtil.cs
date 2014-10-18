using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo.Utils
{
	class ColorUtil
	{
		public static Color GenerateRandomColor()
		{
			Random randomNumber = new Random();
			int r = randomNumber.Next(0, 256);
			int g = randomNumber.Next(0, 256);
			int b = randomNumber.Next(0, 256);
			Color color = Color.FromArgb(r, g, b);

			return color;
		}
	}
}
