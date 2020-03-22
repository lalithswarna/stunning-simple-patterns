namespace Pattern3Adapter{
    public interface IContentVendor {
        string dataServer { get; set;}
        string ConnecttoDB(string fileType, int empId);
        string GetEmployeeDetails(int empId);
    }
}