using System;

namespace IoCExample
{
    public interface IApp
    {
        void Execute();
    }

    public class App : IApp
    {
        private readonly IMessageWriter _messageWriter;
        private readonly IMessageReader _messageReader;

        public App(IMessageWriter messageWriter, IMessageReader messageReader)
        {
            _messageWriter = messageWriter;
            _messageReader = messageReader;
        }

        public void Execute()
        {
            Console.WriteLine("The app has started.");
            _messageWriter.WriteMessage("This line is written by the dependency.");
            Console.WriteLine("The app has ended.");
            _messageReader.ReadKey();
        }
    }
}