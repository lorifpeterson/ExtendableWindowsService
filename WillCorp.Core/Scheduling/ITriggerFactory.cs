using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillCorp.Scheduling
{
    /// <summary>
    /// This is an abstraction of the how jobs are scheduled to run. i.e. triggered
    /// The generic paameter will be used by during the schedullng og job
    /// </summary>
    /// <typeparam name="TTrigger"></typeparam>
    public interface ITriggerFactory<TTrigger>
    {
        Result<TTrigger> Create(string jobId, string groupId = "DEFAULT");
        bool IsSchedule(string jobId);
    }
}
