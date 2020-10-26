using Newtonsoft.Json;
using System.Drawing;
using System.Windows.Forms;

namespace Remember
{
    class ProgramData
    {
        public string Name { get; set; }

        public string FileName { get; }

        public string Location { get; set;  }

        public string Parameters { get; set;  }

        public long Size { get; set; }

        [JsonIgnore]
        public Icon Icon { get; set; }

        public ProgramData(string name, string fileName, string location, string parameters, long size, Icon icon)
        {
            Name = name;
            FileName = fileName;
            Location = location;
            Parameters = parameters;
            Size = size;
            Icon = icon;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
