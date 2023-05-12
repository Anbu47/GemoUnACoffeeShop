using UnACoffeeShop.ShopItemClass.Food;

namespace UnACoffeeShop.CondimentDecorator.SandwichDecorator
{
    public class Turkey : SandwichDecorator
    {
        public Turkey(Sandwich sandwich) : base(sandwich)
        {
        }

        public override string GetDescription()
        {
            return _sandwich.GetDescription() + ", Turkey";
        }

        public override double Cost()
        {
            return _sandwich.Cost() + 1f;
        }
    }
}