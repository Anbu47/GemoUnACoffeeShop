using UnACoffeeShop.ShopItemClass;
using UnACoffeeShop.ShopItemClass.Food;

namespace UnACoffeeShop.CondimentDecorator.SandwichDecorator
{
    public abstract class SandwichDecorator : Sandwich
    {
        protected Sandwich _sandwich;

        public SandwichDecorator(Sandwich sandwich)
        {
            _sandwich = sandwich;
        }
    }
}