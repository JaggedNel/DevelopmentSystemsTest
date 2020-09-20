using System;
using System.Linq;

namespace ds.test.impl
{
    public class Plugins : PluginFactory
    {
        static readonly Plugins instance = new Plugins();
        readonly IPlugin[] plugins = new IPlugin[]
        {
            new Sum(), new Subtraction(), new Multiplication(), new Division(),
            new Remnant(), new Root(), new And(), new Or(),
            new Average(), new Max(), new Min(), new Log(),
            new Power()
        };

        public static Plugins GetPlugins()
        {
            return instance;
        }
        
        public int pluginsCount => plugins.GetLength(0);

        public string[] GetPluginNames => plugins.Select(x => x.PluginName).ToArray();

        public IPlugin GetPlugin(string pluginName) => Array.Find(plugins, x => x.PluginName == pluginName);
    }
}
