using System;
using System.Net.Security;
using UnACoffeeShop.ShopItemClass;
using UnACoffeeShop.ShopItemClass.Drink;

namespace UnACoffeeShop.Factory
{
    public class UnADrinkFactory : UnAShopFactory
    {
        public enum DrinkType
        {
            HOT_COFFEE,
            COLD_COFFEE,
            BLENDED_COFFEE,
            MILKTEA,
        }

        public override ShopItem Order()
        {
            DrinkItem shopItem = null;
            Console.WriteLine("What kind of drink do you want to order?\n" 
                + "Hot Coffee (0) | Cold Coffee (1) | Blended Coffee (2) | Milktea (3)");
            var drinkTypeNames = Enum.GetNames(typeof(DrinkType));
            var drinkTypeAnswer = Int32.Parse(Console.ReadLine() ?? string.Empty);
            while (drinkTypeAnswer < 0 || drinkTypeAnswer > drinkTypeNames.Length - 1)
            {
                Console.WriteLine("Wrong value input please re-input!\n" +
                    "Hot Coffee (0) | Cold Coffee (1) | Blended Coffee (2) | Milktea (3)");
                drinkTypeAnswer = Int32.Parse(Console.ReadLine() ?? string.Empty);
            }

            Console.WriteLine("Size?\n"
                + "S (0) | M (1) | L (2) | XL (3)");
            var sizeTypeNames = Enum.GetNames(typeof(DrinkItem.Size));
            var drinkSizeAnswer = Int32.Parse(Console.ReadLine() ?? string.Empty);
            
            //For Hot Coffee only =)) 
            while (drinkTypeAnswer == 0)
            {
                if (drinkSizeAnswer == 2)
                {
                    Console.WriteLine("Sorry. We don't have Hot Coffee size L. Please re-input!\n"
                        + "S(0) | M(1) | XL(3)");
                    drinkSizeAnswer = Int32.Parse(Console.ReadLine() ?? string.Empty);
                }
                else if (drinkSizeAnswer < 0 || drinkSizeAnswer > sizeTypeNames.Length - 1)
                {
                    Console.WriteLine("Wrong value input please re-input!\n"
                        + "S(0) | M(1) | XL(3)");
                    drinkSizeAnswer = Int32.Parse(Console.ReadLine() ?? string.Empty);
                }
                else break;
            }

            while (drinkSizeAnswer < 0 || drinkSizeAnswer > sizeTypeNames.Length - 1)
            {
                Console.WriteLine("Wrong value input please re-input!\n"
                    + "S (0) | M (1) | L (2) | XL (3)");
                drinkSizeAnswer = Int32.Parse(Console.ReadLine() ?? string.Empty);
            }

            DrinkType drinkType = (DrinkType)drinkTypeAnswer;
            DrinkItem.Size drinkSize = (DrinkItem.Size)drinkSizeAnswer;
            switch (drinkType)
            {
                case DrinkType.HOT_COFFEE:
                    shopItem = new HotCoffee();
                    break;
                    ;
                case DrinkType.COLD_COFFEE:
                    shopItem = new ColdCoffee();
                    break;
                case DrinkType.BLENDED_COFFEE:
                    shopItem = new BlendedCoffee();
                    break;
                case DrinkType.MILKTEA:
                    shopItem = new MilkTea();
                    break;
            }

            shopItem.SetSize(drinkSize);
            return shopItem;
        }
    }
}