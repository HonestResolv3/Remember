using Newtonsoft.Json;
using System.Drawing;

namespace Remember
{
    class ProgramData
    {
        public string Name { get; }

        public string Location { get; }

        public string Parameters { get; }

        public long Size { get; }

        [JsonIgnore]
        public Icon Icon { get; set; }

        public ProgramData(string name, string location, string parameters, long size, Icon icon)
        {
            Name = name;
            Location = location;
            Parameters = parameters;
            Size = size;
            Icon = icon;
        }

        public override string ToString()
        {
            return Name.Substring(0, Name.LastIndexOf("."));
        }
    }
}
