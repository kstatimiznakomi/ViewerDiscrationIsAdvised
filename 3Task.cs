
using System;
using System.Windows.Forms;

namespace ViewerDiscrationIsAdvised {
    internal class _3Task{
        private CashManager _cashManager = new CashManager();
        private DepositeManager _depositeManager = new DepositeManager();
        

        public void PayForDrink(){
            _depositeManager.PriceCheck();
        }

        public string GetDeposit(){
            return _depositeManager.ArraySum() + " руб.";
        }

        public void SetDeposite5(){
            _depositeManager.Increase5();
            MessageBox.Show("Внесено 5 рублей");
        }

        public void SetDeposite10(){
            _depositeManager.Increase10();
            MessageBox.Show("Внесено 10 рублей");
        }

        public void Cancel(){
            _depositeManager.Cancel();
            MessageBox.Show("Покупка отменена");
        }
    }
}
