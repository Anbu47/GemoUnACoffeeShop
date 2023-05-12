using UnACoffeeShop.ShopItemClass.Food;

namespace UnACoffeeShop.CondimentDecorator.BagelDecorator
{
    public class Butter : BagelDecorator
    {
        public override string GetDescription()
        {
            return _bagel.GetDescription() + ", Butter";
        }

        public override double Cost()
        {
            return _bagel.Cost();
        }

        public Butter(Bagel bagel) : base(bagel)
        {
        }
    }
}