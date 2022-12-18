using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCalculator
{
    internal class Factory
    {

        public Operations GetOperations(String CalcOperator)
        {
            if (CalcOperator == null) throw new ArgumentNullException();

            var operations = new Dictionary<string, Operations>
            {
                { "+", new Addition() },
                { "-", new Substraction() },
                { "*", new Multiplication() },
                { "/", new Division() }
            };

            return operations[CalcOperator];
        }
    }
}
