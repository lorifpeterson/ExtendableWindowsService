using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WillCorp;
using WillCorp.App;

namespace WillCorp.App.Importer
{
    public class ImporterModule : ServiceModuleBase, IServicePlugin
    {
        public ImporterModule()
        {

        }

        protected override bool OnStart()
        {
            Console.WriteLine("Importer module running");
            return true;
        }

        protected override bool OnStop()
        {
            Console.WriteLine("Importer module stopped");
            return true;
        }
    }
}
