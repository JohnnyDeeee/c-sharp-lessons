using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeBook
{
    public partial class GradeBookTest : Form
    {
        private GradeBook gradeBook;
        private List<string> questions = new List<string>();
        private int currentQuestionIndex = 0;

        public GradeBookTest()
        {
            InitializeComponent();

            // Initialize GradeBook class
            this.gradeBook = new GradeBook(this);

            // Initialize questions
            questions.Add("Welcome to the Grade Book app!");
            questions.Add("");
            questions.Add("Please enter a course name...");

            // Send welcome messages
            for (int i = 0; i < 3; i++)
                NextQuestion();
        }

        // Send message button
        private void buttonSend_Click(object sender, EventArgs e)
        {
            HandleAnswer(textMessage.Text);
        }

        // Add next question in the list
        private void NextQuestion()
        {
            try
            {
                listMessages.Items.Add(questions[currentQuestionIndex++]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Wrong index given for questions list!");
                Console.WriteLine(e.Message);
            }
        }

        // Handle answer
        private void HandleAnswer(string answer)
        {
            switch (currentQuestionIndex-1)
            {
                case 2: // Please enter a course name...
                    this.gradeBook.courseName = answer;
                    answer = "Selected course: " + answer;
                    break;
                default:
                    break;
            }

            AddMessage(answer);
            textMessage.Clear();
        }
        
        // Add message to messages list
        public void AddMessage(string message)
        {
            this.listMessages.Items.Add(message);
        }
    }
}
