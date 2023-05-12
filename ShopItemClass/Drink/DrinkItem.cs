using System;

namespace UnACoffeeShop.ShopItemClass.Drink
{
    public enum MilkType
    {
        WHOLE,
        ALMOND,
    }

    public abstract class DrinkItem : ShopItem
    {
        public enum Size
        {
            S,
            M,
            L,
            XL,
        }

        private Size _size;

        public void SetSize(Size size)
        {
            _size = size;
        }

        public override string GetDescription()
        {
            var size = Enum.GetNames(typeof(Size))[(int)_size];
            return _description + $", {size}";
        }

        private double GetSizeCost()
        {
            switch (_size)
            {
                case Size.S:
                    return 0;
                case Size.M:
                    return 0.5f;
                case Size.L:
                    return 1.0f;
                case Size.XL:
                    return 1.5f;
                default:
                    return 0;
            }
        }

        public override double Cost()
        {
            return GetSizeCost();
        }
    }
}