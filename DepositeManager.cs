using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ViewerDiscrationIsAdvised{
    public class DepositeManager{
        private List<int> deposite = new List<int>();
        private CashManager _cashManager = new CashManager();

        public void Increase5(){
            deposite.Add(5);
            _cashManager.DecreaseCash(5);
        }

        public int ArraySum(){
            int sum = 0;
             for (int i = 0; i < deposite.Count; i++){
                 sum += deposite[i];
             }
             return sum;
        }
        
        public void Increase10(){
            deposite.Add(10);
            _cashManager.DecreaseCash(10);
        }

        public void PriceCheck(){
            if (ArraySum() >= Convert.ToInt32(Drinks.Пиво)){
                _cashManager.IncreaseCash(PaybackSuccess());
                MessageBox.Show("Пиво успешно куплено!");
                deposite.Clear();
            }
            else MessageBox.Show("Внесена недостаточная сумма");
        }

        public void Cancel(){
            PaybackCancel();
            deposite.Clear();
        }

        private void PaybackCancel(){
            _cashManager.IncreaseCash(ArraySum()); 
        }

        private int PaybackSuccess(){
            return ArraySum() - Convert.ToInt32(Drinks.Пиво);
        }
    }
}