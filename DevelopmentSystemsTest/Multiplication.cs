namespace ds.test.impl
{
    /// <summary>
    /// Произведение двух чисел.
    /// </summary>
    class Multiplication : Plugin
    {
        public Multiplication() : base("Multiplication", "1.0", System.Drawing.Image.FromFile("Multiplication.jpg"), "Multiplication of two integers.") { }

        public override int Run(int int1, int int2)
        {
            return int1 * int2;
        }
    }
}
