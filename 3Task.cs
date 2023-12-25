using System.Windows.Forms;

namespace ViewerDiscrationIsAdvised {
    internal class _3Task{
        private DepositeManager _depositeManager = new DepositeManager();
        private States state = States.НачальноеСостояние;

        public States GetState(){
            return state;
        }

        public enum States{
            НачальноеСостояние,
            РублейВнесено5,
            РублейВнесено10,
            РублейВнесено15,
            ВнесеноБольше15Рублей
        };

        public void PayForDrink(){
            switch (state){
                case States.НачальноеСостояние:
                    MessageBox.Show("Внесена недостаточная сумма");
                    MessageBox.Show(state.ToString());
                    break;
                case States.РублейВнесено5:
                    MessageBox.Show("Внесена недостаточная сумма");
                    MessageBox.Show(state.ToString());
                    break;
                case States.РублейВнесено10:
                    MessageBox.Show("Внесена недостаточная сумма");
                    MessageBox.Show(state.ToString());
                    break;
                case States.РублейВнесено15:
                    _depositeManager.Pay();
                    state = States.НачальноеСостояние;
                    MessageBox.Show(state.ToString());
                    break;
                case States.ВнесеноБольше15Рублей:
                    _depositeManager.Pay();
                    state = States.НачальноеСостояние;
                    MessageBox.Show(state.ToString());
                    break;
            }
        }

        public string GetDeposit(){
            return _depositeManager.ArraySum() + " руб.";
        }

        public void SetDeposite5(){
            switch (state){
                case States.НачальноеСостояние:
                    _depositeManager.Increase5();
                    MessageBox.Show("Внесено 5 рублей");
                    state = States.РублейВнесено5;
                    MessageBox.Show(state.ToString());
                    break;
                case States.РублейВнесено5:
                    _depositeManager.Increase5();
                    MessageBox.Show("Внесено 5 рублей");
                    state = States.РублейВнесено10;
                    MessageBox.Show(state.ToString());
                    break;
                case States.РублейВнесено10:
                    _depositeManager.Increase5();
                    MessageBox.Show("Внесено 5 рублей");
                    state = States.РублейВнесено15;
                    MessageBox.Show(state.ToString());
                    break;
                case States.РублейВнесено15:
                    _depositeManager.Increase5();
                    MessageBox.Show("Внесено 5 рублей");
                    state = States.ВнесеноБольше15Рублей;
                    MessageBox.Show(state.ToString());
                    break;
                case States.ВнесеноБольше15Рублей:
                    _depositeManager.Increase5();
                    MessageBox.Show("Внесено 5 рублей");
                    state = States.ВнесеноБольше15Рублей;
                    MessageBox.Show(state.ToString());
                    break;
            }
        }

        public void SetDeposite10(){
            switch (state){
                case States.НачальноеСостояние:
                    _depositeManager.Increase10();
                    MessageBox.Show("Внесено 10 рублей");
                    state = States.РублейВнесено10;
                    MessageBox.Show(state.ToString());
                    break;
                case States.РублейВнесено10:
                    _depositeManager.Increase10();
                    MessageBox.Show("Внесено 10 рублей");
                    state = States.ВнесеноБольше15Рублей;
                    MessageBox.Show(state.ToString());
                    break;
                case States.ВнесеноБольше15Рублей:
                    _depositeManager.Increase10();
                    MessageBox.Show("Внесено 10 рублей");
                    state = States.ВнесеноБольше15Рублей;
                    MessageBox.Show(state.ToString());
                    break;
            }
        }

        public void Cancel(){
            _depositeManager.Cancel();
            MessageBox.Show("Покупка отменена");
        }
    }
}
