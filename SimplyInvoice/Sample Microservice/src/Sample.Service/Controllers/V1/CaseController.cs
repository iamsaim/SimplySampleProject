using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sample.RP.RestApi.Extensions;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Sample.Service.Services.Case;
using Sample.Service.Core.Entities;
using Sample.Service.Helper;
using System.Text;

namespace Sample.RP.RestApi.Controllers.V1
{
    //[Authorize]
    [ApiController]
    [ApiVersion("1")]
    [Route("v{version:apiVersion}/case")]
    public class CaseController : BaseController
    {
        private readonly ILogger<CaseController> _logger;
        private readonly ICaseService _CaseService;

        public CaseController(ICaseService CaseService,ILogger<CaseController> logger)
        {
            _logger = logger;
            _CaseService = CaseService;
        }

        [Route("GetCasesFromDB")]
        [HttpGet]
        [ProducesResponseType(typeof(CasesDto), StatusCodes.Status200OK)]
        public IActionResult GetCasesFromDB()
        {
            _logger.LogInformation("Getting all Cases ");

            return Ok(_CaseService.GetCases());

        }

        [Route("")]
        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public IActionResult PostInvoiceToMyData(SendInvoiceEntity InvData)
        {
            _logger.LogInformation("Posting Invoice To my Data ");

            string invoice = InvoiceXMLHelper.GetInvoiceXML(InvData);
            byte [] InvoiceArray = Encoding.UTF8.GetBytes(invoice);
            
            return Ok(_CaseService.PostInvoiceOnMyData(InvData.userId, InvData.SubKey, InvoiceArray));

        }
    }

    public class CasesDto
    {
        public string dummyText { get; set; }
    }
}