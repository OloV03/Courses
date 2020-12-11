using System;
using System.Collections.Generic;
using System.Text;

namespace Courses.Courses
{
    class Germany : Course
    {
        public Germany(string courseName, string teacherName, string language, double price)
        {
            CourseName = courseName;
            TeacherName = teacherName;
            Language = language;
            Price = price;
        }
    }
}
