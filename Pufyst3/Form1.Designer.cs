namespace Pufyst3
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьИмяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьЗановоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покормитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пяченькиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маршмелоуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чайToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поигратьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мячикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бантикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лечитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.витаминыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лекарстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спать2МинутыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спать3МинутыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LHealth = new System.Windows.Forms.Label();
            this.LNastroenie = new System.Windows.Forms.Label();
            this.timerDay = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.LTime = new System.Windows.Forms.Label();
            this.LDay = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LMoney = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.покормитьToolStripMenuItem,
            this.поигратьToolStripMenuItem,
            this.лечитьToolStripMenuItem,
            this.спатьToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(533, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьИмяToolStripMenuItem,
            this.начатьЗановоToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // сменитьИмяToolStripMenuItem
            // 
            this.сменитьИмяToolStripMenuItem.Name = "сменитьИмяToolStripMenuItem";
            this.сменитьИмяToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.сменитьИмяToolStripMenuItem.Text = "Сменить имя";
            this.сменитьИмяToolStripMenuItem.Click += new System.EventHandler(this.сменитьИмяToolStripMenuItem_Click);
            // 
            // начатьЗановоToolStripMenuItem
            // 
            this.начатьЗановоToolStripMenuItem.Name = "начатьЗановоToolStripMenuItem";
            this.начатьЗановоToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.начатьЗановоToolStripMenuItem.Text = "Начать заново";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // покормитьToolStripMenuItem
            // 
            this.покормитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пяченькиToolStripMenuItem,
            this.маршмелоуToolStripMenuItem,
            this.чайToolStripMenuItem});
            this.покормитьToolStripMenuItem.Name = "покормитьToolStripMenuItem";
            this.покормитьToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.покормитьToolStripMenuItem.Text = "Покормить";
            // 
            // пяченькиToolStripMenuItem
            // 
            this.пяченькиToolStripMenuItem.Name = "пяченькиToolStripMenuItem";
            this.пяченькиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.пяченькиToolStripMenuItem.Text = "Пяченьки";
            this.пяченькиToolStripMenuItem.Click += new System.EventHandler(this.пяченькиToolStripMenuItem_Click);
            // 
            // маршмелоуToolStripMenuItem
            // 
            this.маршмелоуToolStripMenuItem.Name = "маршмелоуToolStripMenuItem";
            this.маршмелоуToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.маршмелоуToolStripMenuItem.Text = "Маршмелоу";
            this.маршмелоуToolStripMenuItem.Click += new System.EventHandler(this.маршмелоуToolStripMenuItem_Click);
            // 
            // чайToolStripMenuItem
            // 
            this.чайToolStripMenuItem.Name = "чайToolStripMenuItem";
            this.чайToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.чайToolStripMenuItem.Text = "Чай";
            this.чайToolStripMenuItem.Click += new System.EventHandler(this.чайToolStripMenuItem_Click);
            // 
            // поигратьToolStripMenuItem
            // 
            this.поигратьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.мячикToolStripMenuItem,
            this.бантикToolStripMenuItem});
            this.поигратьToolStripMenuItem.Name = "поигратьToolStripMenuItem";
            this.поигратьToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.поигратьToolStripMenuItem.Text = "Поиграть";
            // 
            // мячикToolStripMenuItem
            // 
            this.мячикToolStripMenuItem.Name = "мячикToolStripMenuItem";
            this.мячикToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.мячикToolStripMenuItem.Text = "Мячик";
            this.мячикToolStripMenuItem.Click += new System.EventHandler(this.мячикToolStripMenuItem_Click);
            // 
            // бантикToolStripMenuItem
            // 
            this.бантикToolStripMenuItem.Name = "бантикToolStripMenuItem";
            this.бантикToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.бантикToolStripMenuItem.Text = "Бантик";
            this.бантикToolStripMenuItem.Click += new System.EventHandler(this.бантикToolStripMenuItem_Click);
            // 
            // лечитьToolStripMenuItem
            // 
            this.лечитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.витаминыToolStripMenuItem,
            this.лекарстваToolStripMenuItem});
            this.лечитьToolStripMenuItem.Name = "лечитьToolStripMenuItem";
            this.лечитьToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.лечитьToolStripMenuItem.Text = "Лечить";
            // 
            // витаминыToolStripMenuItem
            // 
            this.витаминыToolStripMenuItem.Name = "витаминыToolStripMenuItem";
            this.витаминыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.витаминыToolStripMenuItem.Text = "Витамины";
            this.витаминыToolStripMenuItem.Click += new System.EventHandler(this.витаминыToolStripMenuItem_Click);
            // 
            // лекарстваToolStripMenuItem
            // 
            this.лекарстваToolStripMenuItem.Name = "лекарстваToolStripMenuItem";
            this.лекарстваToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.лекарстваToolStripMenuItem.Text = "Лекарства";
            this.лекарстваToolStripMenuItem.Click += new System.EventHandler(this.лекарстваToolStripMenuItem_Click);
            // 
            // спатьToolStripMenuItem
            // 
            this.спатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.спать2МинутыToolStripMenuItem,
            this.спать3МинутыToolStripMenuItem});
            this.спатьToolStripMenuItem.Name = "спатьToolStripMenuItem";
            this.спатьToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.спатьToolStripMenuItem.Text = "Спать";
            // 
            // спать2МинутыToolStripMenuItem
            // 
            this.спать2МинутыToolStripMenuItem.Name = "спать2МинутыToolStripMenuItem";
            this.спать2МинутыToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.спать2МинутыToolStripMenuItem.Text = "Спать 2 минуты";
            this.спать2МинутыToolStripMenuItem.Click += new System.EventHandler(this.спать2МинутыToolStripMenuItem_Click);
            // 
            // спать3МинутыToolStripMenuItem
            // 
            this.спать3МинутыToolStripMenuItem.Name = "спать3МинутыToolStripMenuItem";
            this.спать3МинутыToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.спать3МинутыToolStripMenuItem.Text = "Спать 3 минуты";
            this.спать3МинутыToolStripMenuItem.Click += new System.EventHandler(this.спать3МинутыToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(210, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 113);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(393, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Настроение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Здоровье";
            // 
            // LHealth
            // 
            this.LHealth.AutoSize = true;
            this.LHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LHealth.Location = new System.Drawing.Point(62, 141);
            this.LHealth.Name = "LHealth";
            this.LHealth.Size = new System.Drawing.Size(36, 17);
            this.LHealth.TabIndex = 4;
            this.LHealth.Text = "80%";
            // 
            // LNastroenie
            // 
            this.LNastroenie.AutoSize = true;
            this.LNastroenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LNastroenie.Location = new System.Drawing.Point(430, 141);
            this.LNastroenie.Name = "LNastroenie";
            this.LNastroenie.Size = new System.Drawing.Size(36, 17);
            this.LNastroenie.TabIndex = 5;
            this.LNastroenie.Text = "60%";
            // 
            // timerDay
            // 
            this.timerDay.Enabled = true;
            this.timerDay.Interval = 1000;
            this.timerDay.Tick += new System.EventHandler(this.timerDay_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "До конца дня осталось";
            // 
            // LTime
            // 
            this.LTime.AutoSize = true;
            this.LTime.Location = new System.Drawing.Point(467, 242);
            this.LTime.Name = "LTime";
            this.LTime.Size = new System.Drawing.Size(34, 13);
            this.LTime.TabIndex = 7;
            this.LTime.Text = "10:00";
            // 
            // LDay
            // 
            this.LDay.AutoSize = true;
            this.LDay.Location = new System.Drawing.Point(245, 38);
            this.LDay.Name = "LDay";
            this.LDay.Size = new System.Drawing.Size(43, 13);
            this.LDay.TabIndex = 8;
            this.LDay.Text = "День 1";
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LName.Location = new System.Drawing.Point(239, 212);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(54, 15);
            this.LName.TabIndex = 9;
            this.LName.Text = "Пуфыст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Осталось денег";
            // 
            // LMoney
            // 
            this.LMoney.AutoSize = true;
            this.LMoney.Location = new System.Drawing.Point(107, 242);
            this.LMoney.Name = "LMoney";
            this.LMoney.Size = new System.Drawing.Size(19, 13);
            this.LMoney.TabIndex = 11;
            this.LMoney.Text = "50";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 264);
            this.Controls.Add(this.LMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.LDay);
            this.Controls.Add(this.LTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LNastroenie);
            this.Controls.Add(this.LHealth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = " ";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LHealth;
        private System.Windows.Forms.Label LNastroenie;
        private System.Windows.Forms.Timer timerDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LTime;
        private System.Windows.Forms.Label LDay;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.ToolStripMenuItem сменитьИмяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьЗановоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покормитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пяченькиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маршмелоуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чайToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поигратьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мячикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бантикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лечитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem витаминыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лекарстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem спатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem спать2МинутыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem спать3МинутыToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LMoney;
    }
}

