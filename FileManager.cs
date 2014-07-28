using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompactorConfigCreator
{
    class FileManager
    {
        private string[] line;
        public List<string> _bukkit;
        public List<string> bukkit
        {
            get { return _bukkit; }
        }
        public List<string> _common;
        public List<string> common
        {
            get { return _common; }
        }

        public FileManager()
        {
            int counter = 0;
            _bukkit = new List<string>();
            _common = new List<string>();
            read();
            foreach (string s in line)
            {
                string[] splt = s.Split(':');
                foreach (string z in splt)
                {
                    if (counter % 2 == 0){
                        _bukkit.Add(z);
                    }
                    else
                    {
                        _common.Add(z);
                    }
                    counter++;
                }
                    
            }
        }

        public void read()
        {
            line = System.IO.File.ReadAllLines(@"Delcear.buk");
        }

        public void write(List<string> s)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"factory.buk"))
            {
                foreach (string z in s)
                {
                    file.Write(z);
                }

            }
        }
    }
}
