namespace IzotovVE_01_03Test
{
    public class Tests
    {
        //Поле базового оклада успешного тестирвоания
        private int BaseSalary = 1500;
        //Поле коэфицента успешного тестирования
        public int Coefficient = 1;
        //Поле базового оклада успешного тестирвоания
        public int BaseSalaryBad = -1500;
        //Поле коэфицента успешного тестирования
        public int CoefficientBad = 0;
        //Результат успешного прохождегния базового класса
        int QGood = 151500;
        //Результат безуспешного прохождегния базового класса
        int QBad = -150000;
        //Поле вредности
        int P = 1;
        [SetUp]
        public void Setup ()
        {
        }

        [Test]
        public void Test1 ()
        {
            //Вычисление теста для базового класса
            int Q = BaseSalary * (100 + Coefficient);
            Console.WriteLine(Q);
            Assert.Pass();
        }
        [Test]
        public void Test2 ()
        {
            //Вычисление безуспешного теста для базового класса (результат отрицательный)
            int Q = BaseSalaryBad * (100 + CoefficientBad);
            Console.WriteLine(Q);
            Assert.Pass();
        }
        [Test]
        public void Test3 ()
        {
            //Вычисление успешного теста для дочернего класса
            int Qp = QGood + (QGood / P);
            Assert.Pass();
        }
        [Test]
        public void Test4 ()
        {
            //Вычисление безуспешного теста для дочернего класса (результат отрицательный)
            int Qp = QBad + (QBad / P);
            Assert.Pass();
        }
    }
}