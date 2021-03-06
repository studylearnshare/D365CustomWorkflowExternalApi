﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace D365CustomWorkflow.Utils
{
    public class HttpClientApi : IHttpClientApi
    {
        public HttpClient _client = new HttpClient();
        readonly string _baseUrl = "http://api.studylearnshare.com/";
        public HttpClientApi()
        {
            _client.BaseAddress = new Uri(_baseUrl);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<HttpResponseMessage> GetApiResponse(string queryPath)
        {

            HttpResponseMessage response = await _client.GetAsync(queryPath);
            return response;
        }


    }
}
