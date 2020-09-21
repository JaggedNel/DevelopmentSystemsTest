namespace ds.test.impl
{
    /// <summary>
    /// Получение среднего двух чисел.
    /// </summary>
    class Average : Plugin
    {
        public Average() : base("Average", "1.0", System.Drawing.Image.FromFile("Average.jpg"), "Avetage of two integers") { }

        public override int Run(int integer1, int integer2)
        {
            return (integer1 + integer2) / 2;
        }
    }
}
