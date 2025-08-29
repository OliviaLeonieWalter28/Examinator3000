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
        private string answerText;
        private bool isAnswerCorrect;

        public Answer(string answerText, bool isAnswerCorrect) 
        {
            this.answerText = answerText;
            this.isAnswerCorrect = isAnswerCorrect;
        } 

    }
}
