namespace ApiForAuth.Helpers.Kit.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.IO;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using System.Web;

    public class HttpRequestException : Exception
    {
        public HttpRequestException(HttpResponseMessage response, string responseBody)
            : base(response.ReasonPhrase)
        {
            this.Response = response;
            this.ResponseBody = responseBody;
        }
        public string ResponseBody { get; protected set; }
        public HttpResponseMessage Response { get; protected set; }
    }

    public static class HttpHelper_Extensions
    {
        public static Uri ToUri(this string url)
        {
            return new Uri(url);
        }

        public static string Append(this string url, params string[] paths)
        {
            if (url == null) url = string.Empty;
            string[] urlParts = url.Split('?');
            url = paths.Aggregate(urlParts[0], (current, path) => string.Format("{0}/{1}", current.TrimEnd('/'), path.TrimStart('/')));
            if (urlParts.Length > 1) url += "?" + urlParts[1];
            return url;
        }

        public static Uri Append(this Uri uri, params string[] paths)
        {
            return new Uri(uri.AbsoluteUri.Append(paths));
        }

        public static Uri SetQueryParameters(this Uri uri, IEnumerable<KeyValuePair<string, string>> parameters)
        {
            var ub = new UriBuilder(uri);
            NameValueCollection nvc = HttpUtility.ParseQueryString(ub.Query);
            parameters.ToList().ForEach(x =>
            {
                nvc[x.Key] = x.Value;
            });              
            ub.Query = nvc.ToString();
            return ub.Uri;
        }

        public static void WriteStream(this HttpResponse response, Stream stream, string fileName, string contentType = null)
        {
            //response.Clear();
            //response.ContentType = string.IsNullOrWhiteSpace(contentType) ? "application/octet-stream" : contentType;
            //response.Headers.Add("Content-Disposition", $"attachment; filename={fileName}");
            //response.SendFileAsync()
            //stream.CopyTo(response.OutputStream);
            //response.Flush();
            //response.End();
        }

        public static void WriteStream(this HttpResponse response, string filePath, string fileName, string contentType = null)
        {
            response.Clear();
            response.ContentType = string.IsNullOrWhiteSpace(contentType) ? "application/octet-stream" : contentType;
            response.Headers.Add("Content-Disposition", $"attachment; filename={fileName}");
            response.SendFileAsync(filePath);
        }

        public static void SetAuthHeader(this HttpClient client, string securityKey)
        {
            client.DefaultRequestHeaders.Add("X-Requested-Token", securityKey); // = new AuthenticationHeaderValue()
        }
    }

    public static class HttpHelper
    {
        public static async Task<TResult> ExecuteGetUrl<TResult>(Uri uri
            , IEnumerable<KeyValuePair<string, string>> parameters
            , Func<HttpResponseMessage, string, Task<string>> responseHandler = null
            , Func<HttpResponseMessage, string, Task<string>> errorHandler = null
            , string securityKey = null
        )
        {
            string responseBody = await HttpHelper.ExecuteGetUrl(uri, parameters, responseHandler, errorHandler, securityKey).ConfigureAwait(false);
            return responseBody.JsonDeserialize<TResult>();
        }

        public static async Task<string> ExecuteGetUrl(Uri uri
            , IEnumerable<KeyValuePair<string, string>> parameters
            , Func<HttpResponseMessage, string, Task<string>> responseHandler = null
            , Func<HttpResponseMessage, string, Task<string>> errorHandler = null
            , string securityKey = null
        )
        {
            return await HttpHelper.ExecuteRequest(async x => await x.GetAsync(uri.SetQueryParameters(parameters)).ConfigureAwait(false), responseHandler, errorHandler, securityKey).ConfigureAwait(false);            
        }

        public static async Task<Stream> ExecuteGetStreamUrl(Uri uri
            , IEnumerable<KeyValuePair<string, string>> parameters
            , Func<HttpResponseMessage, Stream, Task<Stream>> responseHandler = null
            , Func<HttpResponseMessage, Stream, Task<Stream>> errorHandler = null
            , string securityKey = null
        )
        {
            return await HttpHelper.ExecuteStreamRequest(async x => await x.GetAsync(uri.SetQueryParameters(parameters)).ConfigureAwait(false), responseHandler, errorHandler, securityKey).ConfigureAwait(false);
        }

        public static async Task<string> ExecutePostUrl(Uri uri
            , IEnumerable<KeyValuePair<string, string>> parameters = null
            , Func<HttpResponseMessage, string, Task<string>> responseHandler = null
            , Func<HttpResponseMessage, string, Task<string>> errorHandler = null
            , string securityKey = null
        )
        {
            return await HttpHelper.ExecuteRequest(async x => await x.PostAsync(uri, new FormUrlEncodedContent(parameters)).ConfigureAwait(false), responseHandler, errorHandler, securityKey).ConfigureAwait(false);
        }

        public static async Task<TResult> ExecutePostUrl<TResult>(Uri uri
            , IEnumerable<KeyValuePair<string, string>> parameters = null
            , Func<HttpResponseMessage, string, Task<string>> responseHandler = null
            , Func<HttpResponseMessage, string, Task<string>> errorHandler = null
            , string securityKey = null
        )
        {
            string responseBody = await HttpHelper.ExecuteRequest(async x => await x.PostAsync(uri, new FormUrlEncodedContent(parameters)).ConfigureAwait(false), responseHandler, errorHandler, securityKey).ConfigureAwait(false);
            return responseBody.JsonDeserialize<TResult>();
        }

        public static async Task<string> ExecutePostString(Uri uri
            , string content = null
            , Func<HttpResponseMessage, string, Task<string>> responseHandler = null
            , Func<HttpResponseMessage, string, Task<string>> errorHandler = null
            , string securityKey = null
        )
        {
            return await HttpHelper.ExecuteRequest(async x => await x.PostAsync(uri, new StringContent(content)).ConfigureAwait(false), responseHandler, errorHandler, securityKey).ConfigureAwait(false);
        }

        public static async Task<TResult> ExecutePostString<TResult>(Uri uri
            , string content = null
            , Func<HttpResponseMessage, string, Task<string>> responseHandler = null
            , Func<HttpResponseMessage, string, Task<string>> errorHandler = null
            , string securityKey = null
        )
        {
            string responseBody = await HttpHelper.ExecuteRequest(async x => await x.PostAsync(uri, new StringContent(content)).ConfigureAwait(false), responseHandler, errorHandler, securityKey).ConfigureAwait(false);
            return responseBody.JsonDeserialize<TResult>();
        }

        public static async Task<string> ExecutePostObject<TObject>(Uri uri
            , TObject obj
            , Func<HttpResponseMessage, string, Task<string>> responseHandler = null
            , Func<HttpResponseMessage, string, Task<string>> errorHandler = null
            , string securityKey = null
        )
        {
            string requestBody = obj.JsonSerialize();
            return await HttpHelper.ExecutePostString(uri, requestBody, responseHandler, errorHandler, securityKey).ConfigureAwait(false);
        }

        public static async Task<TResult> ExecutePostObject<TRequest, TResult>(Uri uri
            , TRequest obj
            , Func<HttpResponseMessage, string, Task<string>> responseHandler = null
            , Func<HttpResponseMessage, string, Task<string>> errorHandler = null
            , string securityKey = null
        )
        {
            string requestBody = obj.JsonSerialize();
            string responseBody = await HttpHelper.ExecutePostString(uri, requestBody, responseHandler, errorHandler, securityKey).ConfigureAwait(false);
            return responseBody.JsonDeserialize<TResult>();
        }

        public static async Task<TResult> ExecutePostFiles<TResult>(Uri uri
            , IEnumerable<FileStream> files
            , IEnumerable<KeyValuePair<string, string>> parameters = null
            , Func<HttpResponseMessage, string, Task<string>> responseHandler = null
            , Func<HttpResponseMessage, string, Task<string>> errorHandler = null
            , string securityKey = null
        )
        {
            var formData = new MultipartFormDataContent();
            if (files != null)
            {
                int i = 1;
                foreach (FileStream fileStream in files)
                {
                    HttpContent fileStreamContent = new StreamContent(fileStream);
                    formData.Add(fileStreamContent, string.Concat("file_", i++.ToString()), fileStream.Name);
                }
            }

            if (parameters != null)
            {
                foreach (var keyValuePair in parameters)
                {
                    HttpContent stringContent = new StringContent(keyValuePair.Value);
                    formData.Add(stringContent, keyValuePair.Key);
                }
            }

            string responseBody = await HttpHelper.ExecuteRequest(async x => await x.PostAsync(uri, formData).ConfigureAwait(false), responseHandler, errorHandler, securityKey).ConfigureAwait(false);
            return responseBody.JsonDeserialize<TResult>();
        }
        public static async Task<Stream> ExecutePostStreamUrl(Uri uri
           , IEnumerable<FileStream> files
           , IEnumerable<KeyValuePair<string, string>> parameters
           , Func<HttpResponseMessage, Stream, Task<Stream>> responseHandler = null
           , Func<HttpResponseMessage, Stream, Task<Stream>> errorHandler = null
           , string securityKey = null
       )
        {
            var formData = new MultipartFormDataContent();
            if (files != null)
            {
                int i = 1;
                foreach (FileStream fileStream in files)
                {
                    HttpContent fileStreamContent = new StreamContent(fileStream);
                    formData.Add(fileStreamContent, string.Concat("file_", i++.ToString()), fileStream.Name);
                }
            }
            if (parameters != null)
            {
                foreach (var keyValuePair in parameters)
                {
                    HttpContent stringContent = new StringContent(keyValuePair.Value);
                    formData.Add(stringContent, keyValuePair.Key);
                }
            }
            return await HttpHelper.ExecuteStreamRequest(async x => await x.PostAsync(uri, formData).ConfigureAwait(false), responseHandler, errorHandler, securityKey).ConfigureAwait(false);
        }

        public static async Task<string> ExecuteRequest(
            Func<HttpClient, Task<HttpResponseMessage>> createRequest
            , Func<HttpResponseMessage, string, Task<string>> responseHandler = null
            , Func<HttpResponseMessage, string, Task<string>> errorHandler = null
            , string securityKey = null
        )
        {
            using (var client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromSeconds(3600);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // add auth header
                client.SetAuthHeader(securityKey);                

                using (HttpResponseMessage response = await createRequest(client).ConfigureAwait(false))
                {
                    // считываем содержимое ответа
                    string responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    if (response.Content != null) response.Content.Dispose();

                    // если что-то произошло на стороне сервера
                    if (!response.IsSuccessStatusCode)
                    {
                        if (errorHandler != null) return await errorHandler(response, responseBody).ConfigureAwait(false);
                        throw new HttpRequestException(response, responseBody);
                    }

                    return responseHandler != null 
                           ? await responseHandler(response, responseBody).ConfigureAwait(false)
                           : responseBody;
                }
            }
        }

        public static async Task<Stream> ExecuteStreamRequest(
            Func<HttpClient, Task<HttpResponseMessage>> createRequest
            , Func<HttpResponseMessage, Stream, Task<Stream>> responseHandler = null
            , Func<HttpResponseMessage, Stream, Task<Stream>> errorHandler = null
            , string securityKey = null
        )
        {
            using (var client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromSeconds(3600);
                
                // add auth header
                client.SetAuthHeader(securityKey);
                HttpResponseMessage response = await createRequest(client).ConfigureAwait(false);
                
                // считываем содержимое ответа
                Stream responseBody = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
                string responseBodyString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                // если что-то произошло на стороне сервера
                if (!response.IsSuccessStatusCode)
                {
                    if (errorHandler != null) return await errorHandler(response, responseBody).ConfigureAwait(false);
                    throw new HttpRequestException(response, responseBodyString);
                }

                return responseHandler != null
                    ? await responseHandler(response, responseBody).ConfigureAwait(false)
                    : responseBody;
            }
        }
    }
}