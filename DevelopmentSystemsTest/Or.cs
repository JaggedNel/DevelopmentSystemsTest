namespace ds.test.impl
{
    class Or : Plugin
    {
        public Or() : base("Or", "1.0", System.Drawing.Image.FromFile("Or.jpg"), "Or-bit operation for two integers.") { }

        public override int Run(int integer1, int integer2)
        {
            return integer1 | integer2;
        }
    }
}
