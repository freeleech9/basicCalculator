using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCalculator
{
    internal class Factory {
        Dictionary<string, Operations> operations = new Dictionary<string, Operations>
            {
                { "+", new Addition() },
                { "-", new Substraction() },
                { "*", new Multiplication() },
                { "/", new Division() }
            };
        public Operations GetOperations(String CalcOperator)
        {
            //Console.WriteLine(operations[CalcOperator]);
            return operations[CalcOperator];
        }
    }
}
