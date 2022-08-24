using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void DivideNumbers(int i,int j)
        {
            try//inner try
            {
                Console.WriteLine("Came to Divide Numbers method....");
                int k = i / j;
                Console.WriteLine(k);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Stack Trace=" + ex.StackTrace);
                Console.WriteLine("------");
                ex.Source = "Exception Handling Demo";
                Console.WriteLine("Source=  " + ex.Source);
                Console.WriteLine("-------");
                Console.WriteLine("Message" + ex.Message);
            }
            catch (FormatException ex)
            {

                Console.WriteLine("Format exception by inner try");
            }
            finally
            {

                Console.WriteLine("Inner finally also fired... ");
            }



        }


        static void Main(string[] args)
        {
            int i,j;
            try//outer try
            {
                Console.WriteLine("enter value for i");
                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter value for j");
                j = Convert.ToInt32(Console.ReadLine());
                 DivideNumbers(i, j);
                //try//inner try
                //{
                  
                //    int k = i / j;
                //    Console.WriteLine(k);
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine("In the inner try");
                //    Console.WriteLine("Stack Trace=" + ex.StackTrace);
                //    Console.WriteLine("------");
                //    ex.Source = "Exception Handling Demo";
                //    Console.WriteLine("Source=  " + ex.Source);
                //    Console.WriteLine("-------");
                //    Console.WriteLine("Message" + ex.Message);
                //}



            }
            catch (FormatException ex)
            {
                Console.WriteLine("This is format exception");
                Console.WriteLine("Stack Trace=" + ex.StackTrace);
                Console.WriteLine("------");
                ex.Source = "Exception Handling Demo";
                Console.WriteLine("Source=  " +ex.Source);
                Console.WriteLine("-------");
                Console.WriteLine("Message" + ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Over flow fired");
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("IT comes here from inner try for specific");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some other exception fired");
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("Finally fired....");
            
            }
            
            Console.Read();
        }
    }
}
