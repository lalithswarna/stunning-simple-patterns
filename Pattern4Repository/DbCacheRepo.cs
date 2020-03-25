namespace Pattern4Repository{
    public class DbCacheRepo : IRepository<Contact>
    {
        public void Add(Contact i){

        }

        public void Remove(Contact i){

        }

        public string GetAll(){
           return "List from Database :"; 
        }
    }
}