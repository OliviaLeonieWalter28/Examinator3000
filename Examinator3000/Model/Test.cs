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
        public List<Question> Questions { get; set; }
        public int QuestionsCount { get; set; } = 0;
        public List<Question> ArchivedQuestions { get; set; } = new List<Question>();   
        public List<Question> WeakQuestions {  get; set; }  = new List<Question>();   
        public int AmountOfTimesRepeated { get; set; }
        public int ProcentageCorrect { get; set; }

        public Test()
        {
            Questions = new List<Question>();
        }   

    }
}
