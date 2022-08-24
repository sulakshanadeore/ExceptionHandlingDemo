using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class Class2
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[2];

            for (int i = 0; i < 2; i++)
            {
              
                Console.WriteLine("Enter rollno");
                int rollno=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter name");
                string name = Console.ReadLine();
                students[i].AcceptData(rollno, name);


            }

            for (int i = 0; i < 2; i++)
            {
                students[i].Display();
            }
            Console.Read();
        }
    }



    struct Student
    {
        int _rollno;
        string _name;

       public void AcceptData(int rollno, string name)
        {
            this._rollno = rollno;
            this._name = name;
        
        }
        public void Display()
        {
            Console.WriteLine(_rollno);
            Console.WriteLine(_name);
        
        }
    }
}
