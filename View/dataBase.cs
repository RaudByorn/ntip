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
        /// <summary>
        /// Сериализация данных
        /// </summary>
        /// <param name="json"></param>
        /// <returns>string</returns>
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
        /// <summary>
        /// Сохранить файл
        /// </summary>
        /// <param name="savefilename"></param>
        /// <param name="jsonfile"></param>
        public void savefile(string savefilename,string jsonfile)
        {
            File.WriteAllText(savefilename+".json", jsonfile);
        }
        /// <summary>
        /// Десериализация данных 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns>string</returns>
        public Tuple<List<IComponent.IComponent>, string> Deserialize(string filename)
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
            var json = JsonConvert.DeserializeObject<Tuple<List<IComponent.IComponent>, string>>(fin_file[0], settings);
            return json;
        }
    }
}