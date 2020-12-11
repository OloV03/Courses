using System;
using System.Collections.Generic;
using System.Text;

namespace Courses.Courses
{
    class English : Course
    {
        public string Bonus { get; set; }

        public English(string courseName, string teacherName, string language, double price, string bonus)
        {
            CourseName = courseName;
            TeacherName = teacherName;
            Language = language;
            Price = price;
            Bonus = bonus;
        }
    }
}
