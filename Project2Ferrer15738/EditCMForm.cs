﻿// FERRER, Carlo Ram M. 
// 151738
// December 5, 2016
// I have not discussed the C# language code in my program
// with anyone other than my instructor or the teaching assistants assigned to this
// course. I have not used C# language code obtained from
// another person, or any other unauthorized source, either modified or unmodified.
// Any C# language code or documentation used in my program
// that was obtained from another source, such as a text book, a web page,
// or another person, have been clearly noted with proper citation in the
// comments of my program.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2Ferrer15738
{
    public partial class EditCMForm : Form
    {
        public EditCMForm()
        {
            InitializeComponent();
        }

        private void EditCMForm_Load(object sender, EventArgs e)
        {

        }
        public int GetCost()
        {
            return int.Parse(CTbox.Text);
        }
        public int GetMultiplier()
        {
            return int.Parse(MTbox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
