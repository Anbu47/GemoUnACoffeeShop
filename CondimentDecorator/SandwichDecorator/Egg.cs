﻿using UnACoffeeShop.ShopItemClass.Food;

namespace UnACoffeeShop.CondimentDecorator.SandwichDecorator
{
    public class Egg : SandwichDecorator
    {
        public Egg(Sandwich sandwich) : base(sandwich)
        {
            _sandwich = sandwich;
        }

        public override string GetDescription()
        {
            return _sandwich.GetDescription() + ", Egg";
        }

        public override double Cost()
        {
            return _sandwich.Cost();
        }
    }
}