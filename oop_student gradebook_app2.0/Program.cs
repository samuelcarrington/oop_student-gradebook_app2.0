using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace oop_student_gradebook_application
{
    /*
    // Object Oriented Project STUDENT GRADEBOOK APPLICATION 
    // Create a console application that will record the homework scores for each student. 
     
    // Define a class student that contains the following information: First Name, Last Name, 
    // a score for each of 5 homework assignments, and the average of those assignments. 
     
    // Declare two constructors, including one default constructor. 
     
    // Create a method that will calculate the average of the 5 homework assignments.  

    // The application should accept all inputs from a user and then write all of the information to a text file.  
    // Make sure the user can input as many students as they want and then can open up the text file to see all of the information.
    */

     class Program
    {
         static void Main(string[] args)
         {
             Student myNewStudent = new Student();
            
        }

    }
    class Student
    {
        // Define a class student that contains the following information: First Name, Last Name, 
        // a score for each of 5 homework assignments, and the average of those assignments.
        
        // Field firstName
        private string _firstName;
        // Field lastName
        private string _lastName;
        // Field Score1
        private double _Score1;
        // Field lastName
        private double _Score2;
        // Field lastName
        private double _Score3;
        // Field lastName
        private double _Score4;
        // Field lastName
        private double _Score5;
        // Field lastName
        private double _scoreAvg;

        // Declare two constructors, including one default constructor.

        // Default constructor
    public Student()
    {
            
            _firstName = "";
            _lastName = "";
            _Score1 = 0;
            _Score2 = 0;
            _Score3 = 0;
            _Score4 = 0;
            _Score5 = 0;
            _scoreAvg = 0;
    }

        // Constructor with parameters
    public Student(string firstName, string lastName, double Score1, double Score2, double Score3, double Score4, double Score5, double scoreAvg)
    {
            
            _firstName = firstName;
            _lastName = lastName;
            _Score1 = Score1;
            _Score2 = Score2;
            _Score3 = Score3;
            _Score4 = Score4;
            _Score5 = Score5;
            _scoreAvg = scoreAvg;
            //Console.WriteLine("Hello World!");
            //Console.ReadKey();

            // The application should accept all inputs from a user and then write all of the information to a text file.  
            // Make sure the user can input as many students as they want and then can open up the text file to see all of the information.
            using (StreamWriter writer = new StreamWriter("..\\grades.txt"))
            {
                writer.Write("Word ");
                writer.WriteLine("word 2");
                writer.WriteLine("First Name: {0}\n" +
                                    "Last Name: {1}\n" +
                                    "Score 1: {2}\n" +
                                    "Score 2: {3}\n" +
                                    "Score 3: {4}\n" +
                                    "Score 4: {5}\n" +
                                    "Avg. Score: {6}", _firstName, _lastName, _Score1, _Score2, _Score3, _Score4, _Score5, _scoreAvg);
            }
    }
        
        
        //Create a method that will calculate the average of the 5 homework assignments.
    public double GetScoreAvg()
    {
        return (_Score1 + _Score2 + _Score3 + _Score4 + _Score5) / 5;
    }


        //The application should accept all inputs from a user and then write all of the information to a text file.
        


    }
        //Make sure the user can input as many students as they want and 
        //then can open up the text file to see all of the information.
        
}
