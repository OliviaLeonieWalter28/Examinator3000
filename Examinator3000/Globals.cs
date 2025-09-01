using Examinator3000.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examinator3000
{

    static public class Globals
    {
        public static List<Test>LoadedTests = new List<Test>();

        public static Test CurrentActiveTest;
        public static Question CurrentActiveQuestion;

        public static bool Checked;

        public static int CurrentTestCorrectAnswers;
        public static bool LastQuestion;

        public static void AddTest(string testName) 
        {
            CurrentActiveTest = new Test(testName);
            LoadedTests.Add(CurrentActiveTest);
        }

        //DEBUG
        public static void AddTestTest() 
        {
            var answer = new Answer("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum", false);
            var answer2 = new Answer("Answer2",true);
            var answer3= new Answer("Answer3",false);
            var answer4 = new Answer("Answer4",false);

            var answers = new List<Answer>();
            answers.Add(answer);
            answers.Add(answer2);   
            answers.Add(answer3);   
            answers.Add(answer4);

            var question = new Question("This is a Test Question", null, answers);

            var answer5 = new Answer("more correct", true);
            answers.Add(answer5);


            var question2 = new Question("This is a Test Question", null, answers);

            var test = new Test("AZ-204");
            test.AddNewQuestion(question);
            test.AddNewQuestion(question2);
            question.QuestionText = "This is a Test Question 2.0";
            test.AddNewQuestion(question);
            question.QuestionText = "This is a Test Question 3.0";
            test.AddNewQuestion(question);
            LoadedTests.Add(test);
            
        }
    }
}
