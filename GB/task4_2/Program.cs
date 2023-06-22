using System;

namespace task2 {

    class Program {

        static void Main() {
        
            Console.Write("Введите первое число: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int third = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            if (first > second) {
                max = first;
            }
                if (second > first) {
                    max = second;
                }
                    if (third > second) {
                        max = third;
                    }
            else {
                Console.WriteLine("DELETE");
            }
            Console.WriteLine(max);
        }

    }

}