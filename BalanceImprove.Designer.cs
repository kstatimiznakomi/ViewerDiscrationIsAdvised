using System.ComponentModel;

namespace ViewerDiscrationIsAdvised{
    partial class BalanceImprove{
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing){
            if (disposing && (components != null)){
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(){
            this.cancel = new System.Windows.Forms.Button();
            this.pay = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(67, 329);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(328, 92);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "Назад";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // pay
            // 
            this.pay.Location = new System.Drawing.Point(416, 329);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(328, 92);
            this.pay.TabIndex = 1;
            this.pay.Text = "Пополнить";
            this.pay.UseVisualStyleBackColor = true;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(355, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 31);
            this.textBox1.TabIndex = 2;
            // 
            // BalanceImprove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 477);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.cancel);
            this.Name = "BalanceImprove";
            this.Text = "BalanceImprove";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Button pay;

        private System.Windows.Forms.Button cancel;

        #endregion
    }
}