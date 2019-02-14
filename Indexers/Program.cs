using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var httpcokie = new HttpCookie();
            httpcokie["Name"] = "koffi";
            httpcokie["LastName"] = "Kouadio joachim";
            Console.WriteLine(httpcokie["Name"]+ " "+ httpcokie["LastName"]);

            Console.ReadKey();
        }
    }

    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionnary;
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            _dictionnary = new Dictionary<string, string>();
        }
        //indexers  comment declarer un indexer
        public string  this[string key]
        {
            get { return _dictionnary[key]; }
            set { _dictionnary[key] = value; }
        }

}
}
