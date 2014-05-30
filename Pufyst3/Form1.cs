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

    public partial class Form1 : Form
    {
        double kfHealth = 1, kfNastroenie = 1;
        int Money = 50;

        public Form1()
        {
            InitializeComponent();
            Privetstvie secondForm = new Privetstvie();
            secondForm.Show();
            //LName.Text = Data.Name;
            LDay.Text = "День 1";
        }

        int Nastroenie = 60;
        int Health = 80;
        int CountTimeDay = 0, Day = 1, RandomDay = 0;
        int[] Dream = new int[3] { 0, 0, 5 };

        private void сменитьИмяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Privetstvie secondForm = new Privetstvie();
            secondForm.Show();
            LName.Text = Data.Name;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void пяченькиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Money < 5)
            {
                ErrorMoney secondForm = new ErrorMoney();
                secondForm.Show();
            }
            else
            {
                Data.Deistvie = 1;
                Data.Eat = 1;
                Health += (int)(10 / kfHealth);
                if (Health > 100)
                    Health = 100;
                Nastroenie += (int)(2 / kfNastroenie);
                if (Nastroenie > 100)
                    Nastroenie = 100;
                LHealth.Text = Health.ToString() + "%";
                LNastroenie.Text = Nastroenie.ToString() + "%";
                Game secondForm = new Game();
                secondForm.Show();
                Money -= 5;
                LMoney.Text = Money.ToString();
            }
        }

        private void маршмелоуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Money < 7)
            {
                ErrorMoney secondForm = new ErrorMoney();
                secondForm.Show();
            }
            else
            {
                Data.Deistvie = 1;
                Data.Eat = 2;
                Health += (int)(7 / kfHealth);
                if (Health > 100)
                    Health = 100;
                Nastroenie += (int)(3 / kfNastroenie);
                if (Nastroenie > 100)
                    Nastroenie = 100;
                LHealth.Text = Health.ToString() + "%";
                LNastroenie.Text = Nastroenie.ToString() + "%";
                Game secondForm = new Game();
                secondForm.Show();
                Money -= 7;
                LMoney.Text = Money.ToString();
            }
        }

        private void чайToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Money < 2)
            {
                ErrorMoney secondForm = new ErrorMoney();
                secondForm.Show();
            }
            else
            {
                Data.Deistvie = 1;
                Data.Eat = 3;
                Health += (int)(5 / kfHealth);
                if (Health > 100)
                    Health = 100;
                Nastroenie += (int)(1 / kfNastroenie);
                if (Nastroenie > 100)
                    Nastroenie = 100;
                LHealth.Text = Health.ToString() + "%";
                LNastroenie.Text = Nastroenie.ToString() + "%";
                Game secondForm = new Game();
                secondForm.Show();
                Money -= 2;
                LMoney.Text = Money.ToString();
            }
        }

        private void мячикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.Deistvie = 2;
            Data.Game = 1;
            Nastroenie += (int)(15/kfNastroenie);
            if (Nastroenie > 100)
                Nastroenie = 100;
            LNastroenie.Text = Nastroenie.ToString() + "%";
            Game secondForm = new Game();
            secondForm.Show();
            Money += 10;
            LMoney.Text = Money.ToString();
        }

        private void бантикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.Deistvie = 2;
            Data.Game = 2;
            Nastroenie += (int)(10/kfNastroenie);
            if (Nastroenie > 100)
                Nastroenie = 100;
            LNastroenie.Text = Nastroenie.ToString() + "%";
            Game secondForm = new Game();
            secondForm.Show();
            Money += 7;
            LMoney.Text = Money.ToString();
        }

        private void витаминыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Money < 20)
            {
                ErrorMoney secondForm = new ErrorMoney();
                secondForm.Show();
            }
            else
            {
                Data.Deistvie = 3;
                Data.Health = 1;
                Health += (int)(20 / kfHealth);
                if (Health > 100)
                    Health = 100;
                LHealth.Text = Health.ToString() + "%";
                Game secondForm = new Game();
                secondForm.Show();
                Money -= 20;
                LMoney.Text = Money.ToString();
            }
        }

        private void лекарстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.Deistvie = 3;
            Data.Health = 2;
            Health += (int)(10/kfHealth);
            if (Health > 100)
                Health = 100;
            LHealth.Text = Health.ToString() + "%";
            Game secondForm = new Game();
            secondForm.Show();
        }

        private void спать2МинутыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.Deistvie = 4;
            Data.Sleep = true;
            Health += (int)(30/kfHealth);
            if (Health > 100)
                Health = 100;
            Nastroenie += (int)(40/kfNastroenie);
            if (Nastroenie > 100)
                Nastroenie = 100;
            LHealth.Text = Health.ToString() + "%";
            LNastroenie.Text = Nastroenie.ToString() + "%";
            Game secondForm = new Game();
            secondForm.Show();
            Dream[0] = Dream[1];
            Dream[1] = Dream[2];
            Dream[2] = 2;
            if (Dream[1] + Dream[2] >= 5)
            {
                kfHealth = 1;
                kfNastroenie = 1;
            }
        }

        private void спать3МинутыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.Deistvie = 4;
            Data.Sleep= false;
            Health += (int)(50/kfHealth);
            if (Health > 100)
                Health = 100;
            Nastroenie += (int)(55/kfNastroenie);
            if (Nastroenie > 100)
                Nastroenie = 100;
            LHealth.Text = Health.ToString() + "%";
            LNastroenie.Text = Nastroenie.ToString() + "%";
            Game secondForm = new Game();
            secondForm.Show();
            Dream[0] = Dream[1];
            Dream[1] = Dream[2];
            Dream[2] = 3;
            if (Dream[1] + Dream[2] >= 5)
            {
                kfHealth = 1;
                kfNastroenie = 1;
            }
        }

        private void timerDay_Tick(object sender, EventArgs e)
        {
            CountTimeDay++;
            if (CountTimeDay == 120)
            {
                CountTimeDay = 0;
                Day++;
                LDay.Text = "День" + Day.ToString();
                Dream[0] = Dream[1];
                Dream[1] = Dream[2];
                Dream[2] = 0;
                if (Dream[1] + Dream[2] < 5)
                {
                    kfHealth = 1.3;
                    kfNastroenie = 1.5;
                }
                Random rand = new Random();
                Data.RandomMoney = rand.Next(1, 15);
                RandomDay = rand.Next(1, 3);
                if (RandomDay == 3)
                {
                    Money += Data.RandomMoney;
                    Money secondForm = new Money();
                    secondForm.Show();
                    LMoney.Text = Money.ToString();
                }
            }
            if (CountTimeDay % 12 == 0)
            {
                Health -= 5;
                Nastroenie -= 10;
                LHealth.Text = Health.ToString() + "%";
                LNastroenie.Text = Nastroenie.ToString() + "%";
            }
            if ((Health <= 0) || (Nastroenie <= 0))
            {
                End secondForm = new End();
                secondForm.Show();
                Health = 60;
                Nastroenie = 80;
                Day = 1;
                CountTimeDay = 0;
                LDay.Text = "День " + Day.ToString();
                LHealth.Text = Health.ToString() + "%";
                LNastroenie.Text = Nastroenie.ToString() + "%";
            }
            LTime.Text = (1 - CountTimeDay / 60).ToString() + ":" + (60 - CountTimeDay % 60).ToString();
        }
    }
}