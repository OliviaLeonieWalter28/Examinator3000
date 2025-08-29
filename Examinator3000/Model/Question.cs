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
        public bool HasAnswerAlterntive { get; set; }
        private bool isPictureQuestion;
        public List<Answer> AnswerList;

        public Question(string questionText, string questionImage, List<Answer> answers, bool hasAnswerAlterntive)
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
            HasAnswerAlterntive = hasAnswerAlterntive;  

            foreach (Answer answer in answers)
            {
                AnswerList.Add(answer);
            }
        }    
    }
}
