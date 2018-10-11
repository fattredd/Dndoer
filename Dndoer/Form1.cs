using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Dndoer
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void d20RollBttn_Click(object sender, EventArgs e)
        {
            string reg = "([\\+|\\-| ])";
            string[] dice = Regex.Split(DiceInput.Text, reg);

            int temp = 0;
            int result = 0;
            int operation = 0; // 0 is add, 1 is sub

            foreach (string item in dice)
            {
                // Run the operation
                if (operation == 0) { result += temp; }
                else if (operation == 1) { result -= temp; }

                string clean = item.Trim();
                if (int.TryParse(clean, out temp)) // If it's a number
                {
                    // Then that's what it is

                } else if (clean.IndexOf('d') != -1) // If it's a dice roll
                {
                    // Roll the dice
                    string[] dieArray = clean.Split('d');
                    dieArray[0] = (dieArray[0] == "" ? "1" : dieArray[0]);
                    int[] die = Array.ConvertAll(dieArray, num => int.Parse(num));

                    int maxNum = (int)die[1] * die[0];
                    int minNum = (int)die[0];
                    temp = rnd.Next(minNum, maxNum);

                } else if (Regex.Match(clean, reg).Success) // If it's an operation
                {
                    // Set the operation
                    if (clean == "+") { operation = 0;  }
                    else if (clean == "-") { operation = 1; }
                    else { operation = 0; }
                    temp = 0;
                }
                Console.WriteLine(temp);
            }

            // Run the operation one last time
            if (operation == 0) { result += temp; }
            else if (operation == 1) { result -= temp; }

            resultD20.Text = result.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (DiceInput.Text == "1d20+2")
            {
                DiceInput.Text = "1d20";
            } else
            {
                DiceInput.Text = "1d20+2";
            }
        }
    }
}
