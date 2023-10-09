﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
               // Console.Clear();
                //Думаю лучшим решением будет хранить все переменные в цикле
                //когда все переменные вычислятся нам нужно просто вычислить сумму элементов массива
                //размер массива
               
                Console.WriteLine("Введите колличество элементов посследовательности: ");
                //Считываем число элементов посследовательности которое нам нужно просуммировать
                n = int.Parse(Console.ReadLine());
                if (n >= 0)
                {
                    //Выделяем память под массив (на два больше чтобы обработать случаи 0 и 1)
                    double[] massX = new double[n + 3];
                    //Конечная сумма 
                    double sum = 0;

                    //Инициализация первых элементов массива
                    massX[0] = 0;
                    massX[1] = 0;
                    massX[2] = 0.625;


                    //Вычисление значений n элементов

                    for (int i = 3; i <= n; i++)
                    {
                        massX[i] = (massX[i - 1] / 2.0) + (0.75 * massX[i - 2]);  //0.75 это 3/4 если что:)
                    }


                    //теперь само суммирование:

                    for (int i = 0; i <= n; i++)
                    {
                        sum += massX[i];
                    }

                    //Вывод:
                    Console.WriteLine("Сумма первых {0} членов последовательности равна: {1}", n, sum);

                }
                else
                {
                    Console.WriteLine("Число элементов должно быть положительным!");
                }
               

            } while (n>=0);
            //Чтобы программа не вылетала ожидаем нажатие клавиши
            Console.ReadKey();

            /*
             * В целом код решает задачу, но его можно модернизировать например не хранить все элементы а просто хранить результат суммирования:)
             */ 
        }
    }
}
