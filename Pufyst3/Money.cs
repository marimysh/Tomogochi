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
    public partial class Money : Form
    {
        public Money()
        {
            InitializeComponent();
            label1.Text = "Сегодня пуфыст получает " + Data.RandomMoney + " монет в подарок!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
