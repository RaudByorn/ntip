using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Numerics;

namespace View
{
    public class dataBase
    {
        public dataBase()
        {
            
        }
        public string Serialize(object json)
        {
            const Formatting indentend = Formatting.Indented;
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            var newjson = JsonConvert.SerializeObject(json,indentend,settings);
            return newjson;
        }
        public void savefile(string savefilename,string jsonfile)
        {
            File.WriteAllText(savefilename, jsonfile);
        }

        public List<IComponent.IComponent> Deserialize(string filename)
        {
            Console.WriteLine(filename);
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            var file = File.ReadAllLines(filename);
            var fin_file = new string[1];
            foreach (var fileStrings in file)
            {
                fin_file[0] += string.Join(null, fileStrings);
            }
            var json = JsonConvert.DeserializeObject<List<IComponent.IComponent>>(fin_file[0], settings);
            return json;
        }
    }
}