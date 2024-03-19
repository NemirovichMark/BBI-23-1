//������� 2

using System;

class Program
{
    static int EmployeesCountafter2020 = 0;  // ��� ���������� ���� (static) ��� �������� ���� ����������� ���� ��������, ������� ��������� ����� 2020 ����


    struct Employee  //�������� ���������, ���������� ���������� � ����������
    {
        private static int nextID = 1; // ��� ��������� ���������� ������ �����������


        private string Name;
         private int ID;
        private int Age;
         private int Year;
         private double Salary;


        public Employee(string name, int age, int year, double salary)  //�������� �������� ��� ���� �����, ����� ���������� ������
        {
            Name = name;
              ID = nextID++;
            Age = age;
             Year = year;
            Salary = salary;

            //��������, ���� ��� ������ �� ������ ���������� ������ 2020, �� ��� ��������� ����������� ���������� �����������, �������� ����� 2020 ����, �� 1

            if (Year > 2020) 
            {
                EmployeesCountafter2020++;
            }
        }
        //������ ����� ��� ����������� ���������� � ���������� �� ���� ������
           public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, ID: {ID}, Age: {Age}, Year: {Year}, Salary: {Salary}");
        }

        //������ ���������� ����������� ����� ��� ���������� ������� ����������� �� �������
        private static void SortByLastName(Employee[] employees)
        {
            Employee temp;
            for (int i = 0; i < employees.Length - 1; i++)
            {
                for (int j = i + 1; j < employees.Length; j++)
                {
                    if (employees[i].Name.Split(' ')[1].CompareTo(employees[j].Name.Split(' ')[1]) > 0)
                    {
                        temp = employees[i];
                        employees[i] = employees[j];
                        employees[j] = temp;
                    }
                }
            }
        }

        //����� ��� ����������, ��������� ���������� � ���� ���� �����������
        public static void SortDisplayEmployees(Employee[] employees)
        {
            SortByLastName(employees);

            Console.WriteLine("���������� � ���� �����������:");
            foreach (Employee emp in employees)
            {
                emp.DisplayInfo();
            }
        }
    }

     static void Main()   //�������� ������ �� 5 ����������� (�� ������� ������) 
    {
        Employee[] employees = new Employee[5];

         employees[0] = new Employee("������� �����", 30, 2022, 73000.0);
        employees[1] = new Employee("����� �������", 35, 2020, 64000.0);
        employees[2] = new Employee("������ ��������", 25, 2019, 46000.0);
         employees[3] = new Employee("������ ���������", 28, 2021, 54000.0);
        employees[4] = new Employee("���� �����", 32, 2018, 80000.0);

        Employee.SortDisplayEmployees(employees); //������� ����� ��� ���������� ����������� �� ������� � ������ ���������� � ���

        Console.WriteLine($"���������� �����������, ���������� ����� 2020 ����: {EmployeesCountafter2020}"); //������ ���-�� �����������, ���������� ����� 2020 ����
    }
}


// ������� ������� �� ������ �������(( �� ������� �������...