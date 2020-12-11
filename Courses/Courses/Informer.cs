using System;
using System.Collections.Generic;
using System.Text;

namespace Courses.Courses
{
    class Informer
    {
        public void Buy(User user, Course course)
        {
            double price = course.GetDiscountPrice(user);
            user.ReduceBalance(price); // списываем средства с баланса
            Console.WriteLine($"{user.Name} приобрел курс \"{course.CourseName}\" по цене {price}.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Успешных Вам занятий!");
            Console.ResetColor();
        }
    }
}
