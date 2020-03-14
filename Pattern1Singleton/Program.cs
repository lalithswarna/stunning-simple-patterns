using System;

namespace Pattern1Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stunning Simple Singleton Class!");

            var printerObj = printer.GetInstance();
            Console.WriteLine(printerObj.GetHashCode());
            var printerObj2 = printer.GetInstance();
            Console.WriteLine(printerObj2.GetHashCode());

            var testObj1 = new nonSingleton();
            var testObj2 = new nonSingleton();
            Console.WriteLine(testObj1.GetHashCode());
            Console.WriteLine(testObj2.GetHashCode());
        }
    }

    class nonSingleton{
        public void testMethod(){

        }
    }

}
