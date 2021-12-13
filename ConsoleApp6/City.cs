using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class City
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public int ShowOrder { get; set; }

        public City(string name,int code)
        {
            Code = code;
            Name = name;
            ShowOrder = code;
        }

        public override string ToString()
        {
            return $"{Newtonsoft.Json.JsonConvert.SerializeObject(this)}";
        }
    }
}
