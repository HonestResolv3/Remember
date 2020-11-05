using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remember
{
    class BackupData
    {
        public string Name { get; set;}

        public string Location { get; set; }

        public BackupData(string name, string location)
        {
            Name = name;
            Location = location;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
