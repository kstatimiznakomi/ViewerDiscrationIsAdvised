namespace ViewerDiscrationIsAdvised {
    internal class _1Task{
        private string numberType = "";
        public string GetState(string number){
            if (number.Contains(".") && number.StartsWith(".")){
                SetNumberType("Дробное число с пустой целой частью");
                return "2";
            }

            if (number.Contains(".") && !number.StartsWith(".") && !number.EndsWith(".")){
                SetNumberType("Число с целой и дробной частью");
                return "3";
            }
            SetNumberType("Целое число");
            return "1";
        }

        public void SetNumberType(string type){
            this.numberType = type;
        }

        public string GetNumberType(){
            return this.numberType;
        }
    }
}
