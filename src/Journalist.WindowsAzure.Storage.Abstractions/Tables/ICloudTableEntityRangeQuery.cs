using System.Collections.Generic;
using System.Threading.Tasks;

namespace Journalist.WindowsAzure.Storage.Tables
{
    public interface ICloudTableEntityRangeQuery
    {
        Task<IList<IDictionary<string, object>>> ExecuteAsync();
    }
}