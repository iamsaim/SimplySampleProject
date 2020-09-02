using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.RP.RestApi.Configuration
{
    public class UrlsConfig
    {
        public class CaseServiceOperations
        {
            public static string GetAllCases = $"/v1/case/GetCasesFromDB";
        }

        public string CaseServiceURL { get; set; }
    }
}
