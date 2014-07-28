using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompactorConfigCreator
{
    class MetaData
    {
        private string[] meta = {
                                "  Nether_", "raft_", "COMMON", ":\n",
                                "    name: Craft Crate of ", "COMMON", "\n",
                                "    inputs: ", "\n",
                                "         material: ", "BUKKITID", "\n",
                                "         amount: 2048\n",
                                "    outputs: ", "\n",
                                "       Crate of ", "COMMON", ":\n",
                                "         material: WOOD\n",
                                "         durability: 0\n",
                                "         amount: 32\n",
                                "         display_name: Crate of ", "COMMON", "\n",
                                "         lore: Crate of ", "COMMON", "\n"
                                 };

        public List<string> form(string bukkit, string common, bool flag)
        {
            List<string> write = new List<string>();

            foreach(string m in meta){
                if (m.Equals("BUKKITID"))
                    write.Add(bukkit);
                else if (m.Equals("COMMON"))
                    write.Add("COMMON");
                else if (flag)
                    if (m.Equals("raft_"))
                        write.Add("C" + m);
                else if (!flag)
                {
                    if (m.Equals("raft_"))
                        write.Add("Dec" + m);
                    else if (m.Equals("    inputs: "))
                        write.Add("    outputs: ");
                    else if (m.Equals("    outputs: "))
                        write.Add("    inputs: ");
                }
                else
                    write.Add(m);
            }

            return write;
        }
        public List<string> form(List<string> _bukkit, List<string> _common, bool flag)
        {
            List<string> write = new List<string>();
            for (int i = 0; i < _bukkit.Count();i++ )
            {
                string bukkit = _bukkit[i];
                string common = char.ToUpper(_common[i][0]) + _common[i].Substring(1);
                foreach (string m in meta)
                {
                    if (m.Equals("BUKKITID"))
                        write.Add(bukkit);
                    else if (m.Equals("COMMON"))
                        write.Add(common);
                    else if (flag)
                        if (m.Equals("raft_"))
                            write.Add("C" + m);
                        else if (!flag)
                        {
                            if (m.Equals("raft_"))
                                write.Add("Dec" + m);
                            else if (m.Equals("    inputs: "))
                                write.Add("    outputs: ");
                            else if (m.Equals("    outputs: "))
                                write.Add("    inputs: ");
                        }
                        else
                            write.Add(m);
                }
            }

            return write;
        }
    }
}
