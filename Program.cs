//Дано двовимірний масив розміром 5×5, заповнений випадковими числами з діапазону від –100 до 100.
//Визначити суму елементів масиву, розташованих між мінімальним і максимальним елементами.
using System;

namespace NET_Homework_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] twoarr = new int[5,5];//Створюємо двовимірний масив 5х5
            Random rnd = new Random();
            int max = 0, min = 0, sum = 0, n_max = 0, n_min = 0, n = 0;   

            Console.WriteLine("Двовимірний масив з випадковими числами від -100 до 100:\n");
            for (int i = 0; i < twoarr.GetLength(0); i++)
            {
                for(int j = 0; j < twoarr.GetLength(1); j++)
                {
                    twoarr[i,j] = rnd.Next(-100,100);//Заповнюємо двовимірний масив рандомними числами
                    Console.Write(twoarr[i,j] + " ");//Виводимо двовимірний масив на екран
                }
                Console.WriteLine();
            }
            foreach (int i in twoarr)//Знаходимо максимальний та мінімальний елемент в масиві 
            {
                if(i > max)
                {
                    max = i;
                }else if(i < min)
                {
                    min = i;
                }
            }
            Console.WriteLine("\nМаксимальний елемент в масиві: " + max + "\nМінімальний елемент в масиві: " + min);
            foreach (int i in twoarr) //Знаходимо місце розташування максимального елемента в масиві 
            {
                if (i == max)
                {
                    break;   
                }
                n_max++;
            }
            foreach (int i in twoarr)//Знаходимо місце розташування мінімального елемента в масиві 
            {
                if (i == min)
                {
                    break;
                }
                n_min++;
            }

            foreach (int i in twoarr)//Знаходимо суму елементів, які знаходяться між мінімальним та максимальним елементами
                                     //в масиві включно з ними
            {
                if (n_min == n_max)
                {
                    sum += i;
                    break;
                }
                if (n_min == n)
                {
                    sum += i;
                    n_min++;
                }else if(n_max == n)
                {
                    sum += i;
                    n_max++;
                }
                n++;
            }
            Console.WriteLine("\nСума елементів , які знаходяться між мінімальним та максимальним елементами в масиві включно з ними: " + sum);
            Console.ReadLine();
        }
    }
}
