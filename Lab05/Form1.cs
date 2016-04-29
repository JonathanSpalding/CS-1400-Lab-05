// Author: Jonathan Spalding
// Assignment: Lab 05
// Instructor "Roger deBry
// Clas: CS 1400
// Date Written: 1/21/2016
//----------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // The exitToolStripMenuItem1_Clic Method
        // Purpose: Display a pop up box when you click About
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // The aboutToolStripMenuItem_Clic Method
        // Purpose: Display a pop up box when you click About
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jonathan Spalding/nCS1400/nLab #5");
        }
        // The inTxtBox_Leave Method
        // Purpose: take a number, convert it from a string to an integer, double it, and then convert it back to a string
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void InTextBox_Leave(object sender, EventArgs e)
        {
            const int DOUBLE = 2;
            int num = int.Parse(inTextBox.Text);
            int doubleNum = num * DOUBLE;
            string outStr = $"{doubleNum:D}";
            outTextBox.Text = outStr;
        }
    }
}
