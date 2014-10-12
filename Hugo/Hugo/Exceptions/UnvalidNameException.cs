using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo.Exceptions
{
    public class UnvalidNameException : Exception
    {
		public UnvalidNameException()
			: base("The name you have entered is not valid. You should enter a name different than \"\" and \" \"!")
		{
		}
    }
}
