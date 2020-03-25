using System.IO;
namespace Pattern4Repository{
    public class TextFileCacheRepo : IRepository<Address>
    {
        string path = @"C:\temp\TextFileRepo.txt";
        public void Add(Address obj){
            if(!File.Exists(path)){
                using (StreamWriter sw = File.CreateText(path)){
                    sw.WriteLine(obj);
                }
            }
            else{
                using (StreamWriter sw = File.AppendText(path)){
                    sw.WriteLine(obj);
                }
            }
        }

        public void Remove(Address obj){

        }

      
        public string GetAll(){
           string textResult = "";
            using (StreamReader sr = File.OpenText(path)){
                string s = "";
                while ((s = sr.ReadLine()) != null){
                    textResult += s;
                }
            }
           return textResult;
        }
    }
}