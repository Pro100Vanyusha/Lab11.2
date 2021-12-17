using System;
using System.Collections.Generic;

namespace Lab11._2
{
    class Program
    {
        class program
        {

            static void Main(string[] args)
            {

                Console.WriteLine("Сегодня : " + DateTime.Now);
                Console.WriteLine("Укажите дату в таком формате : day-moon-year");
                string udate = Console.ReadLine();
                string[] input = udate.Split("-");

                int year = Int32.Parse(input[2]);
                int month = Int32.Parse(input[1]);
                int day = Int32.Parse(input[0]);

                Console.WriteLine("Вы указали : " + udate);
                DateTime x = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                DateTime y = new DateTime(year, month, day);

                TimeSpan ts = y - x;
                Console.WriteLine("Разница между даты : " + ts.Days + " дня.");
                Console.ReadLine();
            }
        }

    }
}
