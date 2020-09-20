namespace ds.test.impl
{
    class Division : Plugin
    {
        public Division() : base("Division", "1.0", System.Drawing.Image.FromFile("Division.jpg"), "The quotient of two integers.") { }

        public override int Run(int divisible, int divisor)
        {
            return divisor == 0 ? int.MaxValue : (divisible / divisor);
        }
    }
}
