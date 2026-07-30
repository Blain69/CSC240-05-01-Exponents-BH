using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name:Blaine Hazelip
 * Date:7/30/26
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:
 *************************************/

namespace Exponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xGoButton_Click(object sender, EventArgs e)
        {
            int number;
            int squared;
            int cubed;

            // INPUT
            number = int.Parse(xInputTextBox.Text);

            // PROCESS
            squared = Square(number);
            cubed = Cube(number);

            // OUTPUT
            MessageBox.Show($"Square: {squared}\nCube: {cubed}");

            // turn the Go button off
            xGoButton.Enabled = false;
        }

        public int Square(int num)
        {
            return num * num;
        }

        public int Cube(int num)
        {
            return num * num * num;
        }

        private void xResetButton_Click(object sender, EventArgs e)
        {
            xInputTextBox.Clear();
            xGoButton.Enabled = true;
        }

        private void xInputLabel_Click(object sender, EventArgs e)
        {

        }

        private void xInputTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
