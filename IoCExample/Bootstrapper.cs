using Lamar;

namespace Console
{
    public class Bootstrapper
    {
        public static Container Bootstrap()
        {
            //this is for default and "nothing special"
            return new Container(c =>
                c.Scan(s =>
                {
                    s.TheCallingAssembly();
                    s.WithDefaultConventions();
                    s.AssembliesFromApplicationBaseDirectory();
                }));
        }
        
        //TODO need overloaded Bootstrap method that accepts a dependency registry argument to add additional functionality to the above
    }
}