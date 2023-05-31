using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    internal class StackIsEmptyException : Exception
    {
        public StackIsEmptyException(string s) : base(s) { } 
    }
}
