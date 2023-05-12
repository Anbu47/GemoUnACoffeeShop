using UnACoffeeShop.ShopItemClass.Drink;

namespace UnACoffeeShop.CondimentDecorator.DrinkDecorator
{
    public class WhippedCream : DrinkCondimentDecorator
    {
        public WhippedCream(DrinkItem drink) : base(drink)
        {
            _drink = drink;
        }

        public override string GetDescription()
        {
            return _drink.GetDescription() + ", Whipped Cream";
        }

        public override double Cost()
        {
            return _drink.Cost() + 0.5f;
        }
    }
}