using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables and then initialize to zero.
            int num1 = 0; int num2 = 0;

            // Display title as the C# console calculator app.
            Console.WriteLine("Denta-Kun\r");
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            // Ask the user to type the first number.
            Console.WriteLine("ナンバーを入力せよ、そしてエンターを押せ。");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to type the second number.
            Console.WriteLine("さらにナンバーを入力せよ、エンターも押せ。");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to choose an option.
            Console.WriteLine("これだけあれば十分だと思われる4種を用意した。");
            Console.WriteLine("\tt - たす");
            Console.WriteLine("\th - ひく");
            Console.WriteLine("\tk - かける");
            Console.WriteLine("\tw - わる");
            Console.Write("ご希望の計算方法を選択しなさい。そしてエンターを押せ。");

            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "t":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "h":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "k":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "w":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            // Wait for the user to respond before closing.
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}