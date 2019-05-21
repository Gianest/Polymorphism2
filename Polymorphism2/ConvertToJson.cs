using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2
{
    class ConvertToJson : IConvertObject
    {
        public void Convert(Mahasiswa mhs)
        {
            string json = JsonConvert.SerializeObject(mhs);
            Console.WriteLine(json);
        }
    }
}
