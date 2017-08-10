using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    class MyIndexator
    {
        int[] arr;
        public int len;

        public MyIndexator(int size)
        {
            arr = new int[size];
            len = size;
        }
        public int this[int index]
        {
            set
            {
                arr[index] = value * value;
            }

            get
            {
                return arr[index];
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int ind1, ind2;
            while (true)
            {
                Console.WriteLine("Введите начальный элемент индексатора");
                ind1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите конечный элемент индексатора");
                ind2 = Int32.Parse(Console.ReadLine());
                if (ind1 > ind2)
                    Console.WriteLine("Начальный должен быть меньше конечного!");
                else
                    break;
            }

            MyIndexator arr = new MyIndexator(ind2 - ind1 + 1);
            string choice;
            // какое задание такой и говнокод :P

            Console.WriteLine("Заполнить рандомом или самому? (рандом / сам) " +
                "(в любом случае будет квадрат числа, из-за первого задания)");
            choice = Console.ReadLine();
            if (choice == "рандом")
            {
                Random ran = new Random();
                for (int i = 0; i < arr.len; i++)
                    arr[i] = ran.Next(1, 100);
            }
            else
                if (choice == "сам")
            {
                for (int i = ind1; i <= ind2; i++)
                {
                    Console.WriteLine("Введите значение \"{0}\" элемента массива", ind1 + i);
                    arr[i] = Int32.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < arr.len; i++)
            {
                Console.WriteLine("{0} - ый/ой\t{1}", i + ind1, arr[i]);
            }


        }
    }
}
