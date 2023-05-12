using UnACoffeeShop.CondimentDecorator.DrinkDecorator;
using UnACoffeeShop.Factory;
using UnACoffeeShop.ShopItemClass;
using UnACoffeeShop.ShopItemClass.Drink;

namespace UnACoffeeShop
{
    internal class Program
    {
        public static UnADrinkFactory UnADrinkFactory = new UnADrinkFactory();
        public static UnAFoodFactory UnAFoodFactory = new UnAFoodFactory();

        public static void Main(string[] args)
        {
            //calculatePrice1();
            //calculatePrice2();
            //calculatePrice3();
            //calculatePrice4();
            calculatePrice5();
        }


        public static void PrintItem(ShopItem item)
        {
            Console.Write($"Item: {item.GetDescription()} | Cost: {item.Cost()}$\n");
            // Console.Write($"item cost: {item.Cost()}\n");
        }

        public static void calculatePrice1()
        {
            //
            var item = UnADrinkFactory.Order();
            Console.WriteLine("Do you want whipped cream? \n"
                              + "No (0) | Yes (1)");
            var input = Console.ReadLine();
            while (input != "1" && input != "0")
            {
                Console.WriteLine("Wrong value input please re-input!\n" +
                                  "No (0) | Yes (1)");
                input = Console.ReadLine();
            }

            if (input == "1")
            {
                item = new WhippedCream((DrinkItem)item);
            }

            Console.WriteLine();
            PrintItem(item);
        }
        public static void calculatePrice2()
        {
            var item = UnADrinkFactory.Order();
            Console.WriteLine("Do you want whipped cream?\n"
                              + "No (0) | Yes (1)");

            var input = Console.ReadLine();
            while (input != "1" && input != "0")
            {
                Console.WriteLine("Wrong value input please re-input!\n" +
                                  "No (0) | Yes (1)");
                input = Console.ReadLine();
            }

            if (input == "1")
            {
                item = new WhippedCream((DrinkItem)item);
            }

            Console.WriteLine("Do you want extra milk?\n"
                              + "No (0) | Yes (1)");
            input = Console.ReadLine();
            while (input != "1" && input != "0")
            {
                Console.WriteLine("Wrong value input please re-input!\n" +
                                  "No (0) | Yes (1)");
                input = Console.ReadLine();
            }

            if (input == "1")
            {
                Console.WriteLine("Extra milk options: ");
                var milkTypeNames = Enum.GetNames(typeof(MilkType));
                Console.WriteLine(" Whole Milk (0) | Almond Milk (1)");

                var milkType = Int32.Parse(Console.ReadLine());
                while (milkType < 0 || milkType > milkTypeNames.Length - 1)
                {
                    Console.WriteLine("Wrong value input please re-input!\n"
                                      + "Whole Milk (0) | Almond Milk (1)");
                    milkType = Int32.Parse(Console.ReadLine() ?? string.Empty);
                }

                switch ((MilkType)milkType)
                {
                    case MilkType.WHOLE:
                        item = new WholeMilk((DrinkItem)item);
                        break;
                    case MilkType.ALMOND:
                        item = new AlmondMilk((DrinkItem)item);
                        break;
                }
            }

            PrintItem(item);
        }
        public static void calculatePrice3()
        {
            PrintItem(OrderDrink());
        }
        public static void calculatePrice4()
        {
            PrintItem(OrderFood());
        }
        public static void calculatePrice5()
        {
            List<ShopItem> items = new List<ShopItem>();

            var orderInput = "";
            var orderIndex = 1;
            while (true)
            {
                Console.WriteLine("Item No." + orderIndex + "\n Order Type: " +
                                  "Drink (0) | Food (1)");
                var orderType = Console.ReadLine();
                switch (orderType)
                {
                    case "0":
                        items.Add(OrderDrink());
                        break;
                    case "1":
                        items.Add(OrderFood());
                        break;
                    default:
                        Console.WriteLine("Wrong value input please re-input!");
                        continue;
                }

                Console.WriteLine("Enter C to checkout, enter any key to continue.");
                orderInput = Console.ReadLine();
                if (orderInput == "C" || orderInput == "c")
                    break;
                orderIndex++;
            }

            double totalPrice = 0;
            foreach (var shopItem in items)
            {
                PrintItem(shopItem);
                totalPrice += shopItem.Cost();
            }

            Console.WriteLine($"Tax: 7.25%. Total Price: {(totalPrice * 1.0725f):0.00}$");
        }
        public static ShopItem OrderDrink()
        {
            var item = UnADrinkFactory.Order();
            if (item is HotCoffee coffee)
            {
                Console.WriteLine("You choose hot drink. Do you want extra chocolate sauce?\n"
                                  + "No(0) | Yes (1)");
                ;
                var answer = Console.ReadLine();
                if (answer == "1")
                {
                    Console.WriteLine("The first 2 pumps are free. How many pump(s) do you want?");
                    coffee.AddChoco(Int32.Parse(Console.ReadLine()));
                }
            }

            Console.WriteLine("Do you want whipped cream?\n"
                              + "No (0) | Yes (1)");

            var input = Console.ReadLine();
            while (input != "1" && input != "0")
            {
                Console.WriteLine("Wrong value input please re-input!\n" +
                                  "No (0) | Yes (1)");
                input = Console.ReadLine();
            }

            if (input == "1")
            {
                item = new WhippedCream((DrinkItem)item);
            }

            Console.WriteLine("Do you want extra milk?\n"
                              + "No (0) | Yes (1)");
            input = Console.ReadLine();
            while (input != "1" && input != "0")
            {
                Console.WriteLine("Wrong value input please re-input!\n" +
                                  "No (0) | Yes (1)");
                input = Console.ReadLine();
            }

            if (input == "1")
            {
                Console.WriteLine("Extra milk options: ");
                var milkTypeNames = Enum.GetNames(typeof(MilkType));
                Console.WriteLine(" Whole Milk (0) | Almond Milk (1) ");

                var milkType = Int32.Parse(Console.ReadLine());
                while (milkType < 0 || milkType > milkTypeNames.Length - 1)
                {
                    Console.WriteLine("Wrong value input please re-input!\n"
                                      + "Whole Milk (0) | Almond Milk (1)");
                    milkType = Int32.Parse(Console.ReadLine() ?? string.Empty);
                }

                switch ((MilkType)milkType)
                {
                    case MilkType.WHOLE:
                        item = new WholeMilk((DrinkItem)item);
                        break;
                    case MilkType.ALMOND:
                        item = new AlmondMilk((DrinkItem)item);
                        break;
                }
            }

            return item;
        }
        public static ShopItem OrderFood()
        {
            ShopItem item = UnAFoodFactory.Order();
            return item;
        }
    }
}