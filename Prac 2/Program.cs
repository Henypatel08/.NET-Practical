using System;

namespace Prac_2
{
    // Base class
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public string Department;
        public double BasicSalary;

        public Employee(int id, string name, string dept, double salary)
        {
            EmpId = id;
            EmpName = name;
            Department = dept;
            BasicSalary = salary;
        }
    }

    // Interface
    interface IPayroll
    {
        double CalculateSalary();
        void DisplayPayroll();
    }

    // Derived class - Full Time Employee
    class FullTimeEmployee : Employee, IPayroll
    {
        public FullTimeEmployee(int id, string name, string dept, double salary)
            : base(id, name, dept, salary)
        {
        }

        public double CalculateSalary()
        {
            double da = BasicSalary * 0.10;
            double hra = BasicSalary * 0.20;
            double ta = BasicSalary * 0.05;
            double medical = BasicSalary * 0.03;
            double bonus = BasicSalary * 0.08;

            double pf = BasicSalary * 0.12;
            double tax = BasicSalary * 0.05;

            double grossSalary =
                BasicSalary + da + hra + ta + medical + bonus;

            double totalDeduction = pf + tax;

            double netSalary = grossSalary - totalDeduction;

            return netSalary;
        }

        public void DisplayPayroll()
        {
            double da = BasicSalary * 0.10;
            double hra = BasicSalary * 0.20;
            double ta = BasicSalary * 0.05;
            double medical = BasicSalary * 0.03;
            double bonus = BasicSalary * 0.08;

            double pf = BasicSalary * 0.12;
            double tax = BasicSalary * 0.05;

            double grossSalary =
                BasicSalary + da + hra + ta + medical + bonus;

            double totalDeduction = pf + tax;

            double netSalary = grossSalary - totalDeduction;

            Console.WriteLine();
            Console.WriteLine("======================================");
            Console.WriteLine("     FULL-TIME EMPLOYEE PAYROLL");
            Console.WriteLine("======================================");

            Console.WriteLine("Employee ID : " + EmpId);
            Console.WriteLine("Employee Name : " + EmpName);
            Console.WriteLine("Department : " + Department);

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Basic Salary : " + BasicSalary);
            Console.WriteLine("DA (10%) : " + da);
            Console.WriteLine("HRA (20%) : " + hra);
            Console.WriteLine("TA (5%) : " + ta);
            Console.WriteLine("Medical (3%) : " + medical);
            Console.WriteLine("Bonus (8%) : " + bonus);

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("PF (12%) : " + pf);
            Console.WriteLine("Income Tax (5%) : " + tax);

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Gross Salary : " + grossSalary);
            Console.WriteLine("Total Deduction : " + totalDeduction);
            Console.WriteLine("Net Salary : " + netSalary);
            Console.WriteLine("Annual Salary : " + (netSalary * 12));

            Console.WriteLine("======================================");
        }
    }

    // Derived class - Part Time Employee
    class PartTimeEmployee : Employee, IPayroll
    {
        public int HoursWorked;
        public double RatePerHour;

        public PartTimeEmployee(
            int id,
            string name,
            string dept,
            int hours,
            double rate)
            : base(id, name, dept, 0)
        {
            HoursWorked = hours;
            RatePerHour = rate;
        }

        public double CalculateSalary()
        {
            double salary = HoursWorked * RatePerHour;
            double bonus = salary * 0.05;

            return salary + bonus;
        }

        public void DisplayPayroll()
        {
            double salary = HoursWorked * RatePerHour;
            double bonus = salary * 0.05;
            double netSalary = salary + bonus;

            Console.WriteLine();
            Console.WriteLine("======================================");
            Console.WriteLine("     PART-TIME EMPLOYEE PAYROLL");
            Console.WriteLine("======================================");

            Console.WriteLine("Employee ID : " + EmpId);
            Console.WriteLine("Employee Name : " + EmpName);
            Console.WriteLine("Department : " + Department);

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Hours Worked : " + HoursWorked);
            Console.WriteLine("Rate Per Hour : " + RatePerHour);
            Console.WriteLine("Salary : " + salary);
            Console.WriteLine("Bonus (5%) : " + bonus);

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Net Salary : " + netSalary);

            Console.WriteLine("======================================");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("       EMPLOYEE PAYROLL MANAGEMENT");
            Console.WriteLine("==========================================");

            Console.WriteLine("\nSelect Employee Type");
            Console.WriteLine("1. Full-Time Employee");
            Console.WriteLine("2. Part-Time Employee");

            Console.Write("\nEnter Your Choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter Employee ID : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name : ");
            string name = Console.ReadLine();

            Console.Write("Enter Department : ");
            string dept = Console.ReadLine();

            IPayroll payroll;

            if (choice == 1)
            {
                Console.Write("Enter Basic Salary : ");
                double salary = Convert.ToDouble(Console.ReadLine());

                payroll = new FullTimeEmployee(
                    id,
                    name,
                    dept,
                    salary
                );

                payroll.DisplayPayroll();
            }
            else if (choice == 2)
            {
                Console.Write("Enter Hours Worked : ");
                int hours = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Rate Per Hour : ");
                double rate = Convert.ToDouble(Console.ReadLine());

                payroll = new PartTimeEmployee(
                    id,
                    name,
                    dept,
                    hours,
                    rate
                );

                payroll.DisplayPayroll();
            }
            else
            {
                Console.WriteLine("\nInvalid Choice!");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}