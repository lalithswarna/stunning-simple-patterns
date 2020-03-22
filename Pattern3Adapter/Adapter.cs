// Match Interfaces of Different classes
// Choose the pattern when 
// 1. A class need to be reused which does not have an interface
// 2. Create separate adapter that adapts interface of an existing class
// 3. Clients needn't know about the actual classes that are in execution
// Eg: AC Adapter, phone adapter


namespace Pattern3Adapter{

    public class Adapter :  IClient {
        
        IContentVendor vendorSystem;
        public Adapter(IContentVendor obj) {
            this.vendorSystem = obj;
        }
        

        private string servertype = "";
        public string dataServer {    
            get {
                    return servertype;
                }
                set {
                    servertype = value;
                }
            }
    
       public string GetEmpDetailsFromFileOrContentSystem(int id){
            vendorSystem.ConnecttoDB(this.servertype, id);
            string details = vendorSystem.GetEmployeeDetails(id);
            return details;
        }
        
    }
}