using Lesson_14.Interfaces;

namespace Lesson_14.Plugins
{
    public class PluginManager
    {
        private readonly List<IPlugin> _plugins = new();

        public void LoadPlugin(IPlugin plugin)
        {
            _plugins.Add(plugin);
        }

        public void ExecuteAll()
        {
            foreach (IPlugin plugin in _plugins)
            {
                plugin.Execute();
            }
        }
    }
}
