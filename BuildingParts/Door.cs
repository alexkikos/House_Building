using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingParts
{
    class Door:Ipart
    {
        string name_part;
        bool finished;
        int count;
        float time_for_build;



        public float TimeForBild { get => time_for_build; set => time_for_build = value; }
        public int Count { get => count; set => count = value; }
        /// <summary>       /// 
        /// 
        /// </summary>
        /// <param name="total_count"> total items</param>
        /// <param name="time_for_build_one_item">time in hours, exmp 12 = 12h</param>
        public Door(int total_count, float time_for_build_one_item)
        {
            this.name_part = "Door";
            this.finished = false;
            count = total_count;
            time_for_build = time_for_build_one_item;
        }

        public string CurrentNamePart { get => name_part; set => name_part = value; }
        public bool Finished { get => finished; set => finished = value; }

        public void DrawPart()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(48 + i, 20);
                Console.Write("-");
                Console.SetCursorPosition(48 + i, 24);
                Console.Write("-");
                Console.SetCursorPosition(47, 20 + i);
                Console.Write("|");
                Console.SetCursorPosition(53, 20 + i);
                Console.Write("|");
            }
            Console.SetCursorPosition(49, 22);
            Console.Write("*");
        }

        public void StartWork()
        {
            Console.WriteLine("start work at: " + name_part);
        }

      
    }
}
