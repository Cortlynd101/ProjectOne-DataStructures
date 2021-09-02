﻿using System;
using static System.Console;

namespace DataStruct
{
    class TestPerson
    {
        static void Main(string[] args)
        {
            Beep();
            WriteLine("Hello World!");
            WriteLine();

            var studentOne = new Student("Cortlynd Cox", "334567", 13, 3.3M);
            WriteLine("Name: " + studentOne.Name);
            WriteLine("ID: " + studentOne.ID);
            WriteLine("Credits: " + studentOne.Credits);
            WriteLine("GPA: " + studentOne.GPA);

            WriteLine("Welcome to the Student Data Portal. ");

            SystemMethod();
        }
        public static void SystemMethod()
        {
            bool ExitSystem = false;
            do
            {

                WriteLine("Would you like to add a new student? [1] ");
                WriteLine("Find the data on a student already in the system? [2]");
                Write("Or exit the system and shut down the program? [3] ");

                string userInput = ReadLine().ToString().ToLower();
                if (userInput == "1")
                {
                    StudentAddMethod();
                }
                else if (userInput == "2")
                {
                    StudentFindMethod();
                }
                else if (userInput == "3")
                {
                    WriteLine("Thank you for using the Student Data Portal.");
                    System.Threading.Thread.Sleep(50);
                    ExitSystem = true;
                }
                else
                {
                    WriteLine("That is an incorrect input, please enter a correct input. ");
                }

            } while (ExitSystem == false);
        }

        public static void StudentFindMethod()
        {
            throw new NotImplementedException();
        }

        public static void StudentAddMethod()
        {
            bool StudentAddedSuccessfully = false;
            bool Confirmation = false;
            WriteLine();
            do
            {
                Write("\nPlease enter the student name: ");
                string name = ReadLine().ToString().ToLower();

                Write("Please enter the student ID: ");
                string id = ReadLine().ToString().ToLower();

                Write("Please enter the student's credits earned: ");
                string credits = ReadLine().ToString().ToLower();

                Write("Please enter the student's GPA: ");
                string gpa = ReadLine().ToString().ToLower();

                do
                {
                    WriteLine("\nIs this correct for the student name and ID? ");
                    WriteLine($"Name: {name}");
                    WriteLine($"ID: {id}");
                    WriteLine($"Credits earned: {credits}");
                    WriteLine($"GPA: {gpa}");
                    Write("Enter [1] if it is correct and [2] if it isn't: ");

                    string userInput = ReadLine().ToString().ToLower();
                    if (userInput == "1")
                    {
                        //var id = new Student(name, id, credits, gpa);

                        WriteLine("Student successfully added. ");
                        WriteLine();
                        StudentAddedSuccessfully = true;
                        Confirmation = true;
                    }
                    else if (userInput == "2")
                    {
                        Confirmation = true;
                    }
                    else
                    {
                        WriteLine("That is an incorrect input, please enter a correct input: ");
                    }

                } while (Confirmation == false);
            } while (StudentAddedSuccessfully == false);
        }
    }
}