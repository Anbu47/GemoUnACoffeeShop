namespace UnACoffeeShop.ShopItemClass.Drink
{
    class HotCoffee : Coffee
    {
        private bool _chocoSauce = false;
        private int _numberOfPump = 0;
        private const int MAX_CHOCO_PUMP = 6;
        private const int FREE_CHOCO_PUMP_AMOUNT = 2;

        public bool AddChoco(int pump)
        {
            if (pump > MAX_CHOCO_PUMP)
            {
                Console.WriteLine("You exceed the maximum pumps limit. Your order will be 6 pumps.");
                _numberOfPump = MAX_CHOCO_PUMP;
            }
            // return false;
            else
            {
                _numberOfPump = pump;
            }
            _description = $"Hot Coffee, Choco Sauce x{_numberOfPump}";
            return true;
        }

        public HotCoffee()
        {
            _description = "Hot Coffee";
        }

        private double GetChocoPumpCost()
        {
            if (_numberOfPump > FREE_CHOCO_PUMP_AMOUNT)
            {
                return (_numberOfPump - FREE_CHOCO_PUMP_AMOUNT) * 0.5f;
            }
            else
            {
                return 0;
            }
            // return (_numberOfPump > 2 ? (_numberOfPump - FREE_CHOCO_PUMP_AMOUNT) * 0.5f : 0);
        }

        public override double Cost()
        {
            return base.Cost() + GetChocoPumpCost();
        }
    }
}