namespace UnACoffeeShop.ShopItemClass.Drink
{
    class BlendedCoffee : Coffee
    {
        public BlendedCoffee()
        {
            _description = "Blended Coffee";
        }

        public override double Cost()
        {
            return base.Cost() + 1f;
        }
    }
}