using System;

namespace Pattern2Factory
{
    class Program
    {
      public static void Main(string[] args)
        {
             Console.Write("Enter Number 1 : ");
             var s1 = Console.ReadLine();
            Console.Write("Enter Number 2 : ");
             var s2 = Console.ReadLine();
            Console.Write("Enter Number 3 : ");
             var s3 = Console.ReadLine();

            Calculate(s1, s2, s3);
            Console.ReadLine();
        }

        public static void Calculate(string s1, string s2, string s3)
        {
            double number1, number2, number3;
             bool result;
            result = Double.TryParse(s1, out number1);
            result = Double.TryParse(s2, out number2);
            result = Double.TryParse(s3, out number3);
            CalculateFactory factory = new CalculateFactory();
            Console.WriteLine("Enter operation add, multiply or divide: ");
            ICalculate obj = factory.getCalculationFactory(Console.ReadLine());
            obj.getResult(number1, number2, number3);
        }
    }
}