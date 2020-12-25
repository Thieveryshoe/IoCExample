using System;

namespace IoCExample
{
    public interface IMessageReader
    {
        void ReadKey();
    }

    public class MessageReader : IMessageReader
    {
        public void ReadKey()
        {
            Console.ReadKey();
        }
    }
}