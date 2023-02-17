using System.ComponentModel.DataAnnotations;

namespace CoffeeLibrary
{
    public class CoffeeMachine
    {
        private int _money = 0;
        private List<KeyValuePair<string, int>> _list = new List<KeyValuePair<string, int>>() { 
            new KeyValuePair<string, int>("Coffe", 120),
            new KeyValuePair<string, int>("Capuchino", 100),
            new KeyValuePair<string, int>("Expresso", 80)
        };

        private int _change = 0;




        public int SetCoins(int[] coins)
        {


            for (int i = 0; i < coins.Length; i++)
            {
                if (coins[i] <= 0)
                {
                    throw new ArgumentException("Coin value cannot be zero or negative ");
                }
                _money += coins[i];
            }


            return _money;

        }



        public int GetCoins()
        {
   
            return _money;
        }


        public Boolean GetDrink(string coffeType)
        {
            int coffePrice = 0;
            bool flag = true;
            foreach (var value in _list)
            {
                if (value.Key == coffeType)
                {   
                    flag = false;
                    coffePrice = value.Value;
                    break;
                }
            }

            if(flag) { throw new ArgumentException("Wrong coffe type !"); }



            if (_money < coffePrice)
            {
                throw new Exception("Not Enough Money !");
            }



            if (_money > coffePrice)
            {
                _change = _money - coffePrice;
            }

            return true;

            

        }


        public int ReturnChange()
        {
            if (_change !=0)
            {
                return _change;
            }
            else
            {
                return _change;
            }
        }


    }
}