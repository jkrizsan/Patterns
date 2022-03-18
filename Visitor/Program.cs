using System;
using Visitor.Visitors;
using Visitor.Employees;

namespace Visitor
{
    /// <summary>
    /// Visitor Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Employees.Employees employee = new Employees.Employees();
            employee.Attach(new Clerk());
            employee.Attach(new Director());
            employee.Attach(new President());

            employee.Accept(new IncomeVisitor());
            employee.Accept(new VacationVisitor());

            Console.ReadKey();
        }
    }   
}
