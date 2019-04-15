using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstprogram
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num, rand, num2, val, val2;
            Random ran = new Random();
            num2 = 0;
            Console.WriteLine("Привіт це Гра  -Вгадай число-  ");
            Console.WriteLine("Запиши 2 числа від якого до якого ти будеш відгадувать число");
            Console.Write("\n запиши 1 число: ");
            val = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n запиши 2 число: ");
            val2 = Convert.ToInt32(Console.ReadLine());
            rand = ran.Next(val, val2);




            do
            {
                Console.Write("Ваше число: ");
                num = Convert.ToInt32(Console.ReadLine());
                
                if (num > rand)
                {
                    Console.WriteLine("\nВаше число більше за загадане");
                }
                if (num < rand)
                {
                    Console.WriteLine("\nВаше число менше за загадане");
                }


                num2++;

            } while (num != rand);
            if (num == rand)
            {
                Console.WriteLine("\nТи виграв з рахунком " +  " " + (num2) + " "  + "Це було число" +  " " + rand + " ");
            }




            Console.ReadKey();
        }
    }
}
