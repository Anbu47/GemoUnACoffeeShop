using UnACoffeeShop.ShopItemClass.Drink;

namespace UnACoffeeShop.CondimentDecorator.DrinkDecorator
{
    public class WholeMilk : DrinkCondimentDecorator
    {
        public WholeMilk(DrinkItem drink) : base(drink)
        {
            _drink = drink;
        }

        public override string GetDescription()
        {
            return _drink.GetDescription() + ", Whole Milk";
        }

        public override double Cost()
        {
            return _drink.Cost();
        }
    }
}