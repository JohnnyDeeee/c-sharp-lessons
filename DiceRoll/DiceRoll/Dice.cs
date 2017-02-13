using DiceRoll.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoll
{
    class Dice
    {
        private Random rand;
        private List<Bitmap> sides = new List<Bitmap>();
        private DiceTest mainForm;

        public Dice(DiceTest mainForm)
        {
            this.rand = new Random();
            this.mainForm = mainForm;

            // Setup image for all 6 sides
            sides.Add(Resources.side_1);
            sides.Add(Resources.side_2);
            sides.Add(Resources.side_3);
            sides.Add(Resources.side_4);
            sides.Add(Resources.side_5);
            sides.Add(Resources.side_6);
        }

        // Will roll the dice and shows result
        // TODO: Run on different thread
        public void RollDice()
        {
            string originalButtonText = mainForm.getButtonRoll.Text;

            // Disable roll button and change text
            //mainForm.getButtonRoll.Text = "Rolling...";
            mainForm.Invoke((MethodInvoker)delegate 
            {
                mainForm.getButtonRoll.Text = "Rolling...";
                mainForm.getButtonRoll.Enabled = false;
            });

            // Calc result first
            int result = rand.Next(1, 7);
            Console.WriteLine("Result: " + result);

            // Start animation
            int animationLength = 20;
            for (int i = 0; i < animationLength; i++)
            {
                int side = rand.Next(1,7);
                mainForm.Invoke((MethodInvoker)delegate
                {
                    mainForm.getPictureDice.BackgroundImage = sides[side - 1];
                });
                Thread.Sleep(100);
            }

            // Show the result image and enable button
            mainForm.Invoke((MethodInvoker)delegate
            {
                mainForm.getPictureDice.BackgroundImage = sides[result - 1];
                mainForm.getButtonRoll.Text = originalButtonText;
                mainForm.getButtonRoll.Enabled = true;
            });
        }
    }
}
