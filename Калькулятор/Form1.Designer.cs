namespace Калькулятор
{
    partial class Form1
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SumButton = new System.Windows.Forms.Button();
            this.DifButton = new System.Windows.Forms.Button();
            this.DivBbutton = new System.Windows.Forms.Button();
            this.MulButton = new System.Windows.Forms.Button();
            this.BcspButton = new System.Windows.Forms.Button();
            this.ClrButton = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.ResButton = new System.Windows.Forms.Button();
            this.NegButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(370, 112);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(170, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(11, 217);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(90, 217);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 50);
            this.button5.TabIndex = 3;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(170, 217);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 50);
            this.button6.TabIndex = 3;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(11, 285);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 50);
            this.button7.TabIndex = 3;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(90, 285);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 50);
            this.button8.TabIndex = 3;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(170, 285);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 50);
            this.button9.TabIndex = 3;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(11, 352);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(139, 50);
            this.button10.TabIndex = 3;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // SumButton
            // 
            this.SumButton.Location = new System.Drawing.Point(245, 149);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(63, 50);
            this.SumButton.TabIndex = 3;
            this.SumButton.Text = "+";
            this.SumButton.UseVisualStyleBackColor = true;
            this.SumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // DifButton
            // 
            this.DifButton.Location = new System.Drawing.Point(318, 149);
            this.DifButton.Name = "DifButton";
            this.DifButton.Size = new System.Drawing.Size(63, 50);
            this.DifButton.TabIndex = 3;
            this.DifButton.Text = "-";
            this.DifButton.UseVisualStyleBackColor = true;
            this.DifButton.Click += new System.EventHandler(this.DifButton_Click);
            // 
            // DivBbutton
            // 
            this.DivBbutton.Location = new System.Drawing.Point(245, 217);
            this.DivBbutton.Name = "DivBbutton";
            this.DivBbutton.Size = new System.Drawing.Size(63, 50);
            this.DivBbutton.TabIndex = 3;
            this.DivBbutton.Text = "/";
            this.DivBbutton.UseVisualStyleBackColor = true;
            this.DivBbutton.Click += new System.EventHandler(this.DivButton_Click);
            // 
            // MulButton
            // 
            this.MulButton.Location = new System.Drawing.Point(318, 217);
            this.MulButton.Name = "MulButton";
            this.MulButton.Size = new System.Drawing.Size(63, 50);
            this.MulButton.TabIndex = 3;
            this.MulButton.Text = "*";
            this.MulButton.UseVisualStyleBackColor = true;
            this.MulButton.Click += new System.EventHandler(this.MulButton_Click);
            // 
            // BcspButton
            // 
            this.BcspButton.Location = new System.Drawing.Point(245, 285);
            this.BcspButton.Name = "BcspButton";
            this.BcspButton.Size = new System.Drawing.Size(63, 50);
            this.BcspButton.TabIndex = 3;
            this.BcspButton.Text = "<-";
            this.BcspButton.UseVisualStyleBackColor = true;
            this.BcspButton.Click += new System.EventHandler(this.BcspButton_Click);
            // 
            // ClrButton
            // 
            this.ClrButton.Location = new System.Drawing.Point(318, 285);
            this.ClrButton.Name = "ClrButton";
            this.ClrButton.Size = new System.Drawing.Size(63, 50);
            this.ClrButton.TabIndex = 3;
            this.ClrButton.Text = "C";
            this.ClrButton.UseVisualStyleBackColor = true;
            this.ClrButton.Click += new System.EventHandler(this.ClrButton_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(170, 352);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(60, 50);
            this.button17.TabIndex = 3;
            this.button17.Text = ".";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // ResButton
            // 
            this.ResButton.Location = new System.Drawing.Point(245, 352);
            this.ResButton.Name = "ResButton";
            this.ResButton.Size = new System.Drawing.Size(63, 50);
            this.ResButton.TabIndex = 3;
            this.ResButton.Text = "=";
            this.ResButton.UseVisualStyleBackColor = true;
            this.ResButton.Click += new System.EventHandler(this.ResButton_Click);
            // 
            // NegButton
            // 
            this.NegButton.Location = new System.Drawing.Point(318, 352);
            this.NegButton.Name = "NegButton";
            this.NegButton.Size = new System.Drawing.Size(63, 50);
            this.NegButton.TabIndex = 3;
            this.NegButton.Text = "Neg";
            this.NegButton.UseVisualStyleBackColor = true;
            this.NegButton.Click += new System.EventHandler(this.NegButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 89);
            this.label1.TabIndex = 4;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MulButton);
            this.Controls.Add(this.ClrButton);
            this.Controls.Add(this.NegButton);
            this.Controls.Add(this.ResButton);
            this.Controls.Add(this.BcspButton);
            this.Controls.Add(this.DivBbutton);
            this.Controls.Add(this.DifButton);
            this.Controls.Add(this.SumButton);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button SumButton;
        private System.Windows.Forms.Button DifButton;
        private System.Windows.Forms.Button DivBbutton;
        private System.Windows.Forms.Button MulButton;
        private System.Windows.Forms.Button BcspButton;
        private System.Windows.Forms.Button ClrButton;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button ResButton;
        private System.Windows.Forms.Button NegButton;
        private System.Windows.Forms.Label label1;
    }
}

