//Вариант 2

using System;

class Program
{
    static int EmployeesCountafter2020 = 0;  // это уникальное поле (static) для подсчета всех сотрудников моей компании, которые устроенны после 2020 года


    struct Employee  //объявляю структуру, содержащую информацию о сотруднике
    {
        private static int nextID = 1; // это установка табельного номера сотрудникам


        private string Name;
         private int ID;
        private int Age;
         private int Year;
         private double Salary;


        public Employee(string name, int age, int year, double salary)  //принимаю значения для всех полей, кроме табельного номера
        {
            Name = name;
              ID = nextID++;
            Age = age;
             Year = year;
            Salary = salary;

            //проверяю, если год приема на работу сотрудника больше 2020, то моя программа увеличивает количество сотрудников, принятых после 2020 года, на 1

            if (Year > 2020) 
            {
                EmployeesCountafter2020++;
            }
        }
        //создаю метод для отображения информации о сотруднике на моем экране
           public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, ID: {ID}, Age: {Age}, Year: {Year}, Salary: {Salary}");
        }

        //создаю внутренний статический метод для сортировки массива сотрудников по фамилии
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

        //метод для сортировки, ображения информации о всех моих сотрудниках
        public static void SortDisplayEmployees(Employee[] employees)
        {
            SortByLastName(employees);

            Console.WriteLine("Информация о моих сотрудниках:");
            foreach (Employee emp in employees)
            {
                emp.DisplayInfo();
            }
        }
    }

     static void Main()   //созданаю массив из 5 сотрудников (по условию задачи) 
    {
        Employee[] employees = new Employee[5];

         employees[0] = new Employee("Татьяна Навка", 30, 2022, 73000.0);
        employees[1] = new Employee("Софья Чайкина", 35, 2020, 64000.0);
        employees[2] = new Employee("Матвей Щербаков", 25, 2019, 46000.0);
         employees[3] = new Employee("Карина Чиченкова", 28, 2021, 54000.0);
        employees[4] = new Employee("Артём Шилов", 32, 2018, 80000.0);

        Employee.SortDisplayEmployees(employees); //вызываю метод для сортировки сотрудников по фамилии и вывода информации о них

        Console.WriteLine($"Количество сотрудников, устроенных после 2020 года: {EmployeesCountafter2020}"); //вывожу кол-во сотрудников, устроенных после 2020 года
    }
}


// второое задание не успела сделать(( не хватило времени...