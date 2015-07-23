using System.IO;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace UserInfo
{
    [DataContract]
    public class Profile
    {
        public static readonly DataContractJsonSerializer _deserializer = new DataContractJsonSerializer(typeof(Profile));

        [DataMember(Name = "user")]
        User User { get; set; }

        [DataMember(Name = "friends")]
        Friend[] Friends { get; set; }

        [DataMember(Name = "groups")]
        Group[] Groups { get; set; }

        [DataMember(Name = "rooms")]
        Room[] Rooms { get; set; }

        [DataMember(Name = "badges")]
        Badge[] Badges { get; set; }

        public Profile fromJSON(string data)
        {
            byte[] rawJson = Encoding.UTF8.GetBytes(data);
            using (var stream = new MemoryStream(rawJson))
                return (Profile)_deserializer.ReadObject(stream);
        }

        public async Task<Profile> fromUniqueId(string uniqueId)
        {
            using (HttpClientHandler handler = new HttpClientHandler())
            using (HttpClient client = new HttpClient(handler, true))
                return fromJSON(await client.GetStringAsync(string.Format(Config.PROFILE_REQUEST_FORMAT, uniqueId)));
        }

        public async Task<Profile> fromUser(User user)
        {
            return await fromUniqueId(user.UniqueId);
        }

    }
}
