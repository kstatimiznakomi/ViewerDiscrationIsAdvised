namespace ViewerDiscrationIsAdvised {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(){
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.balance = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.balanceText = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.moneyTaker10 = new System.Windows.Forms.PictureBox();
            this.moneyTaker5 = new System.Windows.Forms.PictureBox();
            this.cancel = new System.Windows.Forms.Button();
            this.pay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moneyTaker10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyTaker5)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2155, 612);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.balance);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.balanceText);
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(1487, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(665, 582);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // balance
            // 
            this.balance.Location = new System.Drawing.Point(504, 14);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(131, 29);
            this.balance.TabIndex = 12;
            this.balance.TextChanged += new System.EventHandler(this.balance_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(140, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(232, 37);
            this.button3.TabIndex = 11;
            this.button3.Text = "Пополнить баланс";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // balanceText
            // 
            this.balanceText.Location = new System.Drawing.Point(404, 14);
            this.balanceText.Name = "balanceText";
            this.balanceText.Size = new System.Drawing.Size(91, 29);
            this.balanceText.TabIndex = 9;
            this.balanceText.Text = "Баланс:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.moneyTaker10);
            this.groupBox8.Controls.Add(this.moneyTaker5);
            this.groupBox8.Controls.Add(this.cancel);
            this.groupBox8.Controls.Add(this.pay);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Location = new System.Drawing.Point(77, 62);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(558, 431);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            // 
            // moneyTaker10
            // 
            this.moneyTaker10.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.moneyTaker10.ImageLocation = "C:\\ViewerDiscrationIsAdvised\\ViewerDiscrationIsAdvised\\bin\\Debug\\moneyEnter.png";
            this.moneyTaker10.Location = new System.Drawing.Point(346, 291);
            this.moneyTaker10.Name = "moneyTaker10";
            this.moneyTaker10.Size = new System.Drawing.Size(29, 71);
            this.moneyTaker10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moneyTaker10.TabIndex = 10;
            this.moneyTaker10.TabStop = false;
            this.moneyTaker10.Click += new System.EventHandler(this.moneyTaker10_Click);
            // 
            // moneyTaker5
            // 
            this.moneyTaker5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.moneyTaker5.ImageLocation = "C:\\ViewerDiscrationIsAdvised\\ViewerDiscrationIsAdvised\\bin\\Debug\\moneyEnter.png";
            this.moneyTaker5.Location = new System.Drawing.Point(178, 291);
            this.moneyTaker5.Name = "moneyTaker5";
            this.moneyTaker5.Size = new System.Drawing.Size(29, 71);
            this.moneyTaker5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moneyTaker5.TabIndex = 9;
            this.moneyTaker5.TabStop = false;
            this.moneyTaker5.Click += new System.EventHandler(this.moneyTaker5_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(297, 371);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(187, 48);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "Сброс";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // pay
            // 
            this.pay.Location = new System.Drawing.Point(94, 371);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(187, 48);
            this.pay.TabIndex = 7;
            this.pay.Text = "Оплатить";
            this.pay.UseVisualStyleBackColor = true;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(287, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 61);
            this.label2.TabIndex = 6;
            this.label2.Text = "вставьте монету достоинством 10 рублей";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 61);
            this.label1.TabIndex = 5;
            this.label1.Text = "вставьте монету достоинством 5 рублей";
            // 
            // groupBox5
            // 
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox5.Location = new System.Drawing.Point(672, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(809, 582);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // groupBox4
            // 
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(3, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(669, 582);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 612);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(2155, 690);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox7
            // 
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(1186, 27);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(966, 660);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "groupBox7";
            // 
            // groupBox6
            // 
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox6.Location = new System.Drawing.Point(3, 27);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1183, 660);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2155, 1302);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(100, 200);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moneyTaker10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyTaker5)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.PictureBox moneyTaker10;

        private System.Windows.Forms.PictureBox moneyTaker5;

        private System.Windows.Forms.Label balanceText;

        private System.Windows.Forms.Button cancel;

        private System.Windows.Forms.Button pay;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label balance;
    }
}

