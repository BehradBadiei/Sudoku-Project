namespace Sudoku
{
    partial class Rock_paper_scissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rock_paper_scissors));
            this.Player_pick = new System.Windows.Forms.PictureBox();
            this.Cpu_pick = new System.Windows.Forms.PictureBox();
            this.Rock_btn = new System.Windows.Forms.Button();
            this.Paper_btn = new System.Windows.Forms.Button();
            this.Scissors_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textScore = new System.Windows.Forms.Label();
            this.textCountdown = new System.Windows.Forms.Label();
            this.textRound = new System.Windows.Forms.Label();
            this.Restart_btn = new System.Windows.Forms.Button();
            this.CountdownTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Player_pick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cpu_pick)).BeginInit();
            this.SuspendLayout();
            // 
            // Player_pick
            // 
            this.Player_pick.Image = global::Sudoku.Properties.Resources.qq;
            this.Player_pick.Location = new System.Drawing.Point(154, 51);
            this.Player_pick.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Player_pick.Name = "Player_pick";
            this.Player_pick.Size = new System.Drawing.Size(161, 142);
            this.Player_pick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player_pick.TabIndex = 0;
            this.Player_pick.TabStop = false;
            // 
            // Cpu_pick
            // 
            this.Cpu_pick.Image = global::Sudoku.Properties.Resources.qq;
            this.Cpu_pick.Location = new System.Drawing.Point(508, 51);
            this.Cpu_pick.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cpu_pick.Name = "Cpu_pick";
            this.Cpu_pick.Size = new System.Drawing.Size(161, 142);
            this.Cpu_pick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cpu_pick.TabIndex = 1;
            this.Cpu_pick.TabStop = false;
            // 
            // Rock_btn
            // 
            this.Rock_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rock_btn.Font = new System.Drawing.Font("Mj_Graphic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Rock_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Rock_btn.Location = new System.Drawing.Point(14, 51);
            this.Rock_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Rock_btn.Name = "Rock_btn";
            this.Rock_btn.Size = new System.Drawing.Size(88, 25);
            this.Rock_btn.TabIndex = 2;
            this.Rock_btn.Text = "Rock";
            this.Rock_btn.UseVisualStyleBackColor = false;
            this.Rock_btn.Click += new System.EventHandler(this.Rock_btn_Click);
            // 
            // Paper_btn
            // 
            this.Paper_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Paper_btn.Font = new System.Drawing.Font("Mj_Graphic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Paper_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Paper_btn.Location = new System.Drawing.Point(14, 110);
            this.Paper_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Paper_btn.Name = "Paper_btn";
            this.Paper_btn.Size = new System.Drawing.Size(88, 25);
            this.Paper_btn.TabIndex = 3;
            this.Paper_btn.Text = "Paper";
            this.Paper_btn.UseVisualStyleBackColor = false;
            this.Paper_btn.Click += new System.EventHandler(this.Paper_btn_Click);
            // 
            // Scissors_btn
            // 
            this.Scissors_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Scissors_btn.Font = new System.Drawing.Font("Mj_Graphic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Scissors_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Scissors_btn.Location = new System.Drawing.Point(14, 169);
            this.Scissors_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Scissors_btn.Name = "Scissors_btn";
            this.Scissors_btn.Size = new System.Drawing.Size(88, 25);
            this.Scissors_btn.TabIndex = 4;
            this.Scissors_btn.Text = "Scissors";
            this.Scissors_btn.UseVisualStyleBackColor = false;
            this.Scissors_btn.Click += new System.EventHandler(this.Scissors_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(573, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "CPU";
            // 
            // textScore
            // 
            this.textScore.AutoSize = true;
            this.textScore.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textScore.Location = new System.Drawing.Point(354, 62);
            this.textScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(95, 14);
            this.textScore.TabIndex = 7;
            this.textScore.Text = "Player: 0 - CPU: 0";
            // 
            // textCountdown
            // 
            this.textCountdown.AutoSize = true;
            this.textCountdown.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCountdown.Location = new System.Drawing.Point(401, 110);
            this.textCountdown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textCountdown.Name = "textCountdown";
            this.textCountdown.Size = new System.Drawing.Size(13, 14);
            this.textCountdown.TabIndex = 8;
            this.textCountdown.Text = "5";
            // 
            // textRound
            // 
            this.textRound.AutoSize = true;
            this.textRound.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRound.Location = new System.Drawing.Point(382, 211);
            this.textRound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textRound.Name = "textRound";
            this.textRound.Size = new System.Drawing.Size(54, 14);
            this.textRound.TabIndex = 10;
            this.textRound.Text = "Round: 3";
            // 
            // Restart_btn
            // 
            this.Restart_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Restart_btn.Location = new System.Drawing.Point(640, 253);
            this.Restart_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Restart_btn.Name = "Restart_btn";
            this.Restart_btn.Size = new System.Drawing.Size(88, 25);
            this.Restart_btn.TabIndex = 11;
            this.Restart_btn.Text = "Restart";
            this.Restart_btn.UseVisualStyleBackColor = false;
            this.Restart_btn.Click += new System.EventHandler(this.Restart_btn_Click);
            // 
            // CountdownTimer
            // 
            this.CountdownTimer.Interval = 1000;
            this.CountdownTimer.Tick += new System.EventHandler(this.CountDownTimer_Event);
            // 
            // Rock_paper_scissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 300);
            this.Controls.Add(this.Restart_btn);
            this.Controls.Add(this.textRound);
            this.Controls.Add(this.textCountdown);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Scissors_btn);
            this.Controls.Add(this.Paper_btn);
            this.Controls.Add(this.Rock_btn);
            this.Controls.Add(this.Cpu_pick);
            this.Controls.Add(this.Player_pick);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Rock_paper_scissors";
            this.Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.Player_pick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cpu_pick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player_pick;
        private System.Windows.Forms.PictureBox Cpu_pick;
        private System.Windows.Forms.Button Rock_btn;
        private System.Windows.Forms.Button Paper_btn;
        private System.Windows.Forms.Button Scissors_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label textScore;
        private System.Windows.Forms.Label textCountdown;
        private System.Windows.Forms.Label textRound;
        private System.Windows.Forms.Button Restart_btn;
        private System.Windows.Forms.Timer CountdownTimer;
    }
}