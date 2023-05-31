using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    internal class StackIsFullException : Exception
    {
        public StackIsFullException(string? s) : base(s)
        {
            
        }
    }
}
