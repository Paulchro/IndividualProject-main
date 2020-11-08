using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.Models;
using IndividualProject.BusinessLogic;

namespace IndividualProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandPromptUtils cpUtils = new CommandPromptUtils();

            // CB12 Full TIme c#
            // CB12 Full Time Java

            //List<Trainer> trainers = new List<Trainer>();
            //for (int i = 0; i < 2; i++)
            //{
            //    trainers.Add(cpUtils.GetTrainerDetails());
            //}
            //cpUtils.PrintTrainersList(trainers);


            List<Student> students = new List<Student>();
            for (int i = 0; i < 2; i++)
            {
                students.Add(cpUtils.GetStudentDetails());
            }
            cpUtils.PrintStudentsList(students);

            List<Course> courses = new List<Course>();
            for (int i = 0; i < 2; i++)
            {
                courses.Add(cpUtils.GetCourseDetails()); 
            }
            cpUtils.PrintCourseList(courses);

            //List<Assignment> assignments = new List<Assignment>();
            //for (int i = 0; i < 2; i++)
            //{
            //    assignments.Add(cpUtils.GetAssignmentDetails());
            //}
            //cpUtils.PrintAssingmentList(assignments);

            

        }

        
        // Create appropriate methods in order to ask 
        // from the user data for the four main classes
    }
}
