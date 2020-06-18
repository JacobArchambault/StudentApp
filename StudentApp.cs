using System;
using static System.Console;

namespace StudentApp
{
    class StudentApp
    {
        static void Main()
        {
            // Create a student object, populating its StudentFirstName, StudentLastName, and StudentNumber properties from static prompt methods of StudentApp class. 
            Student firstStudentObject = new Student
            {
                StudentFirstName = AskForStudentName("First"),
                StudentLastName = AskForStudentName("Last"),
                StudentNumber = AskForStudentNumber()
            };
            firstStudentObject.Major = AskForMajor(firstStudentObject.StudentFirstName);
            firstStudentObject.Score1 = AskForExamScore(1);
            firstStudentObject.Score2 = AskForExamScore(2);
            firstStudentObject.Score3 = AskForExamScore(3);

            // Working with added property.
            while (true)
            {
                WriteLine("Enter your expected date of graduation");
                string graduationDateString = ReadLine();
                if (DateTime.TryParse(graduationDateString, out DateTime graduationDate))
                {
                    firstStudentObject.GraduationDate = graduationDate;
                    break;
                }
                else
                {
                    WriteLine("You must enter a valid month, day, and year. Try again");
                }
            }

            // Clear the screen
            Clear();

            // Using the override of the ToString() method, write a student's information. 
            WriteLine("First Student");
            WriteLine(firstStudentObject.ToString());

            // Create a second student object using one-argument constructor. 
            Student secondStudentObject = new Student("2345")
            {
                Score1 = 95,
                Score2 = 62,
                Score3 = 87
            };
            // Use the Console.WriteLine method, concatenation, and the second student's ID number and average to one decimal point into a string displayed on the console."
            WriteLine("\n\nSecond Student");
            WriteLine("Student Number: " + secondStudentObject.StudentNumber +
                               "\nAverage: {0:F1}", secondStudentObject.CalculateAverage());


            // Create a third object using three-argument constructor.
            Student thirdStudentObject = new Student("5432", "Randolph", "Wonder")
            {
                Major = "Math",
                Score1 = 95,
                Score2 = 87,
                Score3 = 72
            };
            WriteLine("\n\nThird Student");
            WriteLine(thirdStudentObject);

            // Create an object using a seven-argument constructor, then write each of its properties to the console using string concatenation.
            Student aStudentObject = new Student("1234", "Maria", "Smith", 97, 75, 87, "CS");
            WriteLine("\n\nLast Student");
            WriteLine("Student Name: " + aStudentObject.StudentFirstName +
                              " " + aStudentObject.StudentLastName +
                              "\nStudent Number: " + aStudentObject.StudentNumber +
                              "\nMajor: " + aStudentObject.Major +
                              "\nExam Score 1: " + aStudentObject.Score1 +
                              "\nExam Score 2: " + aStudentObject.Score2 +
                              "\nExam Score 3: " + aStudentObject.Score3 +
                              "\nExam Average: " + aStudentObject.CalculateAverage().ToString("F1"));
            ReadKey();
        }

        // Get an exam score from a user input and parse it to an integer, and return the result.
        static int AskForExamScore(int whichOne)
        {
            string inValue;
            int aScore;
            Write("Enter a value for Score {0}: ", whichOne);
            inValue = ReadLine();
            aScore = int.Parse(inValue);
            return aScore;
        }

        // return a user's response to a written prompt for his/her name. 
        static string AskForStudentName(string whichOne)
        {
            string inValue;
            Write("Enter Student {0} Name: ", whichOne);
            inValue = ReadLine();
            return inValue;
        }
        // return a user's response to a written prompt for his/her major. 
        static string AskForMajor(string name)
        {
            string inValue;
            Write("Enter {0}\'s Major: ", name);
            inValue = ReadLine();
            return inValue;
        }

        // return a user's response to a written prompt for his/her i.d. number as a string. 
        static string AskForStudentNumber()
        {
            string inValue;
            Write("Enter Student Number: ");
            inValue = ReadLine();
            return inValue;
        }
    }
}
