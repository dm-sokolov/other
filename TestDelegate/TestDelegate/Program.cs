using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            //Action<string> method = Show;
            //student.Move(7, method);

            student.Moving += student_Moving;


            student.Move(7);

            //student.Moving = Show;
            //student.Move(7);


        }

        static void student_Moving(object sender, MovingEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

        //static void Show(string message)
        //{
        //    Console.WriteLine(message);
        //}
    }

    /*
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            ShowMessage method = Show;

            student.Move(7, method);
        }

        static void Show(string message)
        {
            Console.WriteLine(message);
        }
    }

    */



}
