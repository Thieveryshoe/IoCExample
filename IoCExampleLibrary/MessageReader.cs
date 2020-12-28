using System;

namespace IoCExampleLibrary
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