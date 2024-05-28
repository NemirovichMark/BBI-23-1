//вариант 12 Абраменкова Карина
//1 задача
/*using System;

struct Employee
{
    public string Name;
    public int EmployeeID;
    public int Age;
    public int HiringYear;
    public double Salary;

    public Employee(string name, int employeeID, int age, int hiringYear, double salary)
    {
        Name = name;
        EmployeeID = employeeID;
        Age = age;
        HiringYear = hiringYear;
        Salary = salary;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Имя: {Name}");
        Console.WriteLine($"Табельный номер: {EmployeeID}");
        Console.WriteLine($"Возраст: {Age}");
        Console.WriteLine($"Год приема на работу: {HiringYear}");
        Console.WriteLine($"Зарплата: {Salary}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Employee[] employees = new Employee[5]
        {
            new Employee("Абраменкова", 1, 25, 2019, 50000),
            new Employee("Агапова", 2, 30, 2021, 60000),
            new Employee("Губеева", 3, 28, 2022, 55000),
            new Employee("Воробьев", 4, 35, 2018, 52000),
            new Employee("Таранов", 5, 27, 2020, 53000)
        };

        int employeesHiredAfter2020 = 0;

        for (int i = 0; i < employees.Length - 1; i++)
        {
            for (int j = i + 1; j < employees.Length; j++)
            {
                if (string.Compare(employees[i].Name, employees[j].Name) > 0)
                {
                    Employee temp = employees[i];
                    employees[i] = employees[j];
                    employees[j] = temp;
                }
            }
        }

        foreach (Employee employee in employees)
        {
            employee.PrintInfo();
            if (employee.HiringYear > 2020)
            {
                employeesHiredAfter2020++;
            }
        }

        Console.WriteLine($"Всего сотрудников, принятых после 2020 года: {employeesHiredAfter2020}");
    }
}*/

//2 задача

/*using System;

abstract class Company
{
    protected string Name;
    protected Employee[] Employees;

    public Company(string name, Employee[] employees)
    {
        Name = name;
        Employees = employees;
    }

    public abstract double CalculateAverageSalary();
}

class ITCompany : Company
{
    public ITCompany(string name, Employee[] employees) : base(name, employees) { }

    public override double CalculateAverageSalary()
    {
        double totalSalary = 0;
        foreach (Employee employee in Employees)
        {
            totalSalary += employee.Salary;
        }
        return totalSalary / Employees.Length;
    }
}

class IndustrialCompany : Company
{
    public IndustrialCompany(string name, Employee[] employees) : base(name, employees) { }

    public override double CalculateAverageSalary()
    {
        double totalSalary = 0;
        foreach (Employee employee in Employees)
        {
            totalSalary += employee.Salary;
        }
        return totalSalary / Employees.Length;
    }
}

struct Employee
{
    public string Name;
    public double Salary;
    public int Age;
    public int Experience;

    public Employee(string name, double salary, int age, int experience)
    {
        Name = name;
        Salary = salary;
        Age = age;
        Experience = experience;
    }
}

class Program
{
    static void Main()
    {
        Employee[] employeesIT1 = new Employee[]
        {
            new Employee("Абраменкова", 60000, 30, 5),
            new Employee("Агапова", 55000, 28, 3),
            new Employee("Губеева", 62000, 32, 7),
            new Employee("Капелина", 58000, 29, 4),
            new Employee("Смирнов", 65000, 35, 8)
        };

        Employee[] employeesIT2 = new Employee[]
        {
            new Employee("Щербаков", 58000, 31, 6),
            new Employee("Алексеев", 54000, 27, 2),
            new Employee("Петухов", 63000, 33, 8),
            new Employee("Борисов", 59000, 30, 5),
            new Employee("Михайлов", 66000, 36, 9)
        };

        ITCompany itCompany1 = new ITCompany("IT Company 1", employeesIT1);
        ITCompany itCompany2 = new ITCompany("IT Company 2", employeesIT2);

        Console.WriteLine("Average salary in IT Company 1: {0}", itCompany1.CalculateAverageSalary());
        Console.WriteLine("Average salary in IT Company 2: {0}", itCompany2.CalculateAverageSalary());
    }
}*/