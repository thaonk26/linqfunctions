using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string moreNumbers = "2,5,9,4,64,876,34,79,95,1";
            string name = "Llewellyn";
            FunWithFunctions haha = new FunWithFunctions();

            haha.num = (string x) => { return haha.AddNum(x); };
            Console.WriteLine(haha.num(moreNumbers));
            var counts = name.ToLower().GroupBy(c => c).Select(g => new { Letter = g.Key, Count = g.Count() });
            
            foreach (var item in counts)
                Console.WriteLine("{0}{1}", item.Letter, item.Count);
            Console.ReadLine();

        }

    }
}
