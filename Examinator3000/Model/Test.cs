using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examinator3000.Model
{
    public class Test
    {
        public string TestName { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();
        public List<Question> ArchivedQuestions { get; set; } = new List<Question>();   
        public List<Question> WeakQuestions {  get; set; }  = new List<Question>();
        public List<Question> RepeatQuestions { get; set; } = new List<Question>();
        public int AmountOfTimesRepeated { get; set; } = 0;
        public int ProcentageCorrect { get; set; } = 0;

        public Test() { }
        public Test(string testName)
        {
            TestName = testName;
        }   


        public void AddNewQuestion(Question question) 
        {
            Questions.Add(question);
        }
        public void RemoveNewQuestion(Question question) 
        {
            Questions.Remove(question);
        }
        public int CalculatePercentage() 
        {
            if (Questions.Count == 0) return 0;

            double percentageDouble = (double)Globals.CurrentTestCorrectAnswers / Questions.Count * 100;
            int percentage = (int)Math.Round(percentageDouble); 
            ProcentageCorrect = percentage;

            return percentage;
        }

    }
}
