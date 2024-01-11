namespace ApiForAuth.Helpers
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;
    using ApiForAuth.Helpers.Kit.Helpers;


    public static class HttpHelper
    {
        public static async Task<string> ExecutePostJson(string url,
            JsonContent json,
            Func<HttpResponseMessage, string, Task<string>> responseHandler = null,
            Func<HttpResponseMessage, string, Task<string>> errorHandler = null,
            string securityKey = null
        )
        {
            using (var client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromSeconds(3600);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // add auth header
                client.SetAuthHeader(securityKey);

                using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url))
                {
                    request.Content = json;
                    using (HttpResponseMessage response = await client.SendAsync(request))
                    {
                        // считываем содержимое ответа
                        string responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        if (response.Content != null) response.Content.Dispose();

                        // если что-то произошло на стороне сервера
                        if (!response.IsSuccessStatusCode)
                        {
                            if (errorHandler != null) return await errorHandler(response, responseBody).ConfigureAwait(false);
                            throw new Kit.Helpers.HttpRequestException(response, responseBody);
                        }

                        return responseHandler != null
                               ? await responseHandler(response, responseBody).ConfigureAwait(false)
                               : responseBody;
                    }
                }
            }
        }


        public static async Task<TObject> ExecutePostJson<TObject>(string url,
            JsonContent json,
            Func<HttpResponseMessage, string, Task<string>> responseHandler = null,
            Func<HttpResponseMessage, string, Task<string>> errorHandler = null,
            string securityKey = null
        )
        {
            using (var client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromSeconds(3600);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // add auth header
                client.SetAuthHeader(securityKey);

                using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url))
                {
                    request.Content = json;
                    using (HttpResponseMessage response = await client.SendAsync(request))
                    {
                        // считываем содержимое ответа
                        string responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        if (response.Content != null) response.Content.Dispose();

                        return responseBody.JsonDeserialize<TObject>();
                    }
                }
            }
        }




        public static async Task<Stream> ExecuteStreamRequest(
              //Func<HttpClient, Task<HttpResponseMessage>> createRequest
              string url, 
              JsonContent json,
              Func<HttpResponseMessage, Stream, Task<Stream>> responseHandler = null,
              Func<HttpResponseMessage, Stream, Task<Stream>> errorHandler = null,
              string securityKey = null
        )
        {
            using (var client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromSeconds(3600);

                // add auth header
                client.SetAuthHeader(securityKey);

                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);
                request.Content = json;

                HttpResponseMessage response = await client.SendAsync(request);

                // считываем содержимое ответа
                Stream responseBody = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
                string responseBodyString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                // если что-то произошло на стороне сервера
                if (!response.IsSuccessStatusCode)
                {
                    if (errorHandler != null) return await errorHandler(response, responseBody).ConfigureAwait(false);
                    throw new Kit.Helpers.HttpRequestException(response, responseBodyString);
                }

                return responseHandler != null
                    ? await responseHandler(response, responseBody).ConfigureAwait(false)
                    : responseBody;

            }
        }






        public static async Task<String> ExecuteStreamResponse(
          string url,
          Stream file,
          string json,
          Func<HttpResponseMessage, Stream, Task<Stream>> responseHandler = null,
          Func<HttpResponseMessage, Stream, Task<Stream>> errorHandler = null,
          string securityKey = null
        )
        {
            using (var client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromSeconds(3600);

                // add auth header
                client.SetAuthHeader(securityKey);

                var formData = new MultipartFormDataContent();
                formData.Add(new StreamContent(file), "file", "file");

                var jsonContent = new StringContent(json, Encoding.UTF8, "application/json");
                formData.Add(jsonContent, "idResponse");

                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);
                request.Content = formData;

                HttpResponseMessage response = await client.SendAsync(request);

                // считываем содержимое ответа
                //Stream responseBody = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
                string responseBodyString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                // если что-то произошло на стороне сервера
                //if (!response.IsSuccessStatusCode)
                //{
                //    if (errorHandler != null) return await errorHandler(response, responseBody).ConfigureAwait(false);
                //    throw new Kit.Helpers.HttpRequestException(response, responseBodyString);
                //}

                return responseBodyString;

            }
        }
    }
}
