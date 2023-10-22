using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Assignment
{
    class employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }

        public employee(int employeeID, string firstName, string lastName, string title, DateTime dob, DateTime doj, string city)
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            DOB = dob;
            DOJ = doj;
            City = city;
        }

        static void Main(string[] args)
        {
            List<employee> empList = new List<employee>
            {



            new employee(1001, "Malcolm", "Daruwalla", "Manager", new DateTime(1984, 11, 16), new DateTime(2011, 8, 6), "Mumbai"),
            new employee(1002, "Asdin", "Dhalla", "AsstManager", new DateTime(1984, 8, 20), new DateTime(2012, 7, 7), "Mumbai"),
            new employee(1003, "Madhavi", "Oza", "Consultant", new DateTime(1987, 11, 14), new DateTime(2015, 12, 4), "Pune"),
            new employee(1004, "Saba", "Shaikh", "SE", new DateTime(1990, 3, 6), new DateTime(2016, 2, 2), "Pune"),
            new employee(1005, "Nazia", "Shaikh", "SE", new DateTime(1991, 8, 3), new DateTime(2016, 2, 2), "Mumbai"),
            new employee(1006, "Amit", "Pathak", "Consultant", new DateTime(1989, 7, 11), new DateTime(2014, 8, 8), "Chennai"),
            new employee(1007, "Vijay", "Natrajan", "Consultant", new DateTime(1989, 2, 12), new DateTime(2015, 1, 6), "Mumbai"),
            new employee(1008, "Rahul", "Dubey", "Associate", new DateTime(1993, 11, 11), new DateTime(2014, 6, 11), "Chennai"),
            new employee(1009, "Suresh", "Mistry", "Associate", new DateTime(1992, 12, 8), new DateTime(2014, 3, 12), "Chennai"),
            new employee(1010, "Sumit", "Shah", "Manager", new DateTime(1991, 4, 12), new DateTime(2016, 2, 1), "Pune")
            };
            var employeesJoinedBefore2015 = empList.Where(e => e.DOJ < new DateTime(2015, 1, 1));
            Console.WriteLine("Employees who joined before 1/1/2015:");
            foreach (var employee in employeesJoinedBefore2015)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
            var employeesBornAfter1990 = empList.Where(e => e.DOB > new DateTime(1990, 1, 1));
            Console.WriteLine("\nEmployees born after 1/1/1990:");
            foreach (var employee in employeesBornAfter1990)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
            var consultantAndAssociateEmployees = empList.Where(e => e.Title == "Consultant" || e.Title == "Associate");
            Console.WriteLine("\nConsultant and Associate Employees:");
            foreach (var employee in consultantAndAssociateEmployees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
            int totalEmployees = empList.Count;
            Console.WriteLine($"\nTotal number of employees: {totalEmployees}");
            int chennaiEmployees = empList.Count(e => e.City == "Chennai");
            Console.WriteLine($"Total number of employees in Chennai: {chennaiEmployees}");
            int maxEmployeeID = empList.Max(e => e.EmployeeID);
            Console.WriteLine($"Highest Employee ID: {maxEmployeeID}");
            int employeesJoinedAfter2015 = empList.Count(e => e.DOJ > new DateTime(2015, 1, 1));
            Console.WriteLine($"Employees who joined after 1/1/2015: {employeesJoinedAfter2015}");
            int employeesNotAssociate = empList.Count(e => e.Title != "Associate");
            Console.WriteLine($"Employees with designation not 'Associate': {employeesNotAssociate}");
            var cityEmployeeCounts = empList.GroupBy(e => e.City).Select(g => new
            {
                City = g.Key,
                Count = g.Count()
            });
            Console.WriteLine("\nEmployees by City:");
            foreach (var cityCount in cityEmployeeCounts)
            {
                Console.WriteLine($"{cityCount.City}: {cityCount.Count}");
            }
            var cityAndTitleEmployeeCounts = empList.GroupBy(e => new { e.City, e.Title }).Select(g => new
            {
                City = g.Key.City,
                Title = g.Key.Title,
                Count = g.Count()
            });

            Console.WriteLine("\nEmployees by City and Title:");
            foreach (var cityTitleCount in cityAndTitleEmployeeCounts)
            {
                Console.WriteLine($"{cityTitleCount.City}, {cityTitleCount.Title}: {cityTitleCount.Count}");
            }
            var youngestEmployee = empList.OrderBy(e => e.DOB).First();
            Console.WriteLine($"\nThe youngest employee is {youngestEmployee.FirstName} {youngestEmployee.LastName} (DOB: {youngestEmployee.DOB.ToShortDateString()}).");
            Console.ReadLine();
            Console.ReadLine();
        }
        








    }

    
}
