using SemanticKernel.AIAgent.Domain.Common.DependencyInjection;
using SemanticKernel.AIAgent.Domain.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemanticKernel.AIAgent.Domain.Repositories
{
    [ServiceDescription(typeof(IApps_Repositories), ServiceLifetime.Scoped)]
    public class Apps_Repositories : Repository<Apps>, IApps_Repositories
    {
    }
}
