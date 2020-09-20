namespace ds.test.impl
{
    public interface PluginFactory
    {
        int pluginsCount { get; }
        string[] GetPluginNames { get; }
        IPlugin GetPlugin(string pluginName);
    }
}
