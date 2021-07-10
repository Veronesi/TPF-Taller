using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenu
{
    class OperationRegister
    {
        public void setDni(string pDni)
        { 
            DateTime localDate = DateTime.Now;
            Console.WriteLine($"SET_DNI: '{pDni}' at: {localDate.ToString()}");
        }

        public void setPin(string pDni)
        {
            DateTime localDate = DateTime.Now;
            Console.WriteLine($"SET_PIN: '{pDni}' at: {localDate.ToString()}");
        }
    }
}
