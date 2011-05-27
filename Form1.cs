using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace passwordGenerator
{
    public partial class Form1 : Form
    {
        Random random;
        public Form1()
        {
            random = new Random();
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
            for (int i = 0; i < nudLen.Value; i++)
            {
                txtPass.Text += (char)random.Next(33, 126);
            }
        }
    }
}
