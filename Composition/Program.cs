using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbmagrated = new DbMigrator(new Logger());
            dbmagrated.Migrate();
            /*  ou
            var install = new Installer(new Logger());
            install.Install(); */

            var logger = new Logger();
            var insta = new Installer(logger);
            insta.Install();
            System.Console.ReadKey();
            

        }
    }
}
