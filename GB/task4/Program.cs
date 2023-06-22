// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

using System;

namespace task2 {

    class Program {

        static void Main() {
        
            Console.Write("Введите первое число: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int third = Convert.ToInt32(Console.ReadLine());

            if(second < first > third) {
                Console.Write("Max size " + first);
            }
                if(first < second > third) {
                    Console.WriteLine("Max size " + second);
                }
                    if(first < third > second) {
                        Console.WriteLine("Max size " + second);
                    }
            else {
                Console.WriteLine("DELETED");
            }
                
        }

    }

}
error CS0019: Оператор ">" невозможно применить к операнду типа "bool" и "int". 