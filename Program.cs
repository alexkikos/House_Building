using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingParts;


namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            House_Build h = new House_Build("Brigadir", 5);
            h.StartWork();

        }
    }
}
