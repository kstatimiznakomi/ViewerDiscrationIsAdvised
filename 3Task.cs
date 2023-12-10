
using System;
using System.Windows.Forms;

namespace ViewerDiscrationIsAdvised {
    internal class _3Task{
        private CashManager _cashManager = new CashManager();
        private int deposit = 0;

        private Boolean check(int deposite){
            return deposit == 15;
        }

        public void PayForDrink(){
            _cashManager.DecreaseCash(15);
            MessageBox.Show("Пиво успешно куплено!");
        }

        private void SetDeposite(int newDeposit){
            if (newDeposit % 5 == 0) deposit += newDeposit;
            else MessageBox.Show("Внесение монет достоинством 5 или 10 рублей");
        }

        private void Cancel(){
            MessageBox.Show("Покупка отменена");
        }
    }
}
