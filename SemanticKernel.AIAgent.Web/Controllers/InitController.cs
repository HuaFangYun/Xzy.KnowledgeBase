using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SemanticKernel.AIAgent.Domain.Repositories;
using SemanticKernel.AIAgent.Domain.Repositories.Base;

namespace SemanticKernel.AIAgent.Web.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]/[action]")]
    public class InitController : ControllerBase
    {
        private readonly IApps_Repositories _repository;

        public InitController(IApps_Repositories repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// 初始化DB 和表
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult InitTable()
        {
            _repository.GetDB().DbMaintenance.CreateDatabase();
            _repository.GetDB().CodeFirst.InitTables(typeof(Apps));
            _repository.GetDB().CodeFirst.InitTables(typeof(Kmss));
            return Ok();
        }
    }
}
