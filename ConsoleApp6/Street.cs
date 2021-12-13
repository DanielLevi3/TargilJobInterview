using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
   public class Street
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public int ShowOrder { get; set; }
        public int CityCode { get; set; }

        public Street(string name,int cityCode,int code)
        {
            Code = code;
            Name = name;
            ShowOrder = code;
            CityCode = cityCode;
        }
        public override string ToString()
        {
            return $"{Newtonsoft.Json.JsonConvert.SerializeObject(this)}";
        }
    }
}
