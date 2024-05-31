using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ecx
{
    class appFrame
    {
        public static Frame MainFrame;

        static Cars car1 = new Cars()
        {
            carNumber = "x123xx123rus",
            carType = "Превышение Скорости",
            carCost = "250",
            carStatus = "Оплачен"
        };
        static Cars car2 = new Cars()
        {
            carNumber = "y123yy123rus",
            carType = "Вооруженное нападение на сотрудника при исполнении",
            carCost = "9999",
            carStatus = "Не Оплачен"
        };
        static Cars car3 = new Cars()
        {
            carNumber = "z123zz123rus",
            carType = "Что то там",
            carCost = "10,5",
            carStatus = "Оплачен"
        };
        static Cars car4 = new Cars()
        {
            carNumber = "f123ff123rus",
            carType = "Наезд на инвалида-ветерана труда",
            carCost = "666",
            carStatus = "Не Оплачен"
        };
        static Cars car5 = new Cars()
        {
            carNumber = "g123gg123rus",
            carType = "Принижение Скорости",
            carCost = "123",
            carStatus = "Оплачен"
        };
        public static List<Cars> carsList = new List<Cars>() { car1, car2, car3, car4, car5 };
    }
}
