using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenu
{
    class OperationRegister
    {
        public static void dni(string pDni)
        { 
            DateTime localDate = DateTime.Now;
            Console.WriteLine($"SET_DNI: '{pDni}' at: {localDate.ToString()}");
        }

        public static void pin(string pDni,Boolean success = true)
        {
            DateTime localDate = DateTime.Now;
            if(success)
                Console.WriteLine($"SET_PIN_SUCCESS: '{pDni}' at: {localDate.ToString()}");
            else
                Console.WriteLine($"SET_PIN_ERROR: '{pDni}' at: {localDate.ToString()}");
        }
    }
}
