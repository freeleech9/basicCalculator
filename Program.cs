namespace basicCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("first number please");
            string val1 = Console.ReadLine();
            double firstNum = Convert.ToDouble(val1);

            Console.WriteLine("second number please");
            string val2 = Console.ReadLine();
            double secondNum = Convert.ToInt32(val2);

            Console.WriteLine("operator please");
            string operatorSelection = Console.ReadLine();

            Factory factory = new Factory();

            Operations getOperator = factory.GetOperations(operatorSelection);
            double result = getOperator.Operate(ref firstNum, ref secondNum);
            Console.WriteLine(result);
        }


    }
}