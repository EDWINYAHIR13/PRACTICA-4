﻿namespace PRACTICA_4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 79);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "NUMERO A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 119);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 1;
            label2.Text = "NUMERO B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 168);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 2;
            label3.Text = "NUMERO C";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 216);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 3;
            label4.Text = "NUMERO D";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(127, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(131, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(127, 161);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(131, 27);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(127, 213);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(131, 27);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(473, 72);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(131, 27);
            textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(473, 112);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(131, 27);
            textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(473, 161);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(131, 27);
            textBox7.TabIndex = 13;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(473, 213);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(131, 27);
            textBox8.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(353, 216);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 19;
            label5.Text = "NUMERO D";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(353, 168);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 18;
            label6.Text = "NUMERO C";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(353, 119);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 17;
            label7.Text = "NUMERO B";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(353, 79);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 16;
            label8.Text = "NUMERO A";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(234, 21);
            label9.Name = "label9";
            label9.Size = new Size(276, 20);
            label9.TabIndex = 20;
            label9.Text = "ESCRIBIR NUMERO EN ORDEN INVERSO";
            label9.Click += label9_Click;
            // 
            // button1
            // 
            button1.Location = new Point(259, 305);
            button1.Name = "button1";
            button1.Size = new Size(180, 70);
            button1.TabIndex = 21;
            button1.Text = "INVERTIR ORDEN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox7);
            Controls.Add(textBox8);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "INVERTIR NUMEROS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button1;
    }
}