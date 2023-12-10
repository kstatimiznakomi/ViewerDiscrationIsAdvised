using System;
using System.Drawing;
using System.Windows.Forms;

namespace ViewerDiscrationIsAdvised {
    public partial class Form1 : Form{
        private _3Task threeTask = new _3Task();
        private CashManager cashManager = new CashManager();

        public Form1() {
            InitializeComponent();
            balanceText.Text = "Баланс: ";
            cashManager.CheckForLimitCash();
            balance.Text = cashManager.renderManager(cashManager.GetCash());
            moneyTaker5.Image = new Bitmap(@".\moneyClose.png");
            moneyTaker10.Image = new Bitmap(@".\moneyClose.png");
            if (balance.Text == "" || balance.Text == "0") {
                btnsUnavailable();
            }
            else {
                btnsEnable();
            }
        }

        public void SetBalanceOnForm(){
            balance.Text = cashManager.renderManager(cashManager.GetCash());
        }

        public void btnsEnable(){
            pay.Enabled = true;
            cancel.Enabled = true;
            moneyTaker5.Enabled = true;
            moneyTaker10.Enabled = true;
        }

        public void btnsUnavailable(){
            pay.Enabled = false;
            cancel.Enabled = false;
            moneyTaker5.Enabled = false;
            moneyTaker10.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e){
            
        }

        private void button3_Click(object sender, EventArgs e){
            using (BalanceImprove improve = new BalanceImprove()){
                improve.ShowDialog(this);
            }
        }

        private void button2_Click(object sender, EventArgs e) {

        }

        private void balance_TextChanged(object sender, EventArgs e) {
            if (this.Text == "" || this.Text == "0") {
                btnsUnavailable();
            }
            else {
                btnsEnable();
            }
        }

        private void pay_Click(object sender, EventArgs e){
            threeTask.PayForDrink();
            SetBalanceOnForm();
        }

        private void cancel_Click(object sender, EventArgs e){
        }

        private void moneyTaker5_Click(object sender, EventArgs e){
            
        }

        private void moneyTaker10_Click(object sender, EventArgs e){
            
        }
    }
}
