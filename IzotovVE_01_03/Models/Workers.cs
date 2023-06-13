using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzotovVE_01_03.Models
{
    class Workers
    {
        //Конструктор класса
        public Workers (string name, int baseSalary, int coefficient)
        {
            name = NameWorker;
            baseSalary = BaseSalary;
            coefficient = Coefficient;
        }
        //Поле с именем работника
        public string NameWorker { get; set; }
        //Поле базового оклада
        public int BaseSalary { get; set; }
        //Поле коэфицента
        public int Coefficient { get; set; }
        //Вычесление Q
        public int Q => BaseSalary * (100 + Coefficient);
        //вывод информации о работнике
        public void ShowWorker()
        {
            Console.WriteLine( "Информация о сотруднике:\n" + "Имя: " +  NameWorker + "\n"+ "Оклад: " + BaseSalary + "\n" + "Коэфицент: " + Coefficient + "\n" + "Q: " + Q);
        }
    }
}
