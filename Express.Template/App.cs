using Express.Template.Modules.Api;

namespace Express.Template
{
    public class App
    {
        private IModule[] _modules;

        public void Start()
        {
            _modules = new IModule[]
            {
                new ApiModule()
            };
            foreach (var module in _modules)
            {
                module.Start();
            }
        }

        public void Stop()
        {
            foreach (var module in _modules)
            {
                module.Stop();
            }
        }
    }
}