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
            return "Turkey " + _sandwich.GetDescription();
        }

        public override double Cost()
        {
            return _sandwich.Cost() + 1f;
        }
    }
}