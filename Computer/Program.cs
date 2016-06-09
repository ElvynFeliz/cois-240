using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    class Program
    {
        static void Main(string[] args)
        {
            Desktop Efeliz = new Desktop(true);
        
            Desktop EFeliz3 = new Desktop(false);
            EFeliz3.model = "EFeliz3";
            EFeliz3.size = "60 pulgada";
            Laptop Efe11 = new Laptop(true);
            Laptop EFeliz11 = new Laptop(false);
            EFeliz11.hasTouchScreen = true;

        }

    }
}
