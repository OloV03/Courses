using System;
using System.Collections.Generic;
using System.Text;

namespace Courses
{
    class Course
    {
        public string CourseName { get; set; }
        public string TeacherName { get; set; }
        public string Language { get; set; }
        public double Price { get; set; }

        // система скидок
        public virtual double GetDiscountPrice(User user)
        {
            if (user.Spent < 500)
            {
                return Price;
            }

            if (user.Spent < 1000)
            {
                return 0.8 * Price;
            }

            return 0.75 * Price;
        }

        public virtual void InfoCourse(Course course)
        {
            Console.WriteLine();
            Console.WriteLine($"Название курса: \"{CourseName}\"");
            Console.WriteLine($"Преподователь курса: {TeacherName}");
            Console.WriteLine($"Язык курса: {Language}");
            Console.WriteLine($"Стоимость курса(руб): {Price}");
        }
    }
}
