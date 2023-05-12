namespace UnACoffeeShop.ShopItemClass.Drink
{
    class MilkTea : DrinkItem
    {
        public MilkTea()
        {
            _description = "Milk Tea";
        }

        public override double Cost()
        {
            return base.Cost() + 2.25f;
        }
    }
}