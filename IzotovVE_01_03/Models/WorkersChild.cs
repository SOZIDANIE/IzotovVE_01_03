using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzotovVE_01_03.Models
{
    class WorkersChild : Workers //Наследуем базовый класс
    {
        public WorkersChild (string name, int baseSalary, int coefficient) : base(name, baseSalary, coefficient)
        {

        }
        //Поле вредности
        public int P { get; set; }
        //Переопределение Q в Qp
        public int Qp => Q + (Q / P);
    }
}
