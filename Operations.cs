using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCalculator
{
    abstract class Operations
    {
        public abstract T Operate<T>(ref T lhs, ref T rhs);
    }
}
