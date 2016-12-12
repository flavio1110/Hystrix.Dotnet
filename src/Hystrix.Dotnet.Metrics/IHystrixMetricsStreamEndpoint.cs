using System.Threading.Tasks;
using System.Net.Http;

namespace Hystrix.Dotnet
{
    internal interface IHystrixMetricsStreamEndpoint
    {
        Task PushContentToOutputStream(HttpResponseMessage response);
        Task WriteAllCommandsJsonToOutputStream(HttpResponseMessage response);
        Task<string> GetCommandJson(IHystrixCommand command);
    }
}