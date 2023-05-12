namespace UnACoffeeShop.ShopItemClass.Food
{
    public abstract class FoodItem : ShopItem
    {
        public override string GetDescription()
        {
            return _description;
        }

        public override double Cost()
        {
            return 3f;
        }
    }
}