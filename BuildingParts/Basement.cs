using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingParts
{
    class Basement : Ipart
    {

        string name_part;
        bool finished;
        int count;
        float time_for_build;



        public float TimeForBild { get => time_for_build; set => time_for_build = value; }
        public int Count { get => count; set => count = value; }

        /// <summary>
        /// basement only 1
        /// </summary>
        /// <param name="time_for_build_one_item">exmp 12h == 12h time for build</param>
        public Basement(float time_for_build_one_item)
        {
            this.name_part = "Basement";
            this.finished = false;
            count = 1;
            time_for_build = time_for_build_one_item;
        }


        public string CurrentNamePart { get => name_part; set => name_part= value; }
        public bool Finished { get => finished; set => finished=value; }


        public void DrawPart()
        {
            Console.SetCursorPosition(35, 25);
            for (int i = 0; i < 30; i++)
            {
                Console.Write("=");
            }
        }

        public void StartWork()
        {        
            Console.WriteLine("start work at: " + name_part);
        }

    }
}
