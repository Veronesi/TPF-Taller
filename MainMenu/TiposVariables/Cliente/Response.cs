using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenu
{
    class Response
    {
        //  "id": 12345678, "pass": 1234, "response": { "client": { "name": "Juan Amador", "segment": "VIP" } } } ]
        public Client client { get; set; }
    }
}
