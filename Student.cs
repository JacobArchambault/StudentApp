using System;

namespace StudentApp
{
    public class Student
    {
        //Properties
        public string StudentLastName { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentNumber { get; set; }
        public string Major { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public int Score3 { get; set; }

        // Added property.
        public DateTime GraduationDate { get; set; }

        //Default constructor
        public Student() { }

        //Constructor with one argument
        public Student(string sID) { StudentNumber = sID; }

        //Constructor with three arguments
        public Student(string sID, string lastName, string firstName)
        {
            StudentNumber = sID;
            StudentLastName = lastName;
            StudentFirstName = firstName;
        }

        //Constructor with six arguments
        public Student(string sID, string lastName, string firstName,
					   int s1, int s2, int s3, string maj)
        {
            StudentNumber = sID;
            StudentLastName = lastName;
            StudentFirstName = firstName;
            Score1 = s1;
            Score2 = s2;
            Score3 = s3;
            Major = maj;
        }


        public double CalculateAverage() => (Score1 + Score2 + Score3) / 3.0;

        public override string ToString()
        {
            return "Name: " +
                StudentFirstName + " " + StudentLastName +
                "\nMajor: " + Major +
                // Add graduation date property to ToString override.
                "\nExpected Graduation Date: " + GraduationDate.ToShortDateString() +
                "\nScore Average: " +
                CalculateAverage().ToString("F2");
        }
    }
}
