
namespace ViewerDiscrationIsAdvised{
    public class _2Task {
        public string Render(int number){
            return NumInnerSum(number) % 3 == 0 ? "Делится" : "Не делится";
        }

        private int NumInnerSum(int num){
            int sum = 0;
            for (int i = 0; i < num.ToString().Length; i++){
                sum += num.ToString()[i];
            }
            return sum;
        }
    }
}