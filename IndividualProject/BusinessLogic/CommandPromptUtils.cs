using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using IndividualProject.Models;

namespace IndividualProject.BusinessLogic
{
    class CommandPromptUtils
    {
        public Trainer GetTrainerDetails(List<string> subjects = null)
        {
            
            if (subjects == null) subjects = new List<string>() { "C#", "Java", "Python", "JavaScript", "PHP" };
            Trainer trainer = new Trainer();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Trainers name");
            Console.ResetColor();
            trainer.FirstName = AskDetail("Give me your first name");
            trainer.LastName  = AskDetail("Give me your last name");
            trainer.Subject   = AskDetail("Give me the subject you teach", subjects);
            return (trainer);

        }

        public Student GetStudentDetails()
        {
            Student student = new Student();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Students name");
            Console.ResetColor();
            student.FirstName = AskDetail("Give me your first name");
            student.LastName = AskDetail("Give me your last name");
            student.TuitionFees = float.Parse(AskDetail("Give me the fees you paid"));
            student.dt = AskDetail("Give me your date of birth(dd/MM/yyyy)");


            return (student);
        }

        public Course GetCourseDetails(List<string> type = null, List<string> stream = null, List<string> title = null)
        {
            if (title == null) title = new List<string>() { "CB11", "CB12" };
            if (stream == null) stream = new List<string>() { "Java", "Csharp" , "Php"};
            if (type == null) type = new List<string>() { "Full Time" , "Part Time" };
            Course course = new Course();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Course details");
            Console.ResetColor();
            course.Title  = AskDetail("Give me courses title", title );
            course.Stream = AskDetail("Give me your stream name", stream);
            course.Type   = AskDetail("Give me the course type", type);
            course.Dt1    = AskDetail("Give me course start date(dd/MM/yyyy)");
            course.Dt2    = AskDetail("Give me course end date(dd/MM/yyyy)");
            return (course);
        }

        public Assignment GetAssignmentDetails()
        {
            Assignment assignment = new Assignment();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Assigments details");
            Console.ResetColor();
            assignment.Title = AskDetail("Give me the title");
            assignment.Decreption = AskDetail("Give me a descreption");
            assignment.SubDateTime = (AskDetail("Give me the Sub date(dd/MM/yyyy)"));
            assignment.GetOralMark = AskDetail("Give me your oral mark");
            assignment.GetTotalMark = AskDetail("Give me your Total mark");

            return (assignment);
        }

        private string AskDetail(string message, List<string> subjects = null) // List<string> type = null)
        {
          
            string result = "";
            Console.Write(message + ": ");
             if(subjects != null)
                
                {
                // ask for the subject the trainer teaches
                result = SelectFromListOfStrings(subjects);
            } 
            else
            {
                result = Console.ReadLine();
            }
             
            return (result);
        }

        private string SelectFromListOfStrings(List<string> elements)
        {
            string result = "";
            int counter = 1;
           
                Console.WriteLine();
                foreach (var item in elements)
                {
                    Console.WriteLine($"{counter++}. {item}");
                }
                int choice = Convert.ToInt32(Console.ReadLine());
                result = elements.ElementAt(choice - 1);
            
                return result;
           
        } 

        public void PrintTrainersList(List<Trainer> trainers)
        {
            foreach (var item in trainers)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(item);
                Console.ResetColor();
            }
        }
        public void PrintStudentsList(List<Student> students)
        {
            foreach (var item in students)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(item);
                Console.ResetColor();
            }
        }
        public void PrintCourseList(List<Course> courses)
        {
            foreach (var item in courses)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(item);
                Console.ResetColor();
            }

        }
        public void PrintAssingmentList(List<Assignment> assignments)
        {
            foreach (var item in assignments)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(item);
                Console.ResetColor();
            }

            
        }

       

    
    }
}

