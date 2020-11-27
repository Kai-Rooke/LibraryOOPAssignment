using System;
using System.Collections.Generic;

namespace OOP_Assignment
{
    public class Student
    {
        string studentID;
        string firstName;
        string otherNames;
        string lastName;

        int age;
        string gender;
        string dateOfBirth;
        GradeProfile gradeProfile = new GradeProfile();

        public Student(string StudentID, string FirstName, string OtherNames, string LastName, int Age, string Gender, string DateofBirth)
        {
            this.studentID = StudentID;
            this.firstName = FirstName;
            this.otherNames = OtherNames;
            this.lastName = LastName;
            this.age = Age;
            this.gender = Gender;
            this.dateOfBirth = DateofBirth;
        }

        public void DisplayReportCard()
        {
            gradeProfile.grades.Add(new Grade(12, "OOP", 010, 1.0));
        }
    }
}