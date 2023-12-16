using System;

namespace ViewerDiscrationIsAdvised{
    public class _2Task {
        private string Render(int number){
            return NumInnerSum(number) % 3 == 0 ? "Делится" : "Не делится";
        }

        private int NumInnerSum(int num){
            int sum = 0;
            for (int i = 0; i < num.ToString().Length; i++){
                sum += num.ToString()[i];
            }
            return sum;
        }

        public double DivideRemain(int num){
            return num % 3;
        }

        public string DivideRemainStates(int num){
            switch (num % 3){
                case 0:
                    return "Состояние 1";
                case 1:
                    return "Состояние 2";
                case 2:
                    return "Состояние 3";
            }
            return null;
        }
    }
}