using Microsoft.AspNetCore.Builder;
using Newtonsoft.Json;

namespace VMD.RESTApiResponseWrapper.Core.Extensions
{
    public static class ApiResponseMiddlewareExtension
    {
        public static IApplicationBuilder UseAPIResponseWrapperMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<APIResponseMiddleware>();
        }

        public static IApplicationBuilder UseAPIResponseWrapperMiddleware(this IApplicationBuilder builder, JsonSerializerSettings settings)
        {
            return builder.UseMiddleware<APIResponseMiddleware>(settings);
        }
    }
}
