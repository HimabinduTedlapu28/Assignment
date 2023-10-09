using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casestudyproject
{
    public abstract class UserInterface
    {
        public abstract void ShowFirstScreen();
        public abstract void ShowStudentScreen();
        public abstract void ShowAdminScreen();
        public abstract void ShowAllStudentsScreen();
        public abstract void ShowStudentRegistrationScreen();
        public abstract void IntroduceNewCourseScreen();
        public abstract void ShowAllCoursesScreen();
    }
    public class ConsoleUserInterface : UserInterface
    {
        public AppEngine appEngine = new AppEngine();
        public Info info = new Info();

        public override void ShowFirstScreen()
        {
            Console.WriteLine("Welcome to SMS (Student Mgmt. System) v1.0");
            Console.WriteLine("Tell us who you are:\n1. Student\n2. Admin \n3.Exit");
            Console.Write("Enter your choice (1 or 2 or 3): ");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    ShowStudentScreen();
                    break;
                case 2:
                    ShowAdminScreen();
                    break;
                case 3:
                    Exit();
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                    ShowFirstScreen();
                    break;
            }
        }

        public void Exit()
        {
            Console.WriteLine("Thank you ! ");
        }

        public override void ShowStudentScreen()
        {
            Console.WriteLine("Student Screen");
            Scenario1();
        }

       
        public override void ShowAdminScreen()
        {
            Console.WriteLine("Admin Screen");

        }

        public override void ShowAllStudentsScreen()
        {
            Console.WriteLine("All Students Screen");
            

        }

        public override void ShowStudentRegistrationScreen()
        {
            Console.WriteLine("Student Registration Screen");
            

        }

        public override void IntroduceNewCourseScreen()
        {
            Console.WriteLine("Introduce New Course Screen");
            

        }

        public override void ShowAllCoursesScreen()
        {
            Console.WriteLine("All Courses Screen");

        }
        public static void Scenario1()
        {
            Student student1 = new Student(1, "Ayan", "15-01-2001");
            Student student2 = new Student(2, "Arha", "13-09-2002");
            Student student3 = new Student(3, "Deepika", "04-05-2002");
            Student student4 = new Student(4, "Akshaya", "01-09-2003");
            Info info = new Info();
            Info.DisplayStudent(student1);
            Info.DisplayStudent(student2);
            Info.DisplayStudent(student3);
            Info.DisplayStudent(student4);
        }
        
        
    }
}
