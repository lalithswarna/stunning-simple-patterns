using System;
namespace Pattern3Adapter{
    public class Content : IContentVendor{
        private string servertype = "";
        public String dataServer {    
            get {
                    return servertype;
                }
                set {
                    servertype = value;
                }
            }
        public string ConnecttoDB(string connString, int empId){
            if(empId > 100000){
                this.servertype = "Couch";
            }
            else{
                
                this.servertype = "legacy";
            }
            return String.Format("Data Fetched From: {0}", connString);
        }

        public string GetEmployeeDetails(int empId){
            return string.Format("Employee Name with id {0} is Lalith", empId);
        }
    }
}