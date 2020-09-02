using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace Sample.Service.Core.Sql
{
    public interface ISqlConnectionFactory
    {
        Task<SqlConnection> CreateAsync(CancellationToken cancellationToken);
    }
}
