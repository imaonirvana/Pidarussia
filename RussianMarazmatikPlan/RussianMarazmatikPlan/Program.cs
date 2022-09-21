using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Вы поддерживаете войну?");
        Console.WriteLine("1. Да\n2. Мне всё равно\n3. Нет");
        Console.WriteLine("Введите цифру: ");
        int value = Convert.ToInt32(Console.ReadLine());
        if (value == 3)
        {
            Console.WriteLine("Вы попали в тюрьму");
            Console.WriteLine("Продолжаем сидеть или ЧВК Вагнер?");
            Console.WriteLine("1. Сидим\n2. ЧВК Вагнер");
            int turma = Convert.ToInt32(Console.ReadLine());
            if (turma == 1)
            {
                Console.WriteLine("Вы попали в армию");
                Console.WriteLine("Плен или дезертирство?");
                Console.WriteLine("1. Да\n2. До конца");
                int armia = Convert.ToInt32(Console.ReadLine());
                if (armia == 1)
                {
                    Console.WriteLine("Смерть в русской тюрьме");
                }
                else
                { 
                    Console.WriteLine("Смерть");
                }
            }
            else
            {
                Console.WriteLine("Смерть");
            }
        }
        else
        {
            Console.WriteLine("Вы попали в армию");
            Console.WriteLine("Плен или дезертирство?");
            Console.WriteLine("1. Да\n2. До конца");
            int armia = Convert.ToInt32(Console.ReadLine());
            if (armia == 1)
            {
                Console.WriteLine("Смерть в русской тюрьме");
            }
            else
            { 
                Console.WriteLine("Смерть");
            }
        }

        Console.ReadLine();

    }
}