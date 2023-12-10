using System;
using System.IO;
using System.Windows.Forms;

namespace ViewerDiscrationIsAdvised{
    public partial class BalanceImprove : Form{
        private _3Task task3 = new _3Task();
        private CashManager _manager = new CashManager();
        public BalanceImprove(){
            InitializeComponent();
        }
        
        private void cancel_Click(object sender, EventArgs e){
            this.Close();
        }

        private void pay_Click(object sender, EventArgs e){
            try{
                _manager.IncreaseCash(Int32.Parse(textBox1.Text));
                Form1 form1 = (Form1)this.Owner;
                form1.SetBalanceOnForm();
                this.Close();
            }
            catch (Exception exception){
                MessageBox.Show("Введите число");
            }
        }
    }
}