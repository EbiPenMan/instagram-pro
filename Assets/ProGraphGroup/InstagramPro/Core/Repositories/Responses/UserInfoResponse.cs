using Newtonsoft.Json;
using ProGraphGroup.InstagramPro.Core.Model.Core;

namespace ProGraphGroup.InstagramPro.Core.Repositories.Responses
{
    public class UserInfo
    {
        [JsonProperty("user")] public User User { get; set; }

        [JsonProperty("status")] public string Status { get; set; }
    }
}