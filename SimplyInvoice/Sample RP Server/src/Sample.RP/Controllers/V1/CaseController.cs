using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sample.RP.RestApi.Extensions;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Sample.RP.RestApi.Services.Case;

namespace Sample.RP.RestApi.Controllers.V1
{
    [AllowAnonymous]
    [ApiController]
    [ApiVersion("1")]
    [Route("v{version:apiVersion}/case")]
    public class CaseController : BaseController
    {
        private readonly ILogger<CaseController> _logger;
        private readonly ICaseServiceClient _CaseServiceClient;

        public CaseController(ILogger<CaseController> logger, ICaseServiceClient CaseServiceClient)
        {
            _logger = logger;
            _CaseServiceClient = CaseServiceClient;
        }

        [Route("GetAllCases")]
        [HttpGet]
        [ProducesResponseType(typeof(AllCasesItem), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllCases()
        {
            _logger.LogInformation("Getting all Cases ");
            var response = await _CaseServiceClient.GetAllCases();

            return Ok(response);

        }
    }

    public class AllCasesItem
    {
        public string dummyText { get;set; }
    }
}