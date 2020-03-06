using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingParts
{
    interface Iworker
    {
        string Name_Worker { get; set; }//должность
        bool IsWorked { get; set; }//работают или нет
        void ShowInfo();//вывод инфы

    }
}
