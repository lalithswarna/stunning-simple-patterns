namespace Pattern4Repository{
    class ContactUI {
        IRepository<Contact> repository;

        public ContactUI(IRepository<Contact> repository){
            this.repository = repository;
        }

        public void Add(Contact obj){
            repository.Add(obj);
        }

        
        public void Remove(Contact obj){
            repository.Remove(obj);
        }

        public string GetAll(){
            return repository.GetAll();
        }
    }
}