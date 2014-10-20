namespace Hugo.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class InvalidNameException : Exception
    {
        public InvalidNameException()
            : base("The name you have entered is not valid. You should enter a name!")
        {
        }
    }
}
