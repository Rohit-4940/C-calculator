namespace DesktopApp1
{
    partial class Calculator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtcalculator = new System.Windows.Forms.TextBox();
            this.btnd = new System.Windows.Forms.Button();
            this.btnresult = new System.Windows.Forms.Button();
            this.btnm = new System.Windows.Forms.Button();
            this.btna = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btns = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnp = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.txtcalculator);
            this.panel1.Controls.Add(this.btnd);
            this.panel1.Controls.Add(this.btnresult);
            this.panel1.Controls.Add(this.btnm);
            this.panel1.Controls.Add(this.btna);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btnc);
            this.panel1.Controls.Add(this.btns);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btnp);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 287);
            this.panel1.TabIndex = 0;
            // 
            // txtcalculator
            // 
            this.txtcalculator.Font = new System.Drawing.Font("Algerian", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcalculator.Location = new System.Drawing.Point(14, 13);
            this.txtcalculator.Name = "txtcalculator";
            this.txtcalculator.Size = new System.Drawing.Size(206, 64);
            this.txtcalculator.TabIndex = 18;
            this.txtcalculator.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnd
            // 
            this.btnd.BackColor = System.Drawing.Color.White;
            this.btnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnd.Location = new System.Drawing.Point(173, 194);
            this.btnd.Name = "btnd";
            this.btnd.Size = new System.Drawing.Size(47, 30);
            this.btnd.TabIndex = 17;
            this.btnd.Text = "/";
            this.btnd.UseVisualStyleBackColor = false;
            this.btnd.Click += new System.EventHandler(this.Btnd_Click);
            // 
            // btnresult
            // 
            this.btnresult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnresult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnresult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresult.Location = new System.Drawing.Point(173, 230);
            this.btnresult.Name = "btnresult";
            this.btnresult.Size = new System.Drawing.Size(47, 54);
            this.btnresult.TabIndex = 16;
            this.btnresult.Text = "=";
            this.btnresult.UseVisualStyleBackColor = false;
            this.btnresult.Click += new System.EventHandler(this.Btnresult_Click);
            // 
            // btnm
            // 
            this.btnm.BackColor = System.Drawing.Color.White;
            this.btnm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnm.Location = new System.Drawing.Point(173, 158);
            this.btnm.Name = "btnm";
            this.btnm.Size = new System.Drawing.Size(47, 30);
            this.btnm.TabIndex = 14;
            this.btnm.Text = "*";
            this.btnm.UseVisualStyleBackColor = false;
            this.btnm.Click += new System.EventHandler(this.Btnm_Click);
            // 
            // btna
            // 
            this.btna.BackColor = System.Drawing.Color.White;
            this.btna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btna.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btna.Location = new System.Drawing.Point(120, 239);
            this.btna.Name = "btna";
            this.btna.Size = new System.Drawing.Size(47, 46);
            this.btna.TabIndex = 13;
            this.btna.Text = "+";
            this.btna.UseVisualStyleBackColor = false;
            this.btna.Click += new System.EventHandler(this.Btna_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.White;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.Location = new System.Drawing.Point(120, 83);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(47, 46);
            this.btn9.TabIndex = 12;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // btnc
            // 
            this.btnc.BackColor = System.Drawing.Color.Red;
            this.btnc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnc.Location = new System.Drawing.Point(173, 83);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(47, 33);
            this.btnc.TabIndex = 11;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = false;
            this.btnc.Click += new System.EventHandler(this.Btnc_Click);
            // 
            // btns
            // 
            this.btns.BackColor = System.Drawing.Color.White;
            this.btns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btns.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btns.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btns.Location = new System.Drawing.Point(173, 122);
            this.btns.Name = "btns";
            this.btns.Size = new System.Drawing.Size(47, 30);
            this.btns.TabIndex = 10;
            this.btns.Text = "-";
            this.btns.UseVisualStyleBackColor = false;
            this.btns.Click += new System.EventHandler(this.Btns_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Location = new System.Drawing.Point(120, 187);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(47, 46);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.White;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Location = new System.Drawing.Point(120, 135);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(47, 46);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Location = new System.Drawing.Point(14, 135);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(47, 46);
            this.btn4.TabIndex = 7;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Location = new System.Drawing.Point(14, 187);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(47, 46);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.White;
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.Location = new System.Drawing.Point(14, 239);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(47, 46);
            this.btn0.TabIndex = 5;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.White;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.ForeColor = System.Drawing.Color.Black;
            this.btn8.Location = new System.Drawing.Point(67, 83);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(47, 46);
            this.btn8.TabIndex = 4;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Location = new System.Drawing.Point(67, 135);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(47, 46);
            this.btn5.TabIndex = 3;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Location = new System.Drawing.Point(67, 187);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(47, 46);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // btnp
            // 
            this.btnp.BackColor = System.Drawing.Color.White;
            this.btnp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnp.Location = new System.Drawing.Point(67, 239);
            this.btnp.Name = "btnp";
            this.btnp.Size = new System.Drawing.Size(47, 46);
            this.btnp.TabIndex = 1;
            this.btnp.Text = ".";
            this.btnp.UseVisualStyleBackColor = false;
            this.btnp.Click += new System.EventHandler(this.Btnp_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Location = new System.Drawing.Point(14, 83);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(47, 46);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 286);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Calculator";
            this.Text = "calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Calculator_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnd;
        private System.Windows.Forms.Button btnresult;
        private System.Windows.Forms.Button btnm;
        private System.Windows.Forms.Button btna;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btns;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnp;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.TextBox txtcalculator;
    }
}

