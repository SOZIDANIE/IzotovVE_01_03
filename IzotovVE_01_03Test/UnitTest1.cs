namespace IzotovVE_01_03Test
{
    public class Tests
    {
        //���� �������� ������ ��������� ������������
        private int BaseSalary = 1500;
        //���� ���������� ��������� ������������
        public int Coefficient = 1;
        //���� �������� ������ ��������� ������������
        public int BaseSalaryBad = -1500;
        //���� ���������� ��������� ������������
        public int CoefficientBad = 0;
        //��������� ��������� ������������ �������� ������
        int QGood = 151500;
        //��������� ������������ ������������ �������� ������
        int QBad = -150000;
        //���� ���������
        int P = 1;
        [SetUp]
        public void Setup ()
        {
        }

        [Test]
        public void Test1 ()
        {
            //���������� ����� ��� �������� ������
            int Q = BaseSalary * (100 + Coefficient);
            Console.WriteLine(Q);
            Assert.Pass();
        }
        [Test]
        public void Test2 ()
        {
            //���������� ������������ ����� ��� �������� ������ (��������� �������������)
            int Q = BaseSalaryBad * (100 + CoefficientBad);
            Console.WriteLine(Q);
            Assert.Pass();
        }
        [Test]
        public void Test3 ()
        {
            //���������� ��������� ����� ��� ��������� ������
            int Qp = QGood + (QGood / P);
            Assert.Pass();
        }
        [Test]
        public void Test4 ()
        {
            //���������� ������������ ����� ��� ��������� ������ (��������� �������������)
            int Qp = QBad + (QBad / P);
            Assert.Pass();
        }
    }
}