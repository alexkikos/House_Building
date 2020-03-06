using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingParts
{
    /// <summary>
    /// для команды не использую интерфейс, тк это массив уже готовых посути рабочих, которые подчиняются бригадиру
    /// </summary>
    public class Team
    {
        Worker[] all_workers;       

        public Team(int total_workers)
        {           
            all_workers = new Worker[total_workers];
            for (int i = 0; i < total_workers; i++)
            {
                all_workers[i] = new Worker("worker" + (i + 1).ToString(), false);
            }
        }

        /// <summary>
        /// сет закрытый тк массив статика
        /// </summary>
        public Worker[] All_workers { get => all_workers; }


        public void ShowInfo()
        {
            Console.WriteLine("Count of workers: " + all_workers.Count());      
        }
    }
}
