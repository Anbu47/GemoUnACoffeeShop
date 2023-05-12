using UnACoffeeShop.ShopItemClass;
using UnACoffeeShop.ShopItemClass.Drink;

namespace UnACoffeeShop.CondimentDecorator
{
    public abstract class DrinkCondimentDecorator : DrinkItem
    {
        protected DrinkItem _drink;

        public DrinkCondimentDecorator(DrinkItem drink)
        {
            _drink = drink;
        }
    }
}