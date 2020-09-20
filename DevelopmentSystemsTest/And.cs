namespace ds.test.impl
{
    class And : Plugin
    {
        public And() : base("And", "1.0", System.Drawing.Image.FromFile("And.jpg"), "And-bit opetation for two integers.") { }

        public override int Run(int integer1, int integer2)
        {
            return integer1 & integer2;
        }
    }
}
