using System;

namespace ViewerDiscrationIsAdvised{
    public class _2Task {
        private States state = States.НачальноеСостояние;

        public States GetState(){
            return state;
        }

        public enum States{
            НачальноеСостояние,
            Состояние1,
            Состояние2,
            Состояние3
        };
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
                    state = States.Состояние1;
                    return state.ToString();
                case 1:
                    state = States.Состояние2;
                    return state.ToString();
                case 2:
                    state = States.Состояние3;
                    return state.ToString();
            }
            return null;
        }
    }
}