using IzotovVE_01_03.Models;


string name = "Игорь";
int Salary = 1500;
int Coefficient = 1;

Workers workers = new Workers(name, Salary, Coefficient);

workers.NameWorker = name;
workers.BaseSalary = Salary;
workers.Coefficient = Coefficient;

workers.ShowWorker();




