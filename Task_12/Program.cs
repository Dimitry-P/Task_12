using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    internal class Program
    {
        //•	Задача 12: Напишите программу, которая выводит
        //факториал числа, введенного пользователем.
        public static string number;
        public static int result;
        public static int sum=1;
       

        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число больше 0");
            number = Console.ReadLine();
            result = int.Parse(number);
            for (int i = result; i >0; i--)
            {
                sum *= i;
            }
            Console.WriteLine("Факториал равен: "+sum);
        }
    }
}
