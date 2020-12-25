using Lamar;

namespace IoCExample
{
    internal class Program
    {
        private static void Main()
        {
            //var writer = new MessageWriter();
            //var reader = new MessageReader();
            //var app = new App(writer, reader);

            //app.Execute();

            var container = BuildContainer();

            var app = container.GetInstance<IApp>();

            app.Execute();
        }

        private static Container BuildContainer()
        {
            //TODO refactor this into own IoC class
            return new Container(c =>
                c.Scan(s =>
                {
                    s.TheCallingAssembly();
                    s.WithDefaultConventions();
                }));
        }
    }
}