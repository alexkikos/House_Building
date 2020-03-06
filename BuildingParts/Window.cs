using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingParts
{
    public class Window:Ipart
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
        public Window(int total_count, float time_for_build_one_item)
        {
            this.name_part = "Window";
            this.finished = false;
            count = total_count;
            time_for_build = time_for_build_one_item;
        }

        public string CurrentNamePart { get => name_part; set => name_part = value; }
        public bool Finished { get => finished; set => finished = value; }

        public void DrawPart()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.SetCursorPosition(40 + i, 11);//-3
                Console.Write("-");
                Console.SetCursorPosition(40 + i, 13);
                Console.Write("-");

                Console.SetCursorPosition(58 + i, 11);
                Console.Write("-");
                Console.SetCursorPosition(58 + i, 13);
                Console.Write("-");


                Console.SetCursorPosition(40 + i, 17);
                Console.Write("-");
                Console.SetCursorPosition(40 + i, 19);
                Console.Write("-");

                Console.SetCursorPosition(58 + i, 17);
                Console.Write("-");
                Console.SetCursorPosition(58 + i, 19);
                Console.Write("-");


            }
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(39, 11 + i);
                Console.Write("|");
                Console.SetCursorPosition(42, 11 + i);
                Console.Write("|");

                Console.SetCursorPosition(57, 11 + i);
                Console.Write("|");
                Console.SetCursorPosition(60, 11 + i);
                Console.Write("|");

                Console.SetCursorPosition(39, 17 + i);
                Console.Write("|");
                Console.SetCursorPosition(42, 17 + i);
                Console.Write("|");

                Console.SetCursorPosition(57, 17 + i);
                Console.Write("|");
                Console.SetCursorPosition(60, 17 + i);
                Console.Write("|");
            }
        }

        public void StartWork()
        {
            Console.WriteLine("start work at: " + name_part);
        }

  

    }
}
