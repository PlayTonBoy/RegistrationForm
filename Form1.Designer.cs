﻿namespace RegistrationForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBox1.Location = new System.Drawing.Point(12, 72);
            this.textBox1.MaxLength = 15;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(180, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Tag = "";
            this.textBox1.UseSystemPasswordChar = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 35);
            this.textBox2.MaxLength = 15;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 30);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "PlayTonBoy registration";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(12, 109);
            this.textBox3.MaxLength = 15;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 30);
            this.textBox3.TabIndex = 4;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button1.Location = new System.Drawing.Point(12, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 86);
            this.button1.TabIndex = 5;
            this.button1.Text = "Join";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 147);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Show password";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

