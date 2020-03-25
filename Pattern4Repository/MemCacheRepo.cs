using System.Collections.Generic;

namespace Pattern4Repository{
    public class MemoryCacheRepo : IRepository<Contact>
    {
        List<Contact> contactList = new List<Contact>();
        public void Add(Contact i){
            contactList.Add(i);
        }

        public void Remove(Contact i){
            contactList.Remove(i);
        }

      
        public string GetAll(){
            string res = "";
            foreach(var cont in contactList){
                res += "Name: " + cont.Name + "  Address: " + cont.Email + "\n";
            }
           return res;
        }
    }
}