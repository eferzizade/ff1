namespace newTask1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn0 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn3 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn6 = new Button();
            panel1 = new Panel();
            lblActivePlayer = new Label();
            lblScoreX = new Label();
            lblScoreO = new Label();
            btnReset = new Button();
            SuspendLayout();
            // 
            // btn0
            // 
            btn0.BackColor = Color.LightGray;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(54, 50);
            btn0.Name = "btn0";
            btn0.Size = new Size(80, 80);
            btn0.TabIndex = 0;
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += Cell_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.LightGray;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(226, 50);
            btn2.Name = "btn2";
            btn2.Size = new Size(80, 80);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += Cell_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.LightGray;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(140, 50);
            btn1.Name = "btn1";
            btn1.Size = new Size(80, 80);
            btn1.TabIndex = 2;
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += Cell_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.LightGray;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(140, 136);
            btn4.Name = "btn4";
            btn4.Size = new Size(80, 80);
            btn4.TabIndex = 5;
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += Cell_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.LightGray;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(226, 136);
            btn5.Name = "btn5";
            btn5.Size = new Size(80, 80);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += Cell_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.LightGray;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(54, 136);
            btn3.Name = "btn3";
            btn3.Size = new Size(80, 80);
            btn3.TabIndex = 3;
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += Cell_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.LightGray;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(140, 222);
            btn7.Name = "btn7";
            btn7.Size = new Size(80, 80);
            btn7.TabIndex = 8;
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += Cell_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.LightGray;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(226, 222);
            btn8.Name = "btn8";
            btn8.Size = new Size(80, 80);
            btn8.TabIndex = 7;
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += Cell_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.LightGray;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(54, 222);
            btn6.Name = "btn6";
            btn6.Size = new Size(80, 80);
            btn6.TabIndex = 6;
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += Cell_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Location = new Point(333, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 300);
            panel1.TabIndex = 9;
            // 
            // lblActivePlayer
            // 
            lblActivePlayer.AutoSize = true;
            lblActivePlayer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActivePlayer.ForeColor = Color.FromArgb(128, 64, 0);
            lblActivePlayer.Location = new Point(476, 39);
            lblActivePlayer.Name = "lblActivePlayer";
            lblActivePlayer.Size = new Size(178, 41);
            lblActivePlayer.TabIndex = 10;
            lblActivePlayer.Text = "Player 1 - X";
            // 
            // lblScoreX
            // 
            lblScoreX.AutoSize = true;
            lblScoreX.Location = new Point(390, 110);
            lblScoreX.Name = "lblScoreX";
            lblScoreX.Size = new Size(50, 20);
            lblScoreX.TabIndex = 11;
            lblScoreX.Text = "label1";
            // 
            // lblScoreO
            // 
            lblScoreO.AutoSize = true;
            lblScoreO.Location = new Point(617, 110);
            lblScoreO.Name = "lblScoreO";
            lblScoreO.Size = new Size(50, 20);
            lblScoreO.TabIndex = 12;
            lblScoreO.Text = "label1";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(495, 172);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 13;
            btnReset.Text = "button10";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(782, 353);
            Controls.Add(btnReset);
            Controls.Add(lblScoreO);
            Controls.Add(lblScoreX);
            Controls.Add(lblActivePlayer);
            Controls.Add(panel1);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn6);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn3);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn0);
            Name = "Form1";
            Text = "Form1";
            Click += Cell_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn0;
        private Button btn2;
        private Button btn1;
        private Button btn4;
        private Button btn5;
        private Button btn3;
        private Button btn7;
        private Button btn8;
        private Button btn6;
        private Panel panel1;
        private Label lblActivePlayer;
        private Label lblScoreX;
        private Label lblScoreO;
        private Button btnReset;
    }
}
