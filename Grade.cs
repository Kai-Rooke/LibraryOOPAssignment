using System;
using System.Collections.Generic;
namespace OOP_Assignment{

    class Grade
        {
            int indGrade {get;set;}
            string moduleID {get;set;}
            int assignmentID {get;set;}
            double weight {get;set;}
            public Grade(int IndGrade, string ModuleID, int AssignmentID, double Weight)
            {
                this.indGrade = IndGrade;
                this.moduleID = ModuleID;
                this.assignmentID = AssignmentID;
                this.weight = Weight;
            }
        }
}