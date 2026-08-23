using System;

namespace Practical_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating the first object
            HenyStudent s1 = new HenyStudent();

            s1.AcceptDetails();
            s1.CheckScholarshipEligibility();
            s1.CheckAdmissionEligibility();
            s1.DisplayDetails();

            Console.ReadKey();
        }

        /// <summary>
        /// Student class to represent a student in the admission system
        /// </summary>
        class HenyStudent
        {
            // Public data members
            public int AdmissionNumber;
            public int EnrollmentNumber;
            public string StudentName;
            public string Course;
            public string Branch;
            public int Semester;
            public string HSCStream;
            public double Percentage;

            // Private data members
            private double Fees;
            private bool IsScholarshipEligible;
            private bool IsAdmissionEligible;

            // Constant
            private const double ScholarshipRate = 0.30;

            // Default constructor
            public HenyStudent()
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("              STUDENT ADMISSION SYSTEM");
                Console.WriteLine("---------------------------------------------------");

                // Default values
                Course = "Computer Engineering";
                Semester = 5;

                Console.WriteLine("Student object Created Successfully....");
                Console.WriteLine();
            }

            // Method to accept student details
            public void AcceptDetails()
            {
                Console.Write("Enter Admission/GR Number : ");
                AdmissionNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Enrollment Number : ");
                EnrollmentNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Student Name : ");
                StudentName = Console.ReadLine();

                Console.Write("Enter HSC Stream (Science/Commerce/Arts) : ");
                HSCStream = Console.ReadLine();

                Console.Write("Enter Percentage : ");
                Percentage = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Course : ");
                Course = Console.ReadLine();

                Console.Write("Enter Branch : ");
                Branch = Console.ReadLine();

                Console.Write("Enter Semester : ");
                Semester = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Admission Fees : ");
                Fees = Convert.ToDouble(Console.ReadLine());
            }

            // Method to check Scholarship Eligibility
            public void CheckScholarshipEligibility()
            {
                if (Fees <= 62500)
                {
                    IsScholarshipEligible = true;
                }
                else
                {
                    IsScholarshipEligible = false;
                }
            }

            // Method to check Admission Eligibility
            public void CheckAdmissionEligibility()
            {
                if (HSCStream.ToLower() != "science")
                {
                    IsAdmissionEligible = false;
                }
                else if (Percentage < 45)
                {
                    IsAdmissionEligible = false;
                }
                else
                {
                    IsAdmissionEligible = true;
                }
            }

            // Method to Display Student Details
            public void DisplayDetails()
            {
                double FinalFees = Fees;

                if (IsScholarshipEligible)
                {
                    FinalFees = Fees - (Fees * ScholarshipRate);
                }

                Console.WriteLine();
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("              STUDENT ADMISSION DETAILS");
                Console.WriteLine("---------------------------------------------------");

                Console.WriteLine("Admission Number : " + AdmissionNumber);
                Console.WriteLine("Enrollment Number : " + EnrollmentNumber);
                Console.WriteLine("Student Name : " + StudentName);
                Console.WriteLine("HSC Stream : " + HSCStream);
                Console.WriteLine("Percentage : " + Percentage + "%");
                Console.WriteLine("Course Name : " + Course);
                Console.WriteLine("Branch Name : " + Branch);
                Console.WriteLine("Semester : " + Semester);
                Console.WriteLine("Actual Admission Fees : " + Fees);

                Console.WriteLine(
                    "Admission Status : " +
                    (IsAdmissionEligible ? "Eligible" : "Not Eligible")
                );

                Console.WriteLine(
                    "Scholarship : " +
                    (IsScholarshipEligible ? "Eligible" : "Not Eligible")
                );

                Console.WriteLine("Final Fees you have to be : " + FinalFees);

                Console.WriteLine("---------------------------------------------------");
            }
        }
    }
}