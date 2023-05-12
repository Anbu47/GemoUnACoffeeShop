using UnACoffeeShop.ShopItemClass;
using UnACoffeeShop.ShopItemClass.Food;

namespace UnACoffeeShop.CondimentDecorator.BagelDecorator
{
    public abstract class BagelDecorator : Bagel
    {
        protected Bagel _bagel;

        public BagelDecorator(Bagel bagel)
        {
            _bagel = bagel;
        }
    }
}