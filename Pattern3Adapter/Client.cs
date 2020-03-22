namespace Pattern3Adapter{
    public class Client : IClient {
        public string GetEmpDetailsFromFileOrContentSystem(int id){
            return "From Client: Employee name is Anu";
        }
    }
}