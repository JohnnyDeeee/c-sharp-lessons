namespace DiceRoll
{
    partial class DiceTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRoll = new System.Windows.Forms.Button();
            this.pictureDice = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDice)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRoll
            // 
            this.buttonRoll.Location = new System.Drawing.Point(12, 294);
            this.buttonRoll.Name = "buttonRoll";
            this.buttonRoll.Size = new System.Drawing.Size(286, 69);
            this.buttonRoll.TabIndex = 0;
            this.buttonRoll.Text = "Roll dice!";
            this.buttonRoll.UseVisualStyleBackColor = true;
            this.buttonRoll.Click += new System.EventHandler(this.buttonRoll_Click);
            // 
            // pictureDice
            // 
            this.pictureDice.BackColor = System.Drawing.Color.White;
            this.pictureDice.BackgroundImage = global::DiceRoll.Properties.Resources.side_6;
            this.pictureDice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureDice.Location = new System.Drawing.Point(12, 12);
            this.pictureDice.Name = "pictureDice";
            this.pictureDice.Size = new System.Drawing.Size(286, 276);
            this.pictureDice.TabIndex = 1;
            this.pictureDice.TabStop = false;
            // 
            // DiceTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(310, 375);
            this.Controls.Add(this.pictureDice);
            this.Controls.Add(this.buttonRoll);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "DiceTest";
            this.ShowIcon = false;
            this.Text = "Dice Roll";
            ((System.ComponentModel.ISupportInitialize)(this.pictureDice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRoll;
        private System.Windows.Forms.PictureBox pictureDice;
    }
}

