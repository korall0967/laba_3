using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace laba_3
{
    public partial class Form2 : Form
    {
        public string MarkerName;
        public double MarkerV;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MarkerName = textBox1.Text;
            MarkerV = (double)numericUpDown1.Value;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
