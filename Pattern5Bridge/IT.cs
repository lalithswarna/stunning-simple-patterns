using System;

namespace Pattern5Bridge
{
    public class IT : Department{

        public IEmployee ITEmployee;
        public IT(IEmployee employee) : base(employee){
            this.ITEmployee = employee;
        }

       public override void AssignEmployee(){
           Console.WriteLine("IT employee Assigned");
           ITEmployee.EmployeeType();
       } 
    }
    
}