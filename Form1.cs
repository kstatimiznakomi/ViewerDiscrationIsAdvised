using System;
using System.Windows.Forms;

namespace ViewerDiscrationIsAdvised {
    public partial class Form1 : Form{
        private _3Task threeTask = new _3Task();
        private _2Task twoTask = new _2Task();
        private CashManager cashManager = new CashManager();

        public Form1() {
            InitializeComponent();
            ForDrinksTask();
        }

        // Напитки
        private void ForDrinksTask(){
            balanceText.Text = "Баланс: ";
            cashManager.CheckForLimitCash();
            balance.Text = cashManager.renderManager(cashManager.GetCash());
            deposit.Text = threeTask.GetDeposit();
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
        private void button3_Click(object sender, EventArgs e){
            using (BalanceImprove improve = new BalanceImprove()){
                improve.ShowDialog(this);
            }
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
            deposit.Text = threeTask.GetDeposit();
        }

        private void cancel_Click(object sender, EventArgs e){
            threeTask.Cancel();
            SetBalanceOnForm();
            deposit.Text = threeTask.GetDeposit();
        }

        private void moneyTaker5_Click(object sender, EventArgs e){
            threeTask.SetDeposite5();
            SetBalanceOnForm();
            deposit.Text = threeTask.GetDeposit();
        }

        private void moneyTaker10_Click(object sender, EventArgs e){
            threeTask.SetDeposite10();
            SetBalanceOnForm();
            deposit.Text = threeTask.GetDeposit();
        }

        /// Остаток от деления на 3
        private void onThreeDivide_TextChanged(object sender, EventArgs e){
            try{
                if (onThreeDivide.Text != String.Empty || onThreeDivide.Text != ""){
                    ifDivide.Text = twoTask.DivideRemain(Convert.ToInt32(onThreeDivide.Text)).ToString();
                    state.Text = twoTask.DivideRemainStates(Convert.ToInt32(onThreeDivide.Text));
                }
                else{
                    ifDivide.Text = "";
                    state.Text = "";
                }
            }
            catch (Exception exception){
                ifDivide.Text = "Введите число!";
            }
        }
    }
}
