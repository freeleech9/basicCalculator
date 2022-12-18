using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCalculator
{
    internal class Multiplication : Operations
    {
        public override T Operate<T>(ref T lhs, ref T rhs)
        {           
                dynamic left = lhs;
                dynamic right = rhs;
                return left * right;
            }
        }
    }
