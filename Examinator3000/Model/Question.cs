using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examinator3000.Model
{
    public class Question
    {
        public string QuestionText { get; set; }    
        public string QuestionImage { get; set; }

        public bool isPictureQuestion { get; set; }
        public int timesRepeated { get; set; } = 0;
        public int correcltyRepeated { get; set; } = 0;



        public List<Answer> AnswerList { get; set; } = new List<Answer>();

        public Question() { }

        public Question(string questionText, string questionImage, List<Answer> answers)
        {
            AnswerList = new List<Answer>();
            QuestionText = questionText;                                
            
            if (String.IsNullOrWhiteSpace(questionImage)) 
            {
                isPictureQuestion = false;
                QuestionImage = string.Empty;                        
            }
            else 
            {
                isPictureQuestion = true;
                QuestionImage = questionImage;
            } 

            foreach (Answer answer in answers)
            {
                AnswerList.Add(answer);
            }
        }
        public bool IsPictureQuestion()
        {
            return isPictureQuestion;
        } 
        public void AddTimesRepeated() 
        {
            timesRepeated += 1;
        }
        public void AddTimesCorrectlyRepeated()
        {
            correcltyRepeated += 1;
        }
        public int GetTimesRepeated() 
        {
            return timesRepeated;
        }
        public int GetTimesCorrectlyRepeated() 
        {
            return correcltyRepeated;
        }
        public void SetResult(bool answeredCorrectly) 
        {
            
            AddTimesRepeated();
            if(timesRepeated == 1 && answeredCorrectly) 
            {
                Globals.CurrentTestCorrectAnswers += 1;
            }
            if (answeredCorrectly) AddTimesCorrectlyRepeated();

            if (GetTimesRepeated() == 5 && GetTimesCorrectlyRepeated() < 3)
            {
                Globals.CurrentActiveTest.WeakQuestions.Add(Globals.CurrentActiveQuestion);
                Globals.CurrentActiveTest.RepeatQuestions.Remove(this);
            }
        }
    }
}
