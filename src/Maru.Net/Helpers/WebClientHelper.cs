using Maru.Net.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Maru.Net.Helpers
{
    public class WebClientHelper
    {
        private HttpClient _webclient;
        private Uri _baseUri;

        public WebClientHelper(Uri BaseUri)
        {
            _baseUri = BaseUri;
            _webclient = new HttpClient();
            _webclient.BaseAddress = _baseUri;

            Logger.Log(this, "WebClientHelper instanciated");
        }

        public string BuildRequest(Request[] requests)
        {
            string requestString = "?";

            foreach (var req in requests) {

                if (req.Key == null || req.Key == "" ||
                    req.Value == null || req.Value == "") {

                    throw new ArgumentException("Key and/or Value of a request can't be empty or null");
                }

                if (requests[0] != req) {
                    requestString += "&";
                }

                requestString += $"{req.Key}={req.Value}";
            }

            return requestString;
        }

        public async Task<string> GetAsync(string Endpoint, string Requests)
        {
            Logger.Log(this, $"GET request to: {_baseUri.ToString()}{Endpoint} with the requests: {Requests}");

            var Response = await _webclient.GetAsync($"{Endpoint}{Requests}");

            if (!Response.IsSuccessStatusCode) {
                Logger.Log(this, $"GET request failed: {Response.ReasonPhrase}", ConsoleColor.Red);
                throw new HttpRequestException(Response.ReasonPhrase);
            }

            Logger.Log(this, "GET request successful", ConsoleColor.Green);

            return await Response.Content.ReadAsStringAsync();
        }
    }
}
