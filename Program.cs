using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 変数を宣言
            float num1 =0; float num2 = 0; string ope = null;

            // c#によるコンソール計算機
            Console.WriteLine("Denta-Kun\r");
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");


            // 最初の数字
            Console.WriteLine("input number 1");
            num1 = Convert.ToInt32(Console.ReadLine());


            // オペレーションの選択肢を表示
            Console.WriteLine("select operation");
            Console.WriteLine("(+|-|*|/)");
            ope = Console.ReadLine();


            // 2番目の数字
            Console.WriteLine("input number 2");
            num2 = Convert.ToInt32(Console.ReadLine());


            // 入力したキーによる分岐
            switch (ope)
            {
                case "+":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "/":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            // 何か押せばおわる
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}