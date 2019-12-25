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
            Console.WriteLine("ナンバーを入力せよ、そしてエンターを押せ。");
            num1 = Convert.ToInt32(Console.ReadLine());



            // ここで記号をいれて計算させたい。
            /*
             *num3 = Convert.ToInt32(Console.ReadLine());
             */



            // 2番目の数字
            Console.WriteLine("さらにナンバーを入力せよ、エンターも押せ。");
            num2 = Convert.ToInt32(Console.ReadLine());

            /*
             if num3 が「+」のときは
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                       「-」のとき
                       「*」のとき
                       「/」のとき
            */

            // たすのかひくのかそれとも、わるのか
            Console.WriteLine("\tt - たす");
            Console.WriteLine("\th - ひく");
            Console.WriteLine("\tk - かける");
            Console.WriteLine("\tw - わる");
            Console.Write("ご希望の計算方法を選択しなさい。そしてエンターを押せ。");





            // 入力したキーによる分岐
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
            // 何か押せばおわる
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}