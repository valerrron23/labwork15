using System;
using System.Text;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine(); //введите латинские маленькие буквы
        StringBuilder sb = new StringBuilder(); 
        foreach (char c in s)
            sb.Append(char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)); //программа вычисляет по формуле, заменяя маленькие буквы на большие
        Console.WriteLine(sb.ToString()); //вывод на консоль
        Console.ReadKey(); //программа ожидает нажатия клавиши для завершения работы
    }
}
