using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hugo.Exceptions
{
    class UnvalidNameException : Exception
    {
        public UnvalidNameException()
        {
        }

        public UnvalidNameException(string message)
            : base(message)
        {
        }

        public UnvalidNameException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
