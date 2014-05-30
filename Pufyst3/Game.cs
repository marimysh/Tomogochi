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
    public partial class Game : Form
    {
        int time;
        public Game()
        {
            InitializeComponent();
            switch (Data.Deistvie)
            {
                case 1 : 
                switch (Data.Eat)
                {
                    case 1: 
                        Bitmap a = new Bitmap(@"C:\Documents and Settings\Maya\Мои документы\Marina\инст\ПИ\Pufyst3\Pufyst3\Properties\пяченько.jpg");
                        PBDeistvie.Image = a;
                        PBDeistvie.Update();
                        time = 30;
                        break;
                    case 2: 
                        Bitmap b = new Bitmap(@"C:\Documents and Settings\Maya\Мои документы\Marina\инст\ПИ\Pufyst3\Pufyst3\Properties\мармш.jpg");
                        PBDeistvie.Image = b;
                        PBDeistvie.Update();
                        time = 30;
                        break;
                    case 3: 
                        Bitmap c = new Bitmap(@"C:\Documents and Settings\Maya\Мои документы\Marina\инст\ПИ\Pufyst3\Pufyst3\Properties\чай.jpg");
                        PBDeistvie.Image = c;
                        PBDeistvie.Update();
                        time = 20;
                        break;
                } break;
                case 2 : 
                    switch (Data.Game)
                {
                    case 1:
                        Bitmap d = new Bitmap(@"C:\Documents and Settings\Maya\Мои документы\Marina\инст\ПИ\Pufyst3\Pufyst3\Properties\мяч.jpg");
                        PBDeistvie.Image = d;
                        PBDeistvie.Update();
                        time = 20;
                        break;
                    case 2: 
                        Bitmap e = new Bitmap(@"C:\Documents and Settings\Maya\Мои документы\Marina\инст\ПИ\Pufyst3\Pufyst3\Properties\бантик.jpg");
                        PBDeistvie.Image = e;
                        PBDeistvie.Update();
                        time = 15;
                        break;
                } break;
                case 3 : 
                    switch (Data.Health)
                {
                    case 1: 
                        Bitmap f = new Bitmap(@"C:\Documents and Settings\Maya\Мои документы\Marina\инст\ПИ\Pufyst3\Pufyst3\Properties\лечение.jpg");
                        PBDeistvie.Image = f;
                        PBDeistvie.Update();
                        time = 40;
                        break;
                    case 2: 
                        Bitmap g = new Bitmap(@"C:\Documents and Settings\Maya\Мои документы\Marina\инст\ПИ\Pufyst3\Pufyst3\Properties\лечение.jpg");
                        PBDeistvie.Image = g;
                        PBDeistvie.Update();
                        time = 20;
                        break;
                } break;
                case 4 :
                    switch (Data.Sleep)
                    {
                        case true:
                            Bitmap h = new Bitmap(@"C:\Documents and Settings\Maya\Мои документы\Marina\инст\ПИ\Pufyst3\Pufyst3\Properties\сон.jpg");
                        PBDeistvie.Image = h;
                        PBDeistvie.Update();
                            time = 120;
                            break;
                        case false:
                            Bitmap j = new Bitmap(@"C:\Documents and Settings\Maya\Мои документы\Marina\инст\ПИ\Pufyst3\Pufyst3\Properties\сон.jpg");
                        PBDeistvie.Image = j;
                        PBDeistvie.Update();
                            time = 180;
                            break;
                    }break;                    
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time--;
            if (time == 0)
                Close();
            LTime.Text = (time / 60).ToString() + ":" + (time % 60).ToString();
        }
    }
}