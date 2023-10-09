using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casestudyproject
{
   public  class AppEngine
    {
        public static List<Student> students = new List<Student>();
        public static  List<Course> courses = new List<Course>();
        public static  List<Enroll> enrollments = new List<Enroll>();
        public static  void Introduce(Course course)
        {
            courses.Add(course);
            Console.WriteLine($"New course introduced: {course.coursename}");

        }
        public static void Register(Student student)
        {
            students.Add(student);
            Console.WriteLine($"New student registered: {student.Name}");

        }
        public static Student[] listofstudents()
        {
            return students.ToArray();

        }
        public static Course[] listofcourses()
        {
            return courses.ToArray();

        }
        public static void Enroll(Student student, Course course)
        {
            if (students.Contains(student) && courses.Contains(course))
            {
                var enrollment = new Enroll(student, course, DateTime.Now);
                enrollments.Add(enrollment);
                Console.WriteLine($"Enrolled student {student.Name} in course {course.coursename}");
            }
            else
            {
                Console.WriteLine("Student or course not found. Enrollment failed.");
            }
        }
        public static Enroll[] ListOfEnrollments()
        {
            return enrollments.ToArray();
        }


    }
}
