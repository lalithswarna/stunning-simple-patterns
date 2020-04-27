namespace Pattern5Bridge{
    public abstract class Department{
        protected IEmployee emp;

        public Department(IEmployee employee){
            this.emp = employee;
        }

        abstract public void AssignEmployee();
    }
}