using System;

namespace Week3Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString("MMMM dd,yyyy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy.MM.dd"));
            Console.WriteLine($"Day {DateTime.Now:dd} of {DateTime.Now:MMMM,yyyy}");
            Console.WriteLine($"Year:{DateTime.Now:yyyy}, Month:{DateTime.Now:MM} Day:{DateTime.Now:dd}");
            Console.WriteLine($"{DateTime.Now.ToString("dddd"),10}");
            Console.WriteLine($"{DateTime.Now.ToString("hh:mm tt"),-5}{DateTime.Now.ToString("dddd"),10}");
            Console.WriteLine($"h:{DateTime.Now:hh}, m:{DateTime.Now:mm} s:{DateTime.Now:ss}");
            Console.WriteLine($"{DateTime.Now:yyyy}.{DateTime.Now:MM}.{DateTime.Now:dd}.{DateTime.Now:hh}.{DateTime.Now:mm}.{DateTime.Now:ss}");
            Console.WriteLine(String.Format("{0:C2}",Math.PI));
            Console.WriteLine(String.Format("{0:0.000}", Math.PI));

        }
    }
}
