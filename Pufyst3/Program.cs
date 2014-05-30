using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Pufyst3
{
    static class Data
    {
        public static String Name;
        public static int Deistvie;             //1,2,3,4  - есть, играть, лечиться, спать
        public static int Eat;
        public static int Game;
        public static int Health;
        public static bool Sleep;
        public static int RandomMoney;
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
