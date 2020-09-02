using Sample.RP.RestApi.Controllers.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Sample.Service.Services.Case
{
    public interface ICaseService
    {
        public CasesDto GetCases();
        public Task<string> PostInvoiceOnMyData(string userId, string SubKey, byte[] byteData);
    }
}
