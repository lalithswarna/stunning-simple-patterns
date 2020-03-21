using System;
namespace Pattern2Factory{
    public class Add : ICalculate{
        public void getResult(double num1, double num2, double num3){
            Console.WriteLine("Sum is : {0} ", num1+num2+num3);
        }
    }
}