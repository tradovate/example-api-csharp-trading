/* 
 * 
 * Tradovate API, Samples. 
 * AccessTokenRequest
 *
*/

using System.Diagnostics;
using System.Net;
using Tradovate.Services.Api;
using Tradovate.Services.Model;

namespace Tradovate
{
    class Authentication
    {
        public static AccessTokenResponse GetAccessToken(string basePath, string username, string password)
        {
            var apiInstance = new AuthenticationApi(basePath);
            var body = new AccessTokenRequest(name: username, password: password, appId: "SampleApp", appVersion: "0.1.0", cid: "8", sec: "f03741b6-f634-48d6-9308-c8fb871150c2");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            AccessTokenResponse result = apiInstance.AccessTokenRequest(body);
            Debug.WriteLine(result);
            return result;
        }
    }
}