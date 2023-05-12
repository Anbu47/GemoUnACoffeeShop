namespace UnACoffeeShop.ShopItemClass
{
    public abstract class ShopItem
    {
        protected string _description = "Shop Item";
        public abstract string GetDescription();
        public abstract double Cost();
    }
}