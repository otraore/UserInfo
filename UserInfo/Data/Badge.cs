using System.Drawing;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace UserInfo
{
    [DataContract]
    public class Badge
    {
        [DataMember(Name = "code")]
        public string Code { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        public override string ToString()
        {
            return string.Format(
                "Code: {0}, Name: {1}, Description: {2}", Code, Name, Description
            );
        }

        public async Task<Image> getBadgeImage()
        {
            using (HttpClient client = new HttpClient())
                return Image.FromStream(await client.GetStreamAsync(string.Format("http://images.habbo.com/c_images/album1584/{0}.gif", Code)));
        }
    }
}
