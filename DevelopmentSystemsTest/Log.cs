namespace ds.test.impl
{
    class Log : Plugin
    {
        public Log() : base("Log", "1.0", System.Drawing.Image.FromFile("Log.jpg"), "Logarithm of integer on basis.") { }

        public override int Run(int integer, int basis)
        {
            if (basis == 0 || integer == 0 || basis > 0 && integer < 0 || integer >= 0 && integer <= 1)
                return 0;
            if (integer <= basis && -integer <= -basis)
                return 1;

            int i = -1;
            int t;
            int mod = integer > 0 ? 1 : -1;
            int mod2 = basis > 0 ? 1 : -1;
            do
            {
                i++;
                t = mod2 * basis;
                for (int k = i - 1; k > 0; k--)
                    t *= mod2 * basis;
            } while (t < mod * integer);
            if (basis < 0 && integer > 0 && i % 2 == 0)
                return 0;
            else
                return i;
        }
    }
}
