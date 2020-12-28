using IoCExampleLibrary;

namespace Console
{
    internal class Program
    {
        private static void Main()
        {
            //var writer = new MessageWriter();
            //var reader = new MessageReader();
            //var app = new App(writer, reader);

            //app.Execute();

            var container = Bootstrapper.Bootstrap();

            var app = container.GetInstance<IApp>();

            app.Execute();
        }
    }
}