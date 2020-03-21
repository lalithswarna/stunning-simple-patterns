using System;
namespace Pattern2Factory{
    public class Divide : ICalculate{
        public void getResult(double num1, double num2, double num3){
            Console.WriteLine("Multiplication result is : ", num1*num2*num3);
            Console.WriteLine();
        }
    }
}