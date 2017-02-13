using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class GradeBook
    {
        public string courseName { get; set; }
        private GradeBookTest mainForm;

        // Constructor
        public GradeBook(GradeBookTest mainForm)
        {
            this.mainForm = mainForm;
        }

        // Append message to the messages list
        public void DisplayMessage()
        {
            mainForm.AddMessage(string.Format("Welcome to the grade book for: {0}", this.courseName));
        }
    }
}
