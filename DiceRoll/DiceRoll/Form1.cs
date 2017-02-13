using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoll
{
    public partial class DiceTest : Form
    {
        public PictureBox getPictureDice { get { return this.pictureDice; } }
        public Button getButtonRoll { get { return this.buttonRoll; } }
        private Dice dice;

        public DiceTest()
        {
            InitializeComponent();

            // Initialize dice class
            this.dice = new Dice(this);
        }

        // Roll dice button
        private void buttonRoll_Click(object sender, EventArgs e)
        {
            // Start new thread and start dice roll
            Thread diceThread = new Thread(new ThreadStart(dice.RollDice));
            diceThread.Start();
        }
    }
}
