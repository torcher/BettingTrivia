using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace BettingTrivia.Shared
{
    public static class JSONHelpers
    {
        public static async Task<T> ParseHTTPResponse<T>(this HttpResponseMessage message)
        {
            return JsonConvert.DeserializeObject<T>(await message.Content.ReadAsStringAsync());
        }
    }
}