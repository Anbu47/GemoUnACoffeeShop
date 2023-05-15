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
            SANDWICH = 0,
            SANDWICH_EGG,
            SANDWICH_TURKEY,
        }

        public enum BagelType
        {
            BAGEL = 0,
            BAGEL_BUTTER,
            BAGEL_CREAMCHEESE,
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
                                      + "Sandwich (0) | Egg Sandwich (1) | Turkey Sanwich (2)");
                    var sandwichTypeNames = Enum.GetNames(typeof(UnAFoodFactory.SandwichType));
                    var sandwichType = Int32.Parse(Console.ReadLine());
                    while (sandwichType < 0 || sandwichType > sandwichTypeNames.Length - 1)
                    {
                        Console.WriteLine("Wrong value input please re-input!\n" +
                                          "Sandwich (0) | Egg Sandwich (1) | Turkey Sanwich (2)");
                        sandwichType = Int32.Parse(Console.ReadLine() ?? string.Empty);
                    }

                    switch ((UnAFoodFactory.SandwichType)sandwichType)
                    {
                        case UnAFoodFactory.SandwichType.SANDWICH_EGG:
                            sandwich = new Egg(sandwich);
                            break;
                        case UnAFoodFactory.SandwichType.SANDWICH_TURKEY:
                            sandwich = new Turkey(sandwich);
                            break;
                    }

                    return sandwich;
                case FoodType.BAGEL:
                    var bagel = new Bagel();
                    Console.WriteLine("What kind of bagel do you want?\n"
                                      + "Bagel (0) | Butter Bagel (1) | Cream Cheese Bagel (2)");
                    var bagelTypeNames = Enum.GetNames(typeof(UnAFoodFactory.BagelType));
                    var bagelType = Int32.Parse(Console.ReadLine());
                    while (bagelType < 0 || bagelType > bagelTypeNames.Length - 1)
                    {
                        Console.WriteLine("Wrong value input please re-input!\n"
                                          + "Bagel (0) | Butter Bagel (1) | Cream Cheese Bagel (2)");
                        bagelType = Int32.Parse(Console.ReadLine() ?? string.Empty);
                    }

                    switch ((UnAFoodFactory.BagelType)bagelType)
                    {
                        case UnAFoodFactory.BagelType.BAGEL_BUTTER:
                            bagel = new Butter(bagel);
                            break;
                        case UnAFoodFactory.BagelType.BAGEL_CREAMCHEESE:
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