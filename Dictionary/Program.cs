using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("Ukraine", "Kiev");
            d.Add("Israel", "Jerusalem");
            d.Add("Russia", "Moscow");
            d.Display();
            d.Remove("Israel");
            d.Display();
            Console.WriteLine(d.Counter);
        }
    }
}
