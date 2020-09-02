using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;
using static Dapper.SqlMapper;
using Dapper;
using Sample.Service.Core.Sql;
using Sample.Service.Core.Entities;
using Sample.Service.Core.Extensions;
using Sample.RP.RestApi.Controllers.V1;
using System.Net.Http;
using System.Web;
using System.Text;
using System.Net.Http.Headers;
using System.IO;

namespace Sample.Service.Services.Case
{
    public class CaseService : ICaseService
    {
        private readonly ISqlConnectionFactory _sqlConnectionFactory;
        private readonly ILogger<CaseService> _logger;

        public CaseService(ISqlConnectionFactory sqlConnectionFactory, ILogger<CaseService> logger)
        {
            _sqlConnectionFactory = sqlConnectionFactory;
            _logger = logger;
        }

        public CasesDto GetCases()
        {

            //await using var connection = await _sqlConnectionFactory.CreateAsync(new CancellationToken());

            //string SQLQuery = @"SELECT [Id]
            //                          ,[Name]
            //                          ,[Description]
            //                          ,[Address]
            //                          ,[AddressLine1]
            //                          ,[AddressLine2]
            //                          ,[City]
            //                          ,[Country]
            //                          ,[Zipcode]
            //                          ,[OwnerId]
            //                          ,[Phone1]
            //                          ,[Phone2]
            //                          ,[Mobile]
            //                          ,[Fax]
            //                          ,[Email]
            //                          ,[Logo]
            //                          ,[Status]
            //                          ,[Currency]
            //                          ,[AllowedUsers]
            //                          ,[AllowSupervisor]
            //                          ,[ContractSignedDate]
            //                          ,[ContractExpiryDate]
            //                          ,[ContractUrl]
            //                          ,[StorageLimit]
            //                          ,[Notes]
            //                          ,[CreatedBy]
            //                          ,[CreatedDate]
            //                          ,[ModifiedBy]
            //                          ,[ModifiedDate]
            //                      FROM [dbo].[Company]      
            //                      WHERE [Id]=@Id";


            //CompanyEntity company = await connection.QueryFirstOrDefaultAsync<CompanyEntity>(SQLQuery, parameters, null);



            return new CasesDto { dummyText = "from microservice" };
        }

        public async  Task<string> PostInvoiceOnMyData(string userId, string SubKey, byte[] byteData)
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("aade-user-id", userId);
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", SubKey);

            var uri = "https://mydata-dev.azure-api.net/SendInvoices?" + queryString;

            HttpResponseMessage response;

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = await client.PostAsync(uri, content);
            }
            var txtBlock = await response.Content.ReadAsStringAsync();

            return response.ToString();
        }
    }
}
