namespace PuzzleGame
{
    partial class Form1
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
            this.gbPuzzle = new System.Windows.Forms.GroupBox();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMoves = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbOriginal = new System.Windows.Forms.GroupBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.gbPuzzle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPuzzle
            // 
            this.gbPuzzle.Controls.Add(this.btn7);
            this.gbPuzzle.Controls.Add(this.btn8);
            this.gbPuzzle.Controls.Add(this.btn9);
            this.gbPuzzle.Controls.Add(this.btn6);
            this.gbPuzzle.Controls.Add(this.btn3);
            this.gbPuzzle.Controls.Add(this.btn5);
            this.gbPuzzle.Controls.Add(this.btn4);
            this.gbPuzzle.Controls.Add(this.btn2);
            this.gbPuzzle.Controls.Add(this.btn1);
            this.gbPuzzle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPuzzle.Location = new System.Drawing.Point(5, 12);
            this.gbPuzzle.Name = "gbPuzzle";
            this.gbPuzzle.Size = new System.Drawing.Size(521, 717);
            this.gbPuzzle.TabIndex = 0;
            this.gbPuzzle.TabStop = false;
            this.gbPuzzle.Text = "Puzzle Box";
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.Color.Cornsilk;
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShuffle.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.ForeColor = System.Drawing.Color.Black;
            this.btnShuffle.Location = new System.Drawing.Point(645, 700);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(161, 77);
            this.btnShuffle.TabIndex = 2;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Cornsilk;
            this.btnPause.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPause.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.Black;
            this.btnPause.Location = new System.Drawing.Point(645, 593);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(161, 77);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Tahoma", 52.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Green;
            this.lblTimer.Location = new System.Drawing.Point(599, 436);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(264, 105);
            this.lblTimer.TabIndex = 6;
            this.lblTimer.Text = "00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(4, 749);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Moves Made:";
            // 
            // lblMoves
            // 
            this.lblMoves.AutoSize = true;
            this.lblMoves.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoves.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMoves.Location = new System.Drawing.Point(217, 751);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(34, 36);
            this.lblMoves.TabIndex = 8;
            this.lblMoves.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbOriginal
            // 
            this.gbOriginal.BackgroundImage = global::PuzzleGame.Properties.Resources.R__1_;
            this.gbOriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbOriginal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOriginal.Location = new System.Drawing.Point(584, 12);
            this.gbOriginal.Name = "gbOriginal";
            this.gbOriginal.Size = new System.Drawing.Size(290, 396);
            this.gbOriginal.TabIndex = 1;
            this.gbOriginal.TabStop = false;
            this.gbOriginal.Text = "Original";
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Black;
            this.btn7.Image = global::PuzzleGame.Properties.Resources.pic7;
            this.btn7.Location = new System.Drawing.Point(1, 482);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(176, 230);
            this.btn7.TabIndex = 8;
            this.btn7.Tag = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Black;
            this.btn8.Image = global::PuzzleGame.Properties.Resources.pic8;
            this.btn8.Location = new System.Drawing.Point(172, 482);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(176, 230);
            this.btn8.TabIndex = 5;
            this.btn8.Tag = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Black;
            this.btn9.Image = global::PuzzleGame.Properties.Resources.pic9;
            this.btn9.Location = new System.Drawing.Point(343, 482);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(176, 230);
            this.btn9.TabIndex = 2;
            this.btn9.Tag = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Black;
            this.btn6.Image = global::PuzzleGame.Properties.Resources.pic6;
            this.btn6.Location = new System.Drawing.Point(343, 255);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(176, 230);
            this.btn6.TabIndex = 7;
            this.btn6.Tag = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Black;
            this.btn3.Image = global::PuzzleGame.Properties.Resources.pic3;
            this.btn3.Location = new System.Drawing.Point(343, 28);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(176, 230);
            this.btn3.TabIndex = 6;
            this.btn3.Tag = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Black;
            this.btn5.Image = global::PuzzleGame.Properties.Resources.pic5;
            this.btn5.Location = new System.Drawing.Point(172, 255);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(176, 230);
            this.btn5.TabIndex = 4;
            this.btn5.Tag = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Black;
            this.btn4.Image = global::PuzzleGame.Properties.Resources.pic4;
            this.btn4.Location = new System.Drawing.Point(1, 255);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(176, 230);
            this.btn4.TabIndex = 3;
            this.btn4.Tag = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Black;
            this.btn2.Image = global::PuzzleGame.Properties.Resources.pic2;
            this.btn2.Location = new System.Drawing.Point(172, 28);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(176, 230);
            this.btn2.TabIndex = 1;
            this.btn2.Tag = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Black;
            this.btn1.Image = global::PuzzleGame.Properties.Resources.pic1;
            this.btn1.Location = new System.Drawing.Point(1, 28);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(176, 230);
            this.btn1.TabIndex = 0;
            this.btn1.Tag = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(906, 817);
            this.Controls.Add(this.lblMoves);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.gbOriginal);
            this.Controls.Add(this.gbPuzzle);
            this.Name = "Form1";
            this.Text = "Picture Puzzle Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPuzzle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPuzzle;
        private System.Windows.Forms.GroupBox gbOriginal;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.Timer timer1;
    }
}

