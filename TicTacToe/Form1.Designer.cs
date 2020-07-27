namespace TicTacToe
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
            this.AD0 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.AD1 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.A13 = new System.Windows.Forms.Button();
            this.AD2 = new System.Windows.Forms.Button();
            this.newGamebtn = new System.Windows.Forms.Button();
            this.resetBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.Xwins = new System.Windows.Forms.Label();
            this.Owins = new System.Windows.Forms.Label();
            this.Draws = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AD0
            // 
            this.AD0.Location = new System.Drawing.Point(28, 47);
            this.AD0.Name = "AD0";
            this.AD0.Size = new System.Drawing.Size(96, 72);
            this.AD0.TabIndex = 0;
            this.AD0.UseVisualStyleBackColor = true;
            this.AD0.Click += new System.EventHandler(this.buttonClick);
            // 
            // A11
            // 
            this.A11.Location = new System.Drawing.Point(28, 125);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(96, 72);
            this.A11.TabIndex = 1;
            this.A11.UseVisualStyleBackColor = true;
            this.A11.Click += new System.EventHandler(this.buttonClick);
            // 
            // A20
            // 
            this.A20.Location = new System.Drawing.Point(28, 203);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(96, 72);
            this.A20.TabIndex = 2;
            this.A20.UseVisualStyleBackColor = true;
            this.A20.Click += new System.EventHandler(this.buttonClick);
            // 
            // A21
            // 
            this.A21.Location = new System.Drawing.Point(130, 203);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(96, 72);
            this.A21.TabIndex = 5;
            this.A21.UseVisualStyleBackColor = true;
            this.A21.Click += new System.EventHandler(this.buttonClick);
            // 
            // A12
            // 
            this.A12.Location = new System.Drawing.Point(130, 125);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(96, 72);
            this.A12.TabIndex = 4;
            this.A12.UseVisualStyleBackColor = true;
            this.A12.Click += new System.EventHandler(this.buttonClick);
            // 
            // AD1
            // 
            this.AD1.Location = new System.Drawing.Point(130, 47);
            this.AD1.Name = "AD1";
            this.AD1.Size = new System.Drawing.Size(96, 72);
            this.AD1.TabIndex = 3;
            this.AD1.UseVisualStyleBackColor = true;
            this.AD1.Click += new System.EventHandler(this.buttonClick);
            // 
            // A22
            // 
            this.A22.Location = new System.Drawing.Point(232, 203);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(96, 72);
            this.A22.TabIndex = 8;
            this.A22.UseVisualStyleBackColor = true;
            this.A22.Click += new System.EventHandler(this.buttonClick);
            // 
            // A13
            // 
            this.A13.Location = new System.Drawing.Point(232, 125);
            this.A13.Name = "A13";
            this.A13.Size = new System.Drawing.Size(96, 72);
            this.A13.TabIndex = 7;
            this.A13.UseVisualStyleBackColor = true;
            this.A13.Click += new System.EventHandler(this.buttonClick);
            // 
            // AD2
            // 
            this.AD2.Location = new System.Drawing.Point(232, 47);
            this.AD2.Name = "AD2";
            this.AD2.Size = new System.Drawing.Size(96, 72);
            this.AD2.TabIndex = 6;
            this.AD2.UseVisualStyleBackColor = true;
            this.AD2.Click += new System.EventHandler(this.buttonClick);
            // 
            // newGamebtn
            // 
            this.newGamebtn.Location = new System.Drawing.Point(12, 342);
            this.newGamebtn.Name = "newGamebtn";
            this.newGamebtn.Size = new System.Drawing.Size(118, 46);
            this.newGamebtn.TabIndex = 9;
            this.newGamebtn.Text = "New Game";
            this.newGamebtn.UseVisualStyleBackColor = true;
            this.newGamebtn.Click += new System.EventHandler(this.newGamebtn_Click);
            // 
            // resetBTN
            // 
            this.resetBTN.Location = new System.Drawing.Point(148, 342);
            this.resetBTN.Name = "resetBTN";
            this.resetBTN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resetBTN.Size = new System.Drawing.Size(118, 46);
            this.resetBTN.TabIndex = 10;
            this.resetBTN.Text = "Reset";
            this.resetBTN.UseVisualStyleBackColor = true;
            this.resetBTN.Click += new System.EventHandler(this.resetBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(284, 342);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(118, 46);
            this.exitBTN.TabIndex = 11;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // Xwins
            // 
            this.Xwins.Location = new System.Drawing.Point(349, 68);
            this.Xwins.Name = "Xwins";
            this.Xwins.Size = new System.Drawing.Size(100, 23);
            this.Xwins.TabIndex = 12;
            this.Xwins.Text = "label1";
            // 
            // Owins
            // 
            this.Owins.Location = new System.Drawing.Point(349, 155);
            this.Owins.Name = "Owins";
            this.Owins.Size = new System.Drawing.Size(100, 23);
            this.Owins.TabIndex = 13;
            this.Owins.Text = "label2";
            // 
            // Draws
            // 
            this.Draws.Location = new System.Drawing.Point(349, 224);
            this.Draws.Name = "Draws";
            this.Draws.Size = new System.Drawing.Size(100, 23);
            this.Draws.TabIndex = 14;
            this.Draws.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 493);
            this.Controls.Add(this.Draws);
            this.Controls.Add(this.Owins);
            this.Controls.Add(this.Xwins);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.resetBTN);
            this.Controls.Add(this.newGamebtn);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A13);
            this.Controls.Add(this.AD2);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.AD1);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.AD0);
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AD0;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button AD1;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Button A13;
        private System.Windows.Forms.Button AD2;
        private System.Windows.Forms.Button newGamebtn;
        private System.Windows.Forms.Button resetBTN;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Label Xwins;
        private System.Windows.Forms.Label Owins;
        private System.Windows.Forms.Label Draws;
    }
}

