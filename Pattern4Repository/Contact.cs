namespace  Pattern4Repository{
    public class Contact{
        public string Name {get; set;}
        public string Email {get; set;}

        public Contact(string name, string email){
            this.Name = name;
            this.Email = email;
        }
    }
}