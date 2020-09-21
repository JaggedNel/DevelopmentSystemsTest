namespace ds.test.impl
{
    /// <summary>
    /// Получение максимального из двух чисел.
    /// </summary>
    class Max : Plugin
    {
        public Max() : base("Max", "1.0", System.Drawing.Image.FromFile("Max.jpg"), "Maximum of two integers.") { }

        public override int Run(int integer1, int integer2)
        {
            return integer1 >= integer2 ? integer1 : integer2;
        }
    }
}
