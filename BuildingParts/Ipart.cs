using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingParts
{ 

    interface Ipart
    {
        /// <summary>
        /// //время постройки еденицы продукции
        /// 1==1ч, 23.30 - почти сутки
        /// </summary>
        float TimeForBild { set; get; }
        /// <summary>
        /// //сколько деталей строится
        /// </summary>
        int Count { set; get; }
        /// <summary>
        /// //название части дома
        /// </summary>
        string CurrentNamePart { set; get; }
        /// <summary>
        /// //готова или нет, для отслеживания текущего состояния, чтобы все рабочие строили один обьект, как по заданию
        /// </summary>
        bool Finished { set; get; }
        void StartWork();//   
        /// <summary>
        /// //отрисовка текущей стадии дома
        /// </summary>
        void DrawPart();
    }
}
