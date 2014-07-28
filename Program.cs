using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompactorConfigCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            FileManager fm = new FileManager();
            MetaData md = new MetaData();

            List<string> temp = md.form(fm._bukkit, fm._common, true);

            foreach (string s in temp)
            {
                Console.Write(s);
            }
            fm.write(temp);
            Console.ReadKey();
        }
    }
}
