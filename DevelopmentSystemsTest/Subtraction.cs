namespace ds.test.impl
{
    /// <summary>
    /// Разность двух чисел.
    /// </summary>
    class Subtraction : Plugin
    {
        public Subtraction() : base("Subtraction", "1.0", System.Drawing.Image.FromFile("Subtraction.jpg"), "Difference between two integers.") { }

        public override int Run(int reduced, int subtracted)
        {
            return reduced - subtracted;
        }
    }
}
