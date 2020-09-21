namespace ds.test.impl
{
    /// <summary>
    /// Сумма двух чисел.
    /// </summary>
    class Sum : Plugin
    {
        public Sum() : base("Sum", "1.0", System.Drawing.Image.FromFile("Sum.jpg"), "Sums two integers.") { }

        public override int Run(int term1, int term2)
        {
            return term1 + term2;
        }
    }
}
