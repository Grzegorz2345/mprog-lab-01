using System;

namespace mprog_lab_01
{
    class Program
    {
        
        static void Main(string[] args)
        {StreamReader sr=null;
            try{
           
           sr= new StreamReader("/home/doc");
           Console.WriteLine(sr.ReadToEnd());
           }
           catch(FileNotFoundException ex){
               Console.WriteLine($"File not found{ex.FileName}")
           }
           catch(Exception ex){
               Console.WriteLine(ex.Message);
               Console.WriteLine(ex.StackTrace);
               
           }
           finally{
               sr?.Close();
           }
           
        }
    }
}
