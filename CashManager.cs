

using System;
using System.IO;
using System.Windows.Forms;

namespace ViewerDiscrationIsAdvised{
    public class CashManager{
        private int _current = 0;
        private string _path = Directory.GetCurrentDirectory() + "/cash.txt";
        public string renderManager(int cash){
            if (Convert.ToInt32(cash/1000) > 0 && Convert.ToInt32(cash/10000) == 0) 
                return Convert.ToString(cash / 1000) + "." + Convert.ToString(cash % 1000 / 100 ) + "к руб.";
            if (Convert.ToInt32(cash/10000) > 0 && Convert.ToInt32(cash/100000) == 0) 
                return Convert.ToString(cash / 1000) + "." + Convert.ToString(cash % 1000 / 100 ) + "к руб.";
            if (Convert.ToInt32(cash/100000) > 0 && Convert.ToInt32(cash/1000000) == 0) 
                return Convert.ToString(cash / 1000) + "." + Convert.ToString(cash % 1000 / 100 ) + "к руб.";
            if (Convert.ToInt32(cash/1000000) > 0 && Convert.ToInt32(cash/10000000) == 0) 
                return Convert.ToString(cash / 1000000) + "." + Convert.ToString(cash % 1000000 / 100000 ) + "м руб.";
            if (Convert.ToInt32(cash/10000000) > 0 && Convert.ToInt32(cash/100000000) == 0) 
                return Convert.ToString(cash / 1000000) + "." + Convert.ToString(cash % 1000000 / 100000 ) + "м руб.";
            if (Convert.ToInt32(cash / 100000000) > 0 && Convert.ToInt32(cash / 1000000000) == 0)
                return Convert.ToString(cash / 1000000) + "." + Convert.ToString(cash % 1000000 / 100000) + "м руб.";
            if (Convert.ToInt32(cash / 1000000000) > 0 && Convert.ToInt32(cash / 10000000000) == 0)
                return Convert.ToString(cash / 1000000) + "." + Convert.ToString(cash % 1000000 / 100000) + "м руб.";
            return cash.ToString();
        }

        public void CheckForLimitCash(){
            if (Convert.ToInt32(File.ReadAllText(_path)) > 1000000000){
                _current = Convert.ToInt32(File.ReadAllText(_path));
                File.WriteAllText(
                    _path, 
                    _current.ToString().Remove(9, 999999999)
                    );
            }
        }

        public void SetCash(){
            try{
                _current = Convert.ToInt32(File.ReadAllText(_path));
            }
            catch (Exception e){
                File.Create(_path);
                File.WriteAllText(_path, Convert.ToString(15));
            }
        }

        public void IncreaseCash(int Cash){
            SetCash();
            File.WriteAllText(_path,Convert.ToString(_current + Cash));
        }

        public void SaveCash(){
            
        }

        public void AddCash(int Cash){
            if (_current + Cash <= 100000000) _current += Cash;
            else MessageBox.Show("Внесена слишком большая сумма!");
        }

        public void DecreaseCash(int Cash){
            SetCash();
            File.WriteAllText(_path,Convert.ToString(_current - Cash));
        }
        
        public int GetCash(){
            SetCash();
            return _current;
        }
        private void Payback(int deposit){
            _current += deposit;
        }
    }
}