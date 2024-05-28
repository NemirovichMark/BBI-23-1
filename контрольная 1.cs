
//вариант 12 Абраменкова Карина
//1 задача
/*using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    private static int nextId = 1;

    public string Name { get; set; }
    public int EmployeeID { get; }
    public int Age { get; set; }
    public int HireYear { get; set; }
    public double Salary { get; set; }

    public Employee(string name, int age, int hireYear, double salary)
    {
        this.Name = name;
        this.Age = age;
        this.HireYear = hireYear;
        this.Salary = salary;
        this.EmployeeID = nextId++;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Имя: {Name}");
        Console.WriteLine($"Табельный номер: {EmployeeID}");
        Console.WriteLine($"Возраст: {Age}");
        Console.WriteLine($"Год приема на работу: {HireYear}");
        Console.WriteLine($"Зарплата: {Salary}");
    }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee("Абраменкова", 30, 2022, 50000),
            new Employee("Агпова", 35, 2020, 60000),
            new Employee("Таранов", 40, 2021, 70000),
            new Employee("Козлов", 25, 2019, 45000),
            new Employee("Щебаков", 28, 2023, 55000)
        };

        int countEmployeesAfter2020 = employees.Count(e => e.HireYear > 2020);
        Console.WriteLine($"Кол-во сотрудников, устроенных после 2020 года: {countEmployeesAfter2020}");

        var sortedEmployees = employees.OrderBy(e => e.Name).ToList();

        Console.WriteLine("\nОтсортированный список сотрудников:");
        foreach (var emp in sortedEmployees)
        {
            Console.WriteLine("--------------------------------");
            emp.PrintInfo();
        }
    }
}*/
//2 задача

/*using System;
using System.Collections.Generic;
using System.Linq;

interface ICompany
{
    string Name { get; set; }
    List<Employee> Employees { get; set; }
    double CalculateAverageSalary();
    void PrintInfo();
}

class Company : ICompany
{
    public string Name { get; set; }
    public List<Employee> Employees { get; set; }

    public Company(string name, List<Employee> employees)
    {
        Name = name;
        Employees = employees;
    }

    public double CalculateAverageSalary()
    {
        if (Employees.Count == 0)
            return 0;

        return Employees.Average(emp => emp.Salary);
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Компания: {Name}, Средняя зарплата: {CalculateAverageSalary()}");
    }
}

class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }
    public int Age { get; set; }
    public int Experience { get; set; }

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
        List<ICompany> companies = new List<ICompany>
        {
            new Company("ITCompany1", new List<Employee>
            {
                new Employee("John", 5000, 28, 5),
                new Employee("Alice", 4500, 30, 6),
                new Employee("Bob", 4800, 32, 7)
            }),
            new Company("ITCompany2", new List<Employee>
            {
                new Employee("Emily", 5200, 27, 4),
                new Employee("Tom", 5100, 29, 3)
            })
        };

        foreach (var company in companies)
        {
            company.PrintInfo();
        }
    }
}*/