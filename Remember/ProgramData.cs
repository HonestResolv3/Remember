using Newtonsoft.Json;
using System.Drawing;
using System.Windows.Forms;

namespace Remember
{
    class ProgramData
    {
        public string Name { get; set; }

        public string FileName { get; set; }

        public string Location { get; set;  }

        public string Parameters { get; set; }

        public ulong Size { get; set; }

        [JsonIgnore]
        public Icon Icon { get; set; }

        [JsonConstructor]
        public ProgramData(string name, string fileName, string location, string parameters, ulong size)
        {
            Name = name;
            FileName = fileName;
            Location = location;
            Parameters = parameters;
            Size = size;
            Icon = Icon.ExtractAssociatedIcon(location);
        }

        public ProgramData(ProgramData prog)
        {
            Name = prog.Name;
            FileName = prog.FileName;
            Location = prog.Location;
            Parameters = prog.Parameters;
            Size = prog.Size;
            Icon = Icon.ExtractAssociatedIcon(Location);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
