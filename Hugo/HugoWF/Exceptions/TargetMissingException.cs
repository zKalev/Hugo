using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hugo.Exceptions
{
    class TargetMissingException : Exception
    {
        public TargetMissingException()
            : base("The target game object is missing!") { }
    }
}
