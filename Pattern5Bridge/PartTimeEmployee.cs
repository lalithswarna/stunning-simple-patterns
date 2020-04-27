using System;
namespace Pattern5Bridge{
    public class PartTimeEmployee : IEmployee{
        public void EmployeeType(){
            Console.WriteLine("This is part-time employee.");
        }
    }
}