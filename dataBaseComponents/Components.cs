using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace dataBaseComponents
{
    public class Components
    {
            public string name { get; set; }
            public string nominal { get; set; }
            public string impedance { get; set; }
    }
    public class Add_Component
    {
        Components co = new Components();
        
        
    }

}
