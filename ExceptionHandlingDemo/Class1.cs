using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Amt");
            int amt = Convert.ToInt32(Console.ReadLine());
            int[] d = new int[] { 1, 2, 3, 4 };
            int cnt;
            for (int i = 0; i < d.Length; i++)
            {
                if (amt%d[i]==0)
                {
                    cnt = amt / d[i];
                    if (cnt != 0)
                    {
                        Console.WriteLine("{0} with count of{1}", d[i], cnt);
                    }
                }
                else
                {
                    Console.WriteLine("1 problem");
                }
               
            }
            
        
        
            Console.ReadKey();





        }
    }
}
