using System;
using System.Linq;

namespace ViewerDiscrationIsAdvised{
    public class _4Task {
        private int ToTrenary(int num){
            string number = "";
            while (num > 0){
                number += (num % 3).ToString();
                num /= 3;
            }
            return Convert.ToInt32(number.ToCharArray().Reverse().ToString());
        }

        public string DivideByFour(int trenaryNumber){
            return null;
        }
    }
}