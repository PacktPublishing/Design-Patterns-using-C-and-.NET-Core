using System;
using System.Collections.Generic;
using System.Text;

namespace LSPExample
{
    public class TrueFalseQuestion : QuizQuestion
    {
        public override string Question { get; set; }
        public override string Answer1 { get { return "True"; } }
        public override string Answer2 { get { return "False"; } }
        public override string Answer3
        {
            get => "-";
        }
        public override string Answer4
        {
            get => "-";
        }
    }
}
