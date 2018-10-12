using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Dndoer
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int key);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hwnd, int id);
        const int mActionHotKeyID = 1;

        Random rnd = new Random();
        bool stayTop = false;
        private Timer timer1;
        public Form1()
        {
            InitializeComponent();
            InitTimer();
        }

        private void roll()
        {
            string reg = "([\\+|\\-| ])";
            string[] dice = Regex.Split(DiceInput.Text, reg);

            int temp = 0;
            int result = 0;
            int operation = 0; // 0 is add, 1 is sub

            errorMsg.Text = "";
            errorMsg.ForeColor = System.Drawing.Color.Maroon;

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
                    int[] die = { 0,0 };
                    if (int.TryParse(dieArray[0], out die[0]) & int.TryParse(dieArray[1], out die[1]))
                    {
                        temp = rnd.Next(die[0], (die[0] * die[1])+1);
                    } else
                    {
                        errorMsg.Text = "Error: " + clean + " is invalid.\nEvaluating as 0.";
                        temp = 0;
                    }

                } else if (Regex.Match(clean, reg).Success) // If it's an operation
                {
                    // Set the operation
                    if (clean == "+") { operation = 0;  }
                    else if (clean == "-") { operation = 1; }
                    else { operation = 0; }
                    temp = 0;
                } else
                {
                    // Ignore any broken input
                    errorMsg.Text = "Error:" + clean + "is invalid.";
                    temp = 0;
                }
            }

            // Run the operation one last time
            if (operation == 0) { result += temp; }
            else if (operation == 1) { result -= temp; }

            resultD20.Text = result.ToString();
        }

        private void d20RollBttn_Click(object sender, EventArgs e)
        {
            roll();
        }

            private void d20Image_Click(object sender, EventArgs e)
        {
            
            if (DiceInput.Text == "1d20+2")
            {
                DiceInput.Text = "1d20";
            } else
            {
                DiceInput.Text = "1d20+2";
            }
        }

        private void resultD20_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
        }

        private void Form1_keypress(object sender, KeyEventArgs e)
        {
            var t = new Timer();

            errorMsg.ForeColor = System.Drawing.Color.Black;
            t.Interval = 1000; // it will Tick in 1 second
            t.Tick += (s, i) =>
            {
                errorMsg.Text = "";
                t.Stop();
            };

            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Space)
            {
                roll();

            } else if (e.KeyCode == Keys.Escape)
            {
                this.Close();

            } else if (e.KeyCode == Keys.F1)
            {
                stayTop = !stayTop;

                if (stayTop)
                {
                    RegisterHotKey(this.Handle, mActionHotKeyID, 0, (int)Keys.F11);
                }
                else
                {
                    UnregisterHotKey(this.Handle, mActionHotKeyID);
                }

                errorMsg.ForeColor = System.Drawing.Color.Black;
                errorMsg.Text = "Top lock toggled " + stayTop;
                t.Start();
            }
            else if (e.KeyCode == Keys.F2)
            {
                FormBorderStyle a = System.Windows.Forms.FormBorderStyle.None;
                FormBorderStyle b = System.Windows.Forms.FormBorderStyle.FixedSingle;
                
                if (this.FormBorderStyle == a)
                {
                    this.FormBorderStyle = b;
                } else
                {
                    this.FormBorderStyle = a;
                }
                errorMsg.Text = "Title bar toggled";
                t.Start();
            }
            else if (e.KeyCode == Keys.F12)
            {
                errorMsg.Text = "J. Butler";
                t.Start();
            }

        }

        private void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(t1_Tick);
            timer1.Interval = 500;
            timer1.Start();
        }

        private void t1_Tick(object sender, EventArgs e)
        {
            this.TopMost = stayTop;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == mActionHotKeyID)
            {
                // Do global keybind
                roll();
            }
            base.WndProc(ref m);
        }
    }
}
