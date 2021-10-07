using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise2 sum1 = new Exercise2(5,"David","C");
            
            Console.WriteLine(sum1.x);
            Console.WriteLine(sum1.z);
            Console.WriteLine(sum1.multiplicar(sum1.x));
            Console.WriteLine(sum1.Rating);
            Console.WriteLine("-----");

            Exercise2 sum2 = new Exercise2(5.1, "Diego","ana");
            Console.WriteLine(sum2.y);
            Console.WriteLine(sum2.z);
            Console.WriteLine(sum2.multiplicar(sum2.y));
            Console.WriteLine(sum2.Palindrome);
            Console.WriteLine("-----");


            Exercise2 sum2A = new Exercise2(5.1, "Diego", "reconocer");
            Console.WriteLine(sum2A.y);
            Console.WriteLine(sum2A.z);
            Console.WriteLine(sum2A.Palindrome);
            Console.WriteLine("-----");

            Exercise2 sum3 = new Exercise2("David","Diego");
            Console.WriteLine(sum3.z.ToUpper());
            sum3.digonal_print();


            Console.ReadLine();

        }
    }
}
