using System;
public class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Ім'я: {Name}, Зарплата: {Salary:C}");
    }
}
public class Manager : Employee
{
    public int TeamSize { get; set; }
    public Manager(string name, decimal salary, int teamSize) : base(name, salary)
    {
        TeamSize = teamSize;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Роль: Менеджер, Розмір команди: {TeamSize}");
    }
}
public class Engineer : Employee
{
    public string Specialization { get; set; }
    public Engineer(string name, decimal salary, string specialization) : base(name, salary)
    {
        Specialization = specialization;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Роль: Інженер, Спеціалізація: {Specialization}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("\nВведіть дані для Базового співробітника:");
        Console.Write("Ім'я: ");
        string empName = Console.ReadLine();
        Console.Write("Зарплата: ");
        decimal empSalary;
        while (!decimal.TryParse(Console.ReadLine(), out empSalary))
        {
            Console.Write("Некоректний формат зарплати. Введіть числове значення: ");
        }
        Employee emp = new Employee(empName, empSalary);
        Console.WriteLine("\nВведіть дані для Менеджера:");
        Console.Write("Ім'я: ");
        string mgrName = Console.ReadLine();
        Console.Write("Зарплата: ");
        decimal mgrSalary;
        while (!decimal.TryParse(Console.ReadLine(), out mgrSalary))
        {
            Console.Write("Некоректний формат зарплати. Введіть числове значення: ");
        }
        Console.Write("Розмір команди: ");
        int teamSize;
        while (!int.TryParse(Console.ReadLine(), out teamSize))
        {
            Console.Write("Некоректний формат розміру команди. Введіть ціле число: ");
        }
        Manager mgr = new Manager(mgrName, mgrSalary, teamSize);
        Console.WriteLine("\nВведіть дані для Інженера:");
        Console.Write("Ім'я: ");
        string engName = Console.ReadLine();
        Console.Write("Зарплата: ");
        decimal engSalary;
        while (!decimal.TryParse(Console.ReadLine(), out engSalary))
        {
            Console.Write("Некоректний формат зарплати. Введіть числове значення: ");
        }
        Console.Write("Спеціалізація: ");
        string specialization = Console.ReadLine();
        Engineer eng = new Engineer(engName, engSalary, specialization);
        Console.WriteLine("\n--- Введена інформація про співробітників ---");
        emp.DisplayInfo();
        Console.WriteLine("-----");
        mgr.DisplayInfo();
        Console.WriteLine("-----");
        eng.DisplayInfo();
        Console.WriteLine("-----");
    }
}