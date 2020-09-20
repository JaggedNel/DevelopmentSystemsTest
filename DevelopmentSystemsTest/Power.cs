namespace ds.test.impl
{
    class Power : Plugin
    {
        public Power() : base("Power", "1.0", System.Drawing.Image.FromFile("Pow.jpg"), "Rising an integer to the power.") { }

        public override int Run(int integer, int power)
        {
            if (power >= 0)
            {
                int res = 1;
                for (int i = power; i > 0; i--)
                    res *= integer;
                return res;
            }
            else
                return integer % 2 == 0 ? 0 : -1;
        }
    }
}
