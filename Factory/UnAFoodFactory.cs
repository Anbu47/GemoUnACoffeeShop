using System;
using UnACoffeeShop.CondimentDecorator.BagelDecorator;
using UnACoffeeShop.CondimentDecorator.SandwichDecorator;
using UnACoffeeShop.ShopItemClass;
using UnACoffeeShop.ShopItemClass.Food;

namespace UnACoffeeShop.Factory
{
    public class UnAFoodFactory : UnAShopFactory
    {
        public enum FoodType
        {
            SANDWICH,
            BAGEL,
        }

        public enum SandwichType
        {
            EGG,
            TURKEY
        }

        public enum BagelType
        {
            BUTTER,
            CREAMCHEESE,
        }

        public override ShopItem Order()
        {
            Console.WriteLine("What kind of food do you want to order?\n"
                              + "Sandwich (0) | Bagel (1)");
            var foodTypeNames = Enum.GetNames(typeof(FoodType));
            var foodTypeAnswer = Int32.Parse(Console.ReadLine() ?? string.Empty);
            while (foodTypeAnswer < 0 || foodTypeAnswer > foodTypeNames.Length - 1)
            {
                Console.WriteLine("Wrong value input please re-input!\n"
                                  + "Sandwich (0) | Bagel (1)");
                foodTypeAnswer = Int32.Parse(Console.ReadLine() ?? string.Empty);
            }

            var fitem = new Sandwich();
            switch ((FoodType)foodTypeAnswer)
            {
                case FoodType.SANDWICH:
                    var sandwich = new Sandwich();
                    Console.WriteLine("What kind of sandwich do you want?\n"
                                      + "Egg (0) | Turkey (1)");
                    var sandwichTypeNames = Enum.GetNames(typeof(UnAFoodFactory.SandwichType));
                    var sandwichType = Int32.Parse(Console.ReadLine());
                    while (sandwichType < 0 || sandwichType > sandwichTypeNames.Length - 1)
                    {
                        Console.WriteLine("Wrong value input please re-input!\n" +
                                          "Egg (0) | Turkey (1)");
                        sandwichType = Int32.Parse(Console.ReadLine() ?? string.Empty);
                    }

                    switch ((UnAFoodFactory.SandwichType)sandwichType)
                    {
                        case UnAFoodFactory.SandwichType.EGG:
                            sandwich = new Egg(sandwich);
                            break;
                        case UnAFoodFactory.SandwichType.TURKEY:
                            sandwich = new Turkey(sandwich);
                            break;
                    }

                    return sandwich;
                case FoodType.BAGEL:
                    var bagel = new Bagel();
                    Console.WriteLine("What kind of bagel do you want?\n"
                                      + "Butter (0) | Cream cheese (1)");
                    var bagelTypeNames = Enum.GetNames(typeof(UnAFoodFactory.BagelType));
                    var bagelType = Int32.Parse(Console.ReadLine());
                    while (bagelType < 0 || bagelType > bagelTypeNames.Length - 1)
                    {
                        Console.WriteLine("Wrong value input please re-input!\n"
                                          + "Butter (0) | Cream cheese (1)");
                        bagelType = Int32.Parse(Console.ReadLine() ?? string.Empty);
                    }

                    switch ((UnAFoodFactory.BagelType)bagelType)
                    {
                        case UnAFoodFactory.BagelType.BUTTER:
                            bagel = new Butter(bagel);
                            break;
                        case UnAFoodFactory.BagelType.CREAMCHEESE:
                            bagel = new CreamCheese(bagel);
                            break;
                    }

                    return bagel;
                default:
                    return null;
            }
        }
    }
}