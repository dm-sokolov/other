using System;

namespace TestDelegate
{
    public class MovingEventArgs : EventArgs
    {
        public MovingEventArgs(string message)
        {
            Message = message;
        }

        public string Message { get; private set; }
    }
}