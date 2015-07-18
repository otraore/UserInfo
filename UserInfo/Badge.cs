using System.Drawing;
using System.Net;
using System.Runtime.Serialization;

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

        public Image getBadgeImage()
        {
            var request = WebRequest.Create(
                string.Format("http://images.habbo.com/c_images/album1584/{0}.gif", Code));
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                return Image.FromStream(stream);
            }
        }
    }
}
