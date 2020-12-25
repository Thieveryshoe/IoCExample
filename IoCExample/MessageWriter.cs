using System;

namespace IoCExample
{
    public interface IMessageWriter
    {
        void WriteMessage(string message);
    }

    public class MessageWriter : IMessageWriter
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}