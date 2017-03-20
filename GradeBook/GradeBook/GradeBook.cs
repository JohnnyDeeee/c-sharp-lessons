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
        int countA;
        int countB;
        int countC;
        int countD;
        int countF;

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

        public double Average(int[] grades)
        {
            int total = 0;
            int gradeCounter = 0;
            foreach (var grade in grades)
            {
                total += grade;
                gradeCounter++;

                switch (grade/10)
                {
                    case 9:
                    case 10:
                        countA++;
                        break;
                    case 8:
                        countB++;
                        break;
                    case 7:
                        countC++;
                        break;
                    case 6:
                        countD++;
                        break;
                    default:
                        countF++;
                        break;
                }
            }

            return (double) total / gradeCounter;
            
        }
    }
}
