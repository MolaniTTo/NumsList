using System;
using System.Security.Cryptography.X509Certificates;
namespace IntList
{
    public class Program
    {
        public static void Main()
        {

            List<int> list = new List<int>
            {
                1, 2, 3, 4, 5, 6
            };

            int suma = 0;

            foreach (int i in list)
            {
                suma+=i;       
            }

            Console.WriteLine(suma);


           
           




        }
    }
}