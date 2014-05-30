using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pufyst3
{
    public partial class Privetstvie : Form
    {
        public Privetstvie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.Name = textBox1.Text;
            Close();
        }
    }
}
