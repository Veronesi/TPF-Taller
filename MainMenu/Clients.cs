using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenu
{
    class Clients
    {
        //  "id": 12345678, "pass": 1234, "response": { "client": { "name": "Juan Amador", "segment": "VIP" } } } ]
        public String id { get; set; }
        public String pass { get; set; }
        public Client response { get; set; }
    }
}
