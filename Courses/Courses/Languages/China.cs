using System;
using System.Collections.Generic;
using System.Text;

namespace Courses.Courses
{
    class China : Course
    {
        public China(string courseName, string teacherName, string language, double price)
        {
            CourseName = courseName;
            TeacherName = teacherName;
            Language = language;
            Price = price;
        }
    }
}
