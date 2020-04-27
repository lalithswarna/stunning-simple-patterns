using System;

namespace Pattern5Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Department dept1 = new IT(new FullTimeEmployee());
            dept1.AssignEmployee();

            Department dept2 = new HR(new PartTimeEmployee());
            dept2.AssignEmployee();
            
            Console.WriteLine("Hello World!");
        }
    }
}
