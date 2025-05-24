using System.Drawing;

namespace Calculator1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textDisp = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rjButton1 = new Calculator1.RJButton();
            this.btnequ = new Calculator1.RJButton();
            this.btnsum = new Calculator1.RJButton();
            this.rjButton3 = new Calculator1.RJButton();
            this.btnmult = new Calculator1.RJButton();
            this.btn0 = new Calculator1.RJButton();
            this.btn9 = new Calculator1.RJButton();
            this.btn6 = new Calculator1.RJButton();
            this.btn3 = new Calculator1.RJButton();
            this.btn2 = new Calculator1.RJButton();
            this.btn5 = new Calculator1.RJButton();
            this.btn8 = new Calculator1.RJButton();
            this.btn1 = new Calculator1.RJButton();
            this.btn7 = new Calculator1.RJButton();
            this.btn4 = new Calculator1.RJButton();
            this.btnDiv = new Calculator1.RJButton();
            this.btnProc = new Calculator1.RJButton();
            this.btnPM = new Calculator1.RJButton();
            this.btnClear = new Calculator1.RJButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textDisp
            // 
            this.textDisp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.textDisp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDisp.Cursor = System.Windows.Forms.Cursors.Default;
            this.textDisp.Font = new System.Drawing.Font("MS PGothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textDisp.ForeColor = System.Drawing.SystemColors.Window;
            this.textDisp.Location = new System.Drawing.Point(19, 62);
            this.textDisp.Margin = new System.Windows.Forms.Padding(0);
            this.textDisp.Multiline = true;
            this.textDisp.Name = "textDisp";
            this.textDisp.Size = new System.Drawing.Size(313, 63);
            this.textDisp.TabIndex = 0;
            this.textDisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textDisp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(179, 437);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(73, 68);
            this.rjButton1.TabIndex = 56;
            this.rjButton1.Text = ",";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click_6);
            // 
            // btnequ
            // 
            this.btnequ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnequ.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnequ.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnequ.BorderRadius = 15;
            this.btnequ.BorderSize = 0;
            this.btnequ.FlatAppearance.BorderSize = 0;
            this.btnequ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnequ.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnequ.ForeColor = System.Drawing.Color.White;
            this.btnequ.Location = new System.Drawing.Point(259, 437);
            this.btnequ.Margin = new System.Windows.Forms.Padding(0);
            this.btnequ.Name = "btnequ";
            this.btnequ.Padding = new System.Windows.Forms.Padding(3, 0, 0, 2);
            this.btnequ.Size = new System.Drawing.Size(73, 68);
            this.btnequ.TabIndex = 54;
            this.btnequ.Text = "=";
            this.btnequ.TextColor = System.Drawing.Color.White;
            this.btnequ.UseVisualStyleBackColor = false;
            this.btnequ.Click += new System.EventHandler(this.rjButton5_Click);
            // 
            // btnsum
            // 
            this.btnsum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(79)))), ((int)(((byte)(255)))));
            this.btnsum.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(79)))), ((int)(((byte)(255)))));
            this.btnsum.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnsum.BorderRadius = 15;
            this.btnsum.BorderSize = 0;
            this.btnsum.FlatAppearance.BorderSize = 0;
            this.btnsum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsum.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsum.ForeColor = System.Drawing.Color.White;
            this.btnsum.Location = new System.Drawing.Point(259, 363);
            this.btnsum.Margin = new System.Windows.Forms.Padding(0);
            this.btnsum.Name = "btnsum";
            this.btnsum.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnsum.Size = new System.Drawing.Size(73, 68);
            this.btnsum.TabIndex = 53;
            this.btnsum.Text = "+";
            this.btnsum.TextColor = System.Drawing.Color.White;
            this.btnsum.UseVisualStyleBackColor = false;
            this.btnsum.Click += new System.EventHandler(this.rjButton4_Click);
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(79)))), ((int)(((byte)(255)))));
            this.rjButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(79)))), ((int)(((byte)(255)))));
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 15;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("MS PGothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(259, 289);
            this.rjButton3.Margin = new System.Windows.Forms.Padding(0);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Padding = new System.Windows.Forms.Padding(5, 4, 0, 0);
            this.rjButton3.Size = new System.Drawing.Size(73, 68);
            this.rjButton3.TabIndex = 52;
            this.rjButton3.Text = "-";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton3_Click_3);
            // 
            // btnmult
            // 
            this.btnmult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(79)))), ((int)(((byte)(255)))));
            this.btnmult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(79)))), ((int)(((byte)(255)))));
            this.btnmult.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnmult.BorderRadius = 15;
            this.btnmult.BorderSize = 0;
            this.btnmult.FlatAppearance.BorderSize = 0;
            this.btnmult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmult.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmult.ForeColor = System.Drawing.Color.White;
            this.btnmult.Location = new System.Drawing.Point(259, 215);
            this.btnmult.Margin = new System.Windows.Forms.Padding(0);
            this.btnmult.Name = "btnmult";
            this.btnmult.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnmult.Size = new System.Drawing.Size(73, 68);
            this.btnmult.TabIndex = 51;
            this.btnmult.Text = "×";
            this.btnmult.TextColor = System.Drawing.Color.White;
            this.btnmult.UseVisualStyleBackColor = false;
            this.btnmult.Click += new System.EventHandler(this.rjButton1_Click_5);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.btn0.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.btn0.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn0.BorderRadius = 15;
            this.btn0.BorderSize = 0;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(19, 437);
            this.btn0.Margin = new System.Windows.Forms.Padding(0);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(153, 68);
            this.btn0.TabIndex = 49;
            this.btn0.Text = "0";
            this.btn0.TextColor = System.Drawing.Color.White;
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.rjButton1_Click_4);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.btn9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.btn9.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn9.BorderRadius = 15;
            this.btn9.BorderSize = 0;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(179, 215);
            this.btn9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn9.Name = "btn9";
            this.btn9.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn9.Size = new System.Drawing.Size(73, 68);
            this.btn9.TabIndex = 48;
            this.btn9.Text = "9";
            this.btn9.TextColor = System.Drawing.Color.White;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.rjButton3_Click_2);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.btn6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.btn6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn6.BorderRadius = 15;
            this.btn6.BorderSize = 0;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(179, 289);
            this.btn6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn6.Name = "btn6";
            this.btn6.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn6.Size = new System.Drawing.Size(73, 68);
            this.btn6.TabIndex = 47;
            this.btn6.Text = "6";
            this.btn6.TextColor = System.Drawing.Color.White;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.rjButton2_Click_2);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.btn3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.btn3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn3.BorderRadius = 15;
            this.btn3.BorderSize = 0;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(179, 363);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3.Name = "btn3";
            this.btn3.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn3.Size = new System.Drawing.Size(73, 68);
            this.btn3.TabIndex = 46;
            this.btn3.Text = "3";
            this.btn3.TextColor = System.Drawing.Color.White;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.rjButton1_Click_3);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.btn2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.btn2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn2.BorderRadius = 15;
            this.btn2.BorderSize = 0;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(99, 363);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn2.Name = "btn2";
            this.btn2.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn2.Size = new System.Drawing.Size(73, 68);
            this.btn2.TabIndex = 45;
            this.btn2.Text = "2";
            this.btn2.TextColor = System.Drawing.Color.White;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.rjButton3_Click_1);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.btn5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.btn5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn5.BorderRadius = 15;
            this.btn5.BorderSize = 0;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(99, 289);
            this.btn5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn5.Name = "btn5";
            this.btn5.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn5.Size = new System.Drawing.Size(73, 68);
            this.btn5.TabIndex = 44;
            this.btn5.Text = "5";
            this.btn5.TextColor = System.Drawing.Color.White;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.rjButton2_Click_1);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.btn8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.btn8.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn8.BorderRadius = 15;
            this.btn8.BorderSize = 0;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(99, 215);
            this.btn8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn8.Name = "btn8";
            this.btn8.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn8.Size = new System.Drawing.Size(73, 68);
            this.btn8.TabIndex = 43;
            this.btn8.Text = "8";
            this.btn8.TextColor = System.Drawing.Color.White;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.rjButton1_Click_2);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.btn1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.btn1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn1.BorderRadius = 15;
            this.btn1.BorderSize = 0;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(19, 363);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn1.Size = new System.Drawing.Size(73, 68);
            this.btn1.TabIndex = 42;
            this.btn1.Text = "1";
            this.btn1.TextColor = System.Drawing.Color.White;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.btn7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.btn7.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn7.BorderRadius = 15;
            this.btn7.BorderSize = 0;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(19, 215);
            this.btn7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn7.Name = "btn7";
            this.btn7.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn7.Size = new System.Drawing.Size(73, 68);
            this.btn7.TabIndex = 41;
            this.btn7.Text = "7";
            this.btn7.TextColor = System.Drawing.Color.White;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.btn4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.btn4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn4.BorderRadius = 15;
            this.btn4.BorderSize = 0;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(19, 289);
            this.btn4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn4.Name = "btn4";
            this.btn4.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn4.Size = new System.Drawing.Size(73, 68);
            this.btn4.TabIndex = 40;
            this.btn4.Text = "4";
            this.btn4.TextColor = System.Drawing.Color.White;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.rjButton1_Click_1);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(79)))), ((int)(((byte)(255)))));
            this.btnDiv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(79)))), ((int)(((byte)(255)))));
            this.btnDiv.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDiv.BorderRadius = 15;
            this.btnDiv.BorderSize = 0;
            this.btnDiv.FlatAppearance.BorderSize = 0;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.Color.White;
            this.btnDiv.Location = new System.Drawing.Point(259, 142);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(0);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Padding = new System.Windows.Forms.Padding(3, 0, 0, 2);
            this.btnDiv.Size = new System.Drawing.Size(73, 68);
            this.btnDiv.TabIndex = 39;
            this.btnDiv.Text = "÷";
            this.btnDiv.TextColor = System.Drawing.Color.White;
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click_1);
            // 
            // btnProc
            // 
            this.btnProc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnProc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnProc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnProc.BorderRadius = 15;
            this.btnProc.BorderSize = 0;
            this.btnProc.FlatAppearance.BorderSize = 0;
            this.btnProc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProc.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProc.ForeColor = System.Drawing.Color.White;
            this.btnProc.Location = new System.Drawing.Point(179, 142);
            this.btnProc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProc.Name = "btnProc";
            this.btnProc.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnProc.Size = new System.Drawing.Size(73, 68);
            this.btnProc.TabIndex = 38;
            this.btnProc.Text = "%";
            this.btnProc.TextColor = System.Drawing.Color.White;
            this.btnProc.UseVisualStyleBackColor = false;
            this.btnProc.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // btnPM
            // 
            this.btnPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPM.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPM.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPM.BorderRadius = 15;
            this.btnPM.BorderSize = 0;
            this.btnPM.FlatAppearance.BorderSize = 0;
            this.btnPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPM.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPM.ForeColor = System.Drawing.Color.White;
            this.btnPM.Location = new System.Drawing.Point(99, 142);
            this.btnPM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPM.Name = "btnPM";
            this.btnPM.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnPM.Size = new System.Drawing.Size(73, 68);
            this.btnPM.TabIndex = 37;
            this.btnPM.Text = "±";
            this.btnPM.TextColor = System.Drawing.Color.White;
            this.btnPM.UseVisualStyleBackColor = false;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClear.BorderColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderRadius = 15;
            this.btnClear.BorderSize = 0;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(19, 142);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(73, 68);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "C";
            this.btnClear.TextColor = System.Drawing.Color.White;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(19, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(313, 30);
            this.textBox1.TabIndex = 57;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(356, 522);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.btnequ);
            this.Controls.Add(this.btnsum);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.btnmult);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnProc);
            this.Controls.Add(this.btnPM);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.textDisp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private RJButton btnClear;
        private RJButton btnPM;
        private RJButton btnProc;
        private RJButton btnDiv;
        private RJButton btn4;
        private RJButton btn7;
        private RJButton btn1;
        private RJButton btn8;
        private RJButton btn5;
        private RJButton btn2;
        private RJButton btn3;
        private RJButton btn6;
        private RJButton btn9;
        private RJButton btn0;
        private RJButton btnmult;
        private RJButton rjButton3;
        private RJButton btnsum;
        private RJButton btnequ;
        private RJButton rjButton1;
        private System.Windows.Forms.TextBox textDisp;
        private System.Windows.Forms.TextBox textBox1;
    }
}

