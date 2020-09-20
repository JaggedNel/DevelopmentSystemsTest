namespace ds.test.impl
{
    class Remnant : Plugin
    {
        public Remnant() : base("Remnant", "1.0", System.Drawing.Image.FromFile("Remnant.jpg"), "Remainder of division of two integers.") { }

        public override int Run(int divisible, int divisor)
        {
            return divisor == 0 ? 0 : (divisible % divisor);
        }
    }
}
