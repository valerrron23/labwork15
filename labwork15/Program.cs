using System;
using System.Text;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        foreach (char c in s)
            sb.Append(char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c));
        Console.WriteLine(sb.ToString());
        Console.ReadKey();
    }
}