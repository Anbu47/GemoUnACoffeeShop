using UnACoffeeShop.ShopItemClass.Food;

namespace UnACoffeeShop.CondimentDecorator.BagelDecorator
{
    public class Butter : BagelDecorator
    {
        public Butter(Bagel bagel) : base(bagel)
        {
        }

        public override string GetDescription()
        {
            return "Butter " + _bagel.GetDescription();
        }

        public override double Cost()
        {
            return _bagel.Cost() + 0.5f;
        }
    }
}