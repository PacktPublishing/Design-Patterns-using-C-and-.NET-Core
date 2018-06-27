using System;
using System.Collections.Generic;
using System.Text;

namespace LSPExample
{
    public class QuizQuestion
    {
        public virtual string Question { get; set; }
        public virtual string Answer1 { get; set; }
        public virtual string Answer2 { get; set; }
        public virtual string Answer3 { get; set; }
        public virtual string Answer4 { get; set; }
        public virtual string CorrectAnswer { get; set; }
    }
}
