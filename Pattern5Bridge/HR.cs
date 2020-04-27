using System;

namespace Pattern5Bridge{
    public class HR : Department{

         public IEmployee HrEmp;
        public HR(IEmployee employee) : base(employee){
            this.HrEmp = employee;
        }

        public override void AssignEmployee(){
            Console.WriteLine("HR employee Assigned");
            emp.EmployeeType();
        }
    }
}