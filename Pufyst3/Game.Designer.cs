namespace Pufyst3
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.PBPufyst = new System.Windows.Forms.PictureBox();
            this.PBDeistvie = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PBPufyst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBDeistvie)).BeginInit();
            this.SuspendLayout();
            // 
            // PBPufyst
            // 
            this.PBPufyst.Image = ((System.Drawing.Image)(resources.GetObject("PBPufyst.Image")));
            this.PBPufyst.Location = new System.Drawing.Point(16, 22);
            this.PBPufyst.Name = "PBPufyst";
            this.PBPufyst.Size = new System.Drawing.Size(113, 113);
            this.PBPufyst.TabIndex = 0;
            this.PBPufyst.TabStop = false;
            // 
            // PBDeistvie
            // 
            this.PBDeistvie.Image = ((System.Drawing.Image)(resources.GetObject("PBDeistvie.Image")));
            this.PBDeistvie.Location = new System.Drawing.Point(217, 22);
            this.PBDeistvie.Name = "PBDeistvie";
            this.PBDeistvie.Size = new System.Drawing.Size(113, 113);
            this.PBDeistvie.TabIndex = 1;
            this.PBDeistvie.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Осталось";
            // 
            // LTime
            // 
            this.LTime.AutoSize = true;
            this.LTime.Location = new System.Drawing.Point(160, 88);
            this.LTime.Name = "LTime";
            this.LTime.Size = new System.Drawing.Size(22, 13);
            this.LTime.TabIndex = 3;
            this.LTime.Text = "0:0";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 156);
            this.ControlBox = false;
            this.Controls.Add(this.LTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PBDeistvie);
            this.Controls.Add(this.PBPufyst);
            this.Name = "Game";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.PBPufyst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBDeistvie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBPufyst;
        private System.Windows.Forms.PictureBox PBDeistvie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LTime;
        private System.Windows.Forms.Timer timer;
    }
}