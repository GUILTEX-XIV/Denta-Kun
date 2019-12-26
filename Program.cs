using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // たぶんこれが変数を宣言しているとおもわれる
            int num1 = 0; int num2 = 0; int num3 = 0;

            // デンタ君はc#によるコンソール計算機
            Console.WriteLine("Denta-Kun\r");
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            // 最初の数字
            Console.WriteLine("input number 1");
            num1 = Convert.ToInt32(Console.ReadLine());



            // ここで記号をいれて計算させたい。
            Console.WriteLine("select option");
            Console.WriteLine("\t1 - たす");
            Console.WriteLine("\t2 - ひく");
            Console.WriteLine("\t3 - かける");
            Console.WriteLine("\t4 - わる");
            num3 = Convert.ToInt32(Console.ReadLine());



            // 2番目の数字
            Console.WriteLine("input number 2");
            num2 = Convert.ToInt32(Console.ReadLine());


            // 入力したキーによる分岐
            switch (num3)
            {
                case 1:
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case 4:
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            // 何か押せばおわる
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}