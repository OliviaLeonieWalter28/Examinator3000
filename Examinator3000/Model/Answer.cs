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
        private string answerText = String.Empty;
        private bool isAnswerCorrect;
        private bool isImageAnswer;
        private string imagePath = String.Empty;

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

    }
}
