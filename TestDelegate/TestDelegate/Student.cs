using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestDelegate
{
    public delegate void ShowMessage(string message);
    public class Student
    {
        public void Move(int distance)
        {
            for (int i = 1; i <= distance; i++)
            {
                Thread.Sleep(1000);
                if (Moving != null)
                    Moving(this, new MovingEventArgs(string.Format("Идет перемещение...Пройдено километров: {0}", i)));
                //Moving(string.Format("Идет перемещение...Пройдено километров: {0}", i));
            }

        }

        public event EventHandler<MovingEventArgs> Moving;
        //public Action<string> Moving { get; set; }
    }


    /*
             public void Move(int distance, Action<string> method)
        {
            for (int i = 1; i <= distance; i++)
            {
                Thread.Sleep(1000);
                method(string.Format("Идет перемещение...Пройдено километров: {0}", i));
            }

        }

     */



    /*
    
    public delegate void ShowMessage(string message);
    public class Student
    {
        public void Move(int distance, ShowMessage method)
        {
            for (int i = 1; i <= distance; i++)
            {
                Thread.Sleep(1000);
                method(string.Format("Идет перемещение...Пройдено километров: {0}", i));
            }

        }
    }


     */


}
