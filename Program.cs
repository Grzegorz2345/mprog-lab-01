using System;

namespace mprog_lab_01
{
    class Program
    {
        public static void wypisz_pierwsze(int x){
            for(int i=3;i<=x;i++){
                for(int j=2;j<=x/2;j++){
                    if(i%j==0)
                    break;
                    else if(j==x/2)
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            wypisz_pierwsze(10);
        }
    }
}
