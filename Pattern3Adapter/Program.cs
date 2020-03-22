using System;

namespace Pattern3Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Client clientObj = new Client();
            clientObj.GetEmpDetailsFromFileOrContentSystem(207979);

            Content couchObj = new Content();
            couchObj.ConnecttoDB("CouchDatabase", 207979);
            couchObj.GetEmployeeDetails(207979);
            
            // Above steps can be simplified as client do not want to know how file Object works or 
            // we dont want to know how and what content is connected
            String results;
            Adapter adp = new Adapter(couchObj);
            adp.GetEmpDetailsFromFileOrContentSystem(207979); // connects to couchdatabase
            results = adp.GetEmpDetailsFromFileOrContentSystem(369); // connects to legacydatabase

            Console.WriteLine(results);
            Console.ReadLine();
        }
    }
}
