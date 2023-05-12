using UnACoffeeShop.ShopItemClass.Drink;

namespace UnACoffeeShop.CondimentDecorator.DrinkDecorator
{
    public class AlmondMilk : DrinkCondimentDecorator
    {
        public AlmondMilk(DrinkItem drink) : base(drink)
        {
            _drink = drink;
        }

        public override string GetDescription()
        {
            return _drink.GetDescription() + ", Almond Milk";
        }

        public override double Cost()
        {
            return _drink.Cost() + 0.5f;
        }
    }
}