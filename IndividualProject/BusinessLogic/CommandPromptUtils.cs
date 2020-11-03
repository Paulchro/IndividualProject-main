using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.Models;

namespace IndividualProject.BusinessLogic
{
    class CommandPromptUtils
    {
        public Trainer GetTrainerDetails(List<string> subjects = null)
        {
            if(subjects == null) subjects = new List<string>() { "C#", "Java", "Python", "JavaScript", "PHP" };
            Trainer trainer = new Trainer();
            trainer.FirstName = AskDetail("Give me your first name");
            trainer.LastName  = AskDetail("Give me your last name");
            trainer.Subject   = AskDetail("Give me the subject you teach", subjects);
            return (trainer);
        }

        //public Course GetCourseDetails(List<string> subjects = null)
        //{
        //    Course course = new Course();

        //    return (course);
        //}

        //public Student GetStudentDetails(List<string> subjects = null)
        //{
        //    Student course = new Student();

        //    return (course);
        //}

        //public Assignment GetAssignmentDetails(List<string> subjects = null)
        //{
        //    Assignment course = new Assignment();

        //    return (course);
        //}

        private string AskDetail(string message, List<string> subjects = null)
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
            result = elements.ElementAt(choice - 1); //elements[choice - 1];
            return (result);
        }

        public void PrintTrainersList(List<Trainer> trainers)
        {
            foreach (var item in trainers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
