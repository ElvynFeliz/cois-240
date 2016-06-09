using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet
{
    class Program
    {
        static void Main(string[] args)
        {
            Planet pluton = new Planet();
            pluton.density = "900";
            pluton.name = "Pluton";
            pluton.gravity = "1g";
            pluton.temperature = "80degrees";


            Planet angelcaco = new Planet();
            angelcaco.density = "1000";
            angelcaco.name = "Angelcaco";
            angelcaco.gravity = "2g";
            angelcaco.temperature = "70degrees";

            Planet lalocaaura = new Planet();
            lalocaaura.density = "10000";
            lalocaaura.name = "Lalocaaura";
            lalocaaura.gravity = "5g";
            lalocaaura.temperature = "100degrees";




        }
    }
}
