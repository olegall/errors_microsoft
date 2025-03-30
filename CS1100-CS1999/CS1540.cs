using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Errors.CS1100_CS1199
{
    internal class CS1540
    {
        class Program1
        {
            static void Main()
            {
                Employee.PreparePayroll();
            }
        }

        class Person
        {
            protected virtual void CalculatePay()
            //public virtual void CalculatePay()
            {
                Console.WriteLine("CalculatePay in Person class.");
            }
        }

        class Manager : Person
        {
            protected override void CalculatePay()
            //public override void CalculatePay()
            {
                Console.WriteLine("CalculatePay in Manager class.");

            }
        }

        class Employee : Person
        {
            public static void PreparePayroll()
            {
                Employee emp1 = new Employee();

                Person persEmp2 = new Manager();
                Person persEmp3 = new Employee();
                // The following line calls the method in the Employee base class,  
                // Person.  
                emp1.CalculatePay();

                // The following lines cause compiler error CS1540. The compiler
                // cannot determine at compile time what the run-time types of
                // emp2 and emp3 will be.  
                persEmp2.CalculatePay();
                persEmp3.CalculatePay();

                ((Manager)persEmp2).CalculatePay();

                Person pers = new Person();
                pers.CalculatePay();
                
                //(Manager)persEmp2.CalculatePay();
                //(Employee)persEmp3.CalculatePay();
            }
        }
    }
}
