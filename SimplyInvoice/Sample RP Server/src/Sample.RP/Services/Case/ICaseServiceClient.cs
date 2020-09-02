using Sample.RP.RestApi.Controllers.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.RP.RestApi.Services.Case
{
    public interface ICaseServiceClient
    {
        public  Task<AllCasesItem> GetAllCases();
    }
}
