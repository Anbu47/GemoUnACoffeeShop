using UnACoffeeShop.ShopItemClass.Food;

namespace UnACoffeeShop.CondimentDecorator.BagelDecorator
{
    public class CreamCheese : BagelDecorator
    {
        public CreamCheese(Bagel bagel) : base(bagel)
        {
        }

        public override string GetDescription()
        {
            return "Cream Cheese " + _bagel.GetDescription();
        }

        public override double Cost()
        {
            return _bagel.Cost() + 0.5f;
        }
    }
}