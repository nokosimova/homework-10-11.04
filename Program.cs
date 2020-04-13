using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        class Student
        {
            public int id{get;}
            public string FirstName{get; set;}
            public string LastName{get; set;}
            public string MiddleName{get; set;}
            public int StudId{get; set;}
            public int CourseId{get; set;} // код предмета
            public string Course{get; set;} // предмет
            public int Point{get; set;} //оценка
            
            
        }
    }
}
