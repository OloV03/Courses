﻿using System;
using Courses.Courses;
using System.Threading;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 63;
            User user = new User(
                "Никита",
                10000,
                650
                );
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Список курсов: ");
            Console.ResetColor();

            English eng = new English(
                "В Ландон за 15 минут в день",
                "Королева Елизавета",
                "Английский",
                490,
                "Пирожок с подливой"
                );
            eng.InfoCourse(eng);

            Germany ger = new Germany(
                "На Берлин",
                "Рудольф Иванов",
                "Немецкий",
                666
                );
            ger.InfoCourse(ger);

            Italy itl = new Italy(
                "Хочу Пасту Болоньезе",
                "Равиолли Веспучи",
                "Итальянский",
                575
                );
            itl.InfoCourse(itl);

            Course[] courses = new Course[]
            {
                eng,
                ger,
                itl
            };
            Informer informer = new Informer();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nДобро пожаловать в мир почти бесплатных знаний!\n");
                Console.ResetColor();

                for (int i = 0; i < courses.Length; i++)
                {
                    Console.WriteLine($"Курс {i} - \"{courses[i].CourseName}\" по цене {courses[i].Price}");
                }
                Console.Write("\nВыбериет номер интересующего направления и нажмите Enter: ");
                int productNumber = Int32.Parse(Console.ReadLine());

                if (productNumber >= 0 && productNumber < courses.Length)
                {
                    if (courses[productNumber].Price <= user.Balance)
                    {
                        informer.Buy(user, courses[productNumber]);
                        Bye();
                        //break;
                    }
                    else
                    {
                        Console.WriteLine("У Вас недостаточно средств");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Таких курсов у нас нет");
                    Console.ResetColor();
                }
            }

            static void Bye()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n-------------------------------------------------");
                Console.WriteLine("Спасибо что выбрали нашу компанию, ждем Вас снова!");
                Console.WriteLine("Удачных занятий!");
                Thread.Sleep(7500);
            }
        }
    }
}
