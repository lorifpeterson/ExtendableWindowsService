using System;
using System.Collections.Generic;
using System.Linq;
using WillCorp.App;

namespace WillCorp.HostService
{
    public class ServiceHost
    {
        /// <summary>
        /// This class methods are called when the windows service is started and/or stopped
        /// It receices a collection of service modules which it will start when the service is started
        /// and stop those modules when the service is stopped
        /// </summary>
        private readonly IEnumerable<IServiceModule> _modules;

        public ServiceHost(IEnumerable<IServiceModule> modules)
        {
            _modules = modules;
        }

        public void Start()
        {
            var moduleCount = 0;

            foreach (var module in _modules)
            {
                var name = module.GetType().Name;
                try
                {
                    Console.WriteLine($"Starting {name}");

                    if (module.Start())
                    {
                        moduleCount++;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error occured while starting module: {e.Message}");
                }
            }

            Console.WriteLine($"{moduleCount} of {_modules.Count()} module(s) started successfully");
            Console.WriteLine("ServiceHost Started");

        }

        public void Stop()
        {
            foreach (var module in _modules.Where(m => m.Status == ServiceModuleStatus.Started))
            {
                var name = module.GetType().Name;
                try
                {
                    Console.WriteLine($"Stopping {name}");

                    module.Stop();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Eror occurred while stopping module: {e.Message}");
                }
            }

            Console.WriteLine("ServiceHost Stopped");
        }

        public void Shutdown()
        {
            Console.WriteLine("ServiceHost shutting down");
        }
    }
}
