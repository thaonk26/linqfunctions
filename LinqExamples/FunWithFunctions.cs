using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    class FunWithFunctions
    {
        public delegate int AverageNumbers(string numbers);
        //public delegate string AddFrequency(string n);
        //public AddFrequency xx;
        public AverageNumbers num;


        public int AddNum(string z)
        {
            List<int> templist = new List<int>();
            int total = 0;

            foreach (var s in z.Split(','))
            {
                int temp;
                if (int.TryParse(s, out temp))
                {
                    templist.Add(temp);
                }
            }
            templist.Sort();
            total = (int)templist.Skip(3).Average();
            return total;
        }
        //public string Frequency(string r)
        //{
        //    int count = 1;
        //    string name = r;

        //    for (int i = 0; i < r.Length; i++)
        //    {
        //        int temp = 0;
        //        for (int z = 0; z < r.Length; z++)
        //        {
        //            if (r[i].ToString().ToUpper() == r[z].ToString().ToUpper())
        //            {
        //                temp++;
        //            }
        //        }
        //        name = name.Insert(i + count, temp.ToString());
        //        count++;
        //    }

        //    return name;
        //}
    }
}
