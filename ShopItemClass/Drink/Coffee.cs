namespace UnACoffeeShop.ShopItemClass.Drink
{
    public class Coffee : DrinkItem
    {
        public override double Cost()
        {
            return base.Cost() + 2f;
        }
    }
}