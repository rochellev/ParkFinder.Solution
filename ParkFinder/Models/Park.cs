using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ParkFinder.Models
{
    public class Park
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Area { get; set; }
        public string URL { get; set; }

        // API Request
        public static Task<IRestResponse> GetResponseContentAsync(RestClient theClient, RestRequest theRequest)
        {
            var tcs = new TaskCompletionSource<IRestResponse>();
            theClient.ExecuteAsync(theRequest, response =>
            {
                tcs.SetResult(response);
            });
            return tcs.Task;
        }

        public static List<Park> GetAllParksAsync()
        {
            var client = new RestClient("http://localhost:5000/api/");
            var request = new RestRequest("parks", Method.GET);
            var response = new RestResponse();
            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();
            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(response.Content);
            var parkList = JsonConvert.DeserializeObject<List<Park>>(jsonResponse.ToString());
            return parkList;
        }


    }
}