﻿using System.Windows.Forms;

namespace CalculatorOOP
{
    public partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        /// 

        

        public void InitializeComponent()
        {
            this.display = new System.Windows.Forms.TextBox();
            this.plusBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.multiplyBtn = new System.Windows.Forms.Button();
            this.divideBtn = new System.Windows.Forms.Button();
            this.dotBtn = new System.Windows.Forms.Button();
            this.resultBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(229)))));
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.display.Location = new System.Drawing.Point(11, 12);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.Size = new System.Drawing.Size(219, 32);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            // 
            // plusBtn
            // 
            this.plusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(192)))), ((int)(((byte)(71)))));
            this.plusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.plusBtn.ForeColor = System.Drawing.Color.White;
            this.plusBtn.Location = new System.Drawing.Point(177, 167);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(55, 55);
            this.plusBtn.TabIndex = 12;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = false;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(192)))), ((int)(((byte)(71)))));
            this.minusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.minusBtn.ForeColor = System.Drawing.Color.White;
            this.minusBtn.Location = new System.Drawing.Point(177, 223);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(55, 55);
            this.minusBtn.TabIndex = 16;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = false;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(192)))), ((int)(((byte)(71)))));
            this.multiplyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.multiplyBtn.ForeColor = System.Drawing.Color.White;
            this.multiplyBtn.Location = new System.Drawing.Point(177, 111);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(55, 55);
            this.multiplyBtn.TabIndex = 8;
            this.multiplyBtn.Text = "×";
            this.multiplyBtn.UseVisualStyleBackColor = false;
            this.multiplyBtn.Click += new System.EventHandler(this.multiplyBtn_Click);
            // 
            // divideBtn
            // 
            this.divideBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(192)))), ((int)(((byte)(71)))));
            this.divideBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.divideBtn.ForeColor = System.Drawing.Color.White;
            this.divideBtn.Location = new System.Drawing.Point(177, 55);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(55, 55);
            this.divideBtn.TabIndex = 4;
            this.divideBtn.Text = "÷";
            this.divideBtn.UseVisualStyleBackColor = false;
            this.divideBtn.Click += new System.EventHandler(this.divideBtn_Click);
            // 
            // dotBtn
            // 
            this.dotBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(178)))), ((int)(((byte)(63)))));
            this.dotBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dotBtn.ForeColor = System.Drawing.Color.White;
            this.dotBtn.Location = new System.Drawing.Point(121, 223);
            this.dotBtn.Name = "dotBtn";
            this.dotBtn.Size = new System.Drawing.Size(55, 55);
            this.dotBtn.TabIndex = 15;
            this.dotBtn.Text = ".";
            this.dotBtn.UseVisualStyleBackColor = false;
            this.dotBtn.Click += new System.EventHandler(this.dotBtn_Click);
            // 
            // resultBtn
            // 
            this.resultBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(139)))), ((int)(((byte)(223)))));
            this.resultBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.resultBtn.ForeColor = System.Drawing.Color.White;
            this.resultBtn.Location = new System.Drawing.Point(8, 279);
            this.resultBtn.Name = "resultBtn";
            this.resultBtn.Size = new System.Drawing.Size(112, 55);
            this.resultBtn.TabIndex = 14;
            this.resultBtn.Text = "=";
            this.resultBtn.UseVisualStyleBackColor = false;
            this.resultBtn.Click += new System.EventHandler(this.resultBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(9, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.numbers_click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(65, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.numbers_click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(121, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 55);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.numbers_click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(9, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 55);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.numbers_click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gray;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(65, 111);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 55);
            this.button5.TabIndex = 7;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.numbers_click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(121, 111);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 55);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.numbers_click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gray;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(9, 167);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 55);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.numbers_click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gray;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(65, 167);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 55);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.numbers_click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Gray;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(121, 167);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 55);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.numbers_click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.Gray;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button0.ForeColor = System.Drawing.Color.White;
            this.button0.Location = new System.Drawing.Point(9, 223);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(111, 55);
            this.button0.TabIndex = 13;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.numbers_click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(139)))), ((int)(((byte)(223)))));
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(121, 279);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(111, 55);
            this.clearBtn.TabIndex = 17;
            this.clearBtn.Text = "C";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(130)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(241, 346);
            this.Controls.Add(this.display);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.multiplyBtn);
            this.Controls.Add(this.divideBtn);
            this.Controls.Add(this.dotBtn);
            this.Controls.Add(this.resultBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button0);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(257, 384);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(257, 384);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button multiplyBtn;
        private System.Windows.Forms.Button divideBtn;
        private System.Windows.Forms.Button dotBtn;
        private System.Windows.Forms.Button resultBtn;
        private System.Windows.Forms.Button clearBtn;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;

        private System.Windows.Forms.Button button0;

        

    }
}

