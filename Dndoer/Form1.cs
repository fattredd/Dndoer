using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            int maxNum = (int)qtD20.Value * 20;
            int minNum = (int)qtD20.Value;
            resultD20.Text = rnd.Next(minNum, maxNum).ToString();
        }
    }
}
