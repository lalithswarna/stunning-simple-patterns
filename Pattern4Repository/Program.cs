using System;

namespace Pattern4Repository
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Repository Pattern !!!");
            var inMemRepo = new MemoryCacheRepo();
            var fileRepo = new TextFileCacheRepo();

            ContactUI contactsInMem = new ContactUI(inMemRepo);
            contactsInMem.Add(new Contact("Bingi", "Uppal"));
            contactsInMem.Add(new Contact("Dabba", "Huda"));
            contactsInMem.Add(new Contact("Lalit", "BHEL"));


            string res = contactsInMem.GetAll();
            Console.WriteLine(res);
            Console.WriteLine("Enter to close...");
            Console.ReadLine();
        }
    }
}
