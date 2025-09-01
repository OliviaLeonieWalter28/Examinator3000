using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Examinator3000.Model
{
    public class Answer
    {
        public string answerText {  get; set; } = string.Empty;

        public bool isAnswerCorrect { get; set; }
        public bool isImageAnswer {  get; set; }    
        public string imagePath { get; set; } = String.Empty;

        public Answer() { } 
        public Answer(string answerText, bool isAnswerCorrect) 
        {
            this.answerText = answerText;
            this.isAnswerCorrect = isAnswerCorrect;
            this.isImageAnswer = false;
            
        }
        public Answer(bool isAnswerCorrect,string imagePath)
        {
            this.isAnswerCorrect = isAnswerCorrect;
            this.isImageAnswer = true;
            this.imagePath = imagePath;
        }
        public bool isCorrectAnswer() 
        {
            return isAnswerCorrect; 
        }
        public string GetAnswerText() 
        {
            return answerText;
        }
        public string GetImagePath() 
        {
            return imagePath;   
        }

    }
}
