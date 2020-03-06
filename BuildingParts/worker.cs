using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingParts
{
    public class Worker : Iworker
    {
        string worker_name;
        bool isWorked;

        public Worker(string worker_name, bool IsWorked)
        {
            this.worker_name = worker_name;       
            this.IsWorked = IsWorked;
        }

        public string Name_Worker { get => worker_name; set => worker_name = value; }
        public bool IsWorked { get => isWorked; set => isWorked = value; }
    

        public void ShowInfo()
        {
            Console.WriteLine("worker name: " + worker_name + " worked now: " + isWorked);
        }
    }
}
