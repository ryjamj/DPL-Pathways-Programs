using System;
using System.Collections.Generic;   // needed for Lists

namespace AleclistAbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {

            // --------------------------------------
            // Create a list of Employee objects from abstract class
            Console.WriteLine("\nCreate employee list from abstract class, & print results");
            List<Employee> employeeList = new List<Employee>(); // this WILL work as the list is a created object from the list class.
            //Note: employeeList.Add(new Employee("Test", "test", "test")); // Add an employee? - Nope, this won't work. employee is an abstract class.  Instead use a child class.
            employeeList.Add(new HourlyEmployee("Enge", "J.S.", "H", 25.00));   // Add an hourly employee from HourlyEmployee class
            employeeList.Add(new SalaryEmployee("Enge", "Alec", "S", 15000));   // Add a salary employee from SalaryEmployee class

            // Print the employee list
            foreach (Employee anEmployee in employeeList)
            {
                Console.WriteLine(anEmployee);
            }  // end foreach  


            // --------------------------------------
            // Create a list of Hourly Employees & Salary Employees to test.
            Console.WriteLine("\nCreate employee list from HourlyEmployee class & SalaryEmployee class, print results");
            List<HourlyEmployee> hourlyEmployeeList = new List<HourlyEmployee>();  
            List<SalaryEmployee> salaryEmployeeList = new List<SalaryEmployee>();

            // Add a couple of hourly employees to the hourly list to test
            hourlyEmployeeList.Add(new HourlyEmployee("Enge", "Colin", "H", 15.75));
            hourlyEmployeeList.Add(new HourlyEmployee("Enge", "Elle", "H", 25.73));

            // Add a couple of salary employees to the salary list to test
            salaryEmployeeList.Add(new SalaryEmployee("Enge", "Anthony", "S", 45250));
            salaryEmployeeList.Add(new SalaryEmployee("Enge", "Molly", "S", 60000));

            // Print the hourly list
            foreach (HourlyEmployee anEmployee in hourlyEmployeeList)
            {
                Console.WriteLine(anEmployee);
            }  // end foreach  

            // Print the salary list
            foreach (SalaryEmployee anEmployee in salaryEmployeeList)
            {
                Console.WriteLine(anEmployee);
            }  // end foreach          

        } // end Main

    }  // end class Program

}  // end nameSspace