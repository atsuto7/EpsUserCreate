using System;
using Newtonsoft.Json;
using System.Net;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Web;
using System.IO;
using RestSharp;
using RestSharp.Deserializers;

namespace UserCreateApi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var userCleateClient = new RestClient();
            var userCleateRequest = new RestRequest();
            userCleateClient.BaseUrl = new Uri("https://epsapistaging.azurewebsites.net/api/User");
            userCleateRequest.Method = Method.POST;
            userCleateRequest.Parameters.Clear();
            //userCleateRequest.AddParameter("role", "User", ParameterType.RequestBody);
            //userCleateRequest.AddParameter("mailAddress", "g.atsuto@icloud.com", ParameterType.RequestBody);
            //userCleateRequest.AddParameter("phoneNumber", "8108096010722", ParameterType.RequestBody);
            //userCleateRequest.AddParameter("userID", null, ParameterType.RequestBody);
            //userCleateRequest.AddParameter("userName", "atsuto7", ParameterType.RequestBody);
            //userCleateRequest.AddParameter("twitterID", null, ParameterType.RequestBody);
            //userCleateRequest.AddParameter("youtubeChannel", null, ParameterType.RequestBody);
            //userCleateRequest.AddParameter("twitchID", null, ParameterType.RequestBody);
            //userCleateRequest.AddParameter("steamID", null, ParameterType.RequestBody);
            //userCleateRequest.AddParameter("passWord", "Atsu0722", ParameterType.RequestBody);
            //userCleateRequest.AddParameter("message", null, ParameterType.RequestBody);]
            var body = new
            {
                role = "User",
                mailAddress = "g.atsuto@icloud.com",
                phoneNumber = "8108096010722",
                userID = "",
                userName = "atsuto7",
                twitterID = "",
                youtubeChannel = "",
                twitchID = "",
                steamID = "",
                passWord = "Atsu0722",
                message = ""
            };

            userCleateRequest.AddHeader("content-type", "application/json");
            userCleateRequest.AddHeader("Accept", "application/json");
            userCleateRequest.AddJsonBody(body);
            var response = userCleateClient.Execute(userCleateRequest);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine(response.StatusCode);
                Console.WriteLine("失敗");
            }

        }
    }
}
