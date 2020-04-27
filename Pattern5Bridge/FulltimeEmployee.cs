using System;
namespace Pattern5Bridge{
    public class FullTimeEmployee : IEmployee{
        public void EmployeeType(){
            Console.WriteLine("This is Permanent Employee");
        }
    }
}