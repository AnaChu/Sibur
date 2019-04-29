using System;

namespace TestSibur
{
    class Program
    {
        static void Main(string[] args)
        {       
            Console.WriteLine("Введите путь к файлу");
            string path = Console.ReadLine();
            if (string.IsNullOrEmpty(path))
                path = "emp.xml";
            Employees employees = new Employees();
            if (employees.LoadFromXml(path))
            {
                Console.WriteLine(employees.ToString());
            }
            else
                Console.WriteLine("Ошибка при чтении файла");
        }
    }
}
