namespace ApiForAuth.Helpers.Kit.Helpers
{
    using Newtonsoft.Json;
    using System.Threading.Tasks;

    public static class JsonHelper
    {
        public static System.Text.Json.JsonSerializerOptions GlobalJsonSettings = new System.Text.Json.JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = false,
        };

        public static TObject JsonDeserialize<TObject>(this string json)
        {
            if (json == null || string.IsNullOrWhiteSpace(json)) return default(TObject);
            return JsonConvert.DeserializeObject<TObject>(json, new JsonSerializerSettings { DateFormatHandling = DateFormatHandling.IsoDateFormat });
        }

        public static string JsonSerialize<TObject>(this TObject serializeObject)
        {
            if (serializeObject == null) return "{}";
            return JsonConvert.SerializeObject(serializeObject, new JsonSerializerSettings { DateFormatHandling = DateFormatHandling.IsoDateFormat });
        }

        public static async Task<TObject> JsonDeserialize<TObject>(this Task<string> task)
        {
            string json = await task.ConfigureAwait(false);
            return await Task<TObject>.Run(() => json.JsonDeserialize<TObject>()).ConfigureAwait(false);
        }
    }
}