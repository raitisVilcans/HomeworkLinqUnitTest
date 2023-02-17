using CoffeeLibrary;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace CoffeTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var coffeMachine = new CoffeeMachine();


            int[] array1 = new int[] {120, 10 };

            coffeMachine.SetCoins(array1);

            Assert.AreEqual(true, coffeMachine.GetDrink("Coffe"));

            Assert.AreEqual(10, coffeMachine.ReturnChange());
        }


  



        [TestMethod]
        public void CheckSetCoinsMethodOnExceptionWhenPassingNegativeValue()
        {
            var coffeMachine = new CoffeeMachine();
            int[] array1 = new int[] { 10, 0 , -100 };

      
            Assert.ThrowsException<ArgumentException>(() => coffeMachine.SetCoins(array1));


        }

        [TestMethod]
        public void CheckGetDrinkOnExceptionWithWrongCoffetype()
        {
            var coffeMachine = new CoffeeMachine();
            int[] array1 = new int[] { 10, 40, 100 };
            coffeMachine.SetCoins(array1);

            Assert.ThrowsException<ArgumentException>(() => coffeMachine.GetDrink("Juice"));


        }


        [TestMethod]
        public void CheckGetDrinkOnExceptionWhenThereIsNotEnoughMoneyToBuyDrink()
        {
            var coffeMachine = new CoffeeMachine();
            int[] array1 = new int[] { 10, 40, 1 };
            coffeMachine.SetCoins(array1);

            Assert.ThrowsException<Exception>(() => coffeMachine.GetDrink("Coffe"));


        }




    }
}