using IoCExampleLibrary;

namespace Console
{
    internal class Program
    {
        private static void Main()
        {
            var container = Bootstrapper.Bootstrap();

            var app = container.GetInstance<IApp>();

            app.Execute();
        }
    }
}