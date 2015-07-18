using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace UserInfo
{
    [DataContract]
    public class User
    {
        private static readonly DataContractJsonSerializer _deserializer = new 
            DataContractJsonSerializer(typeof(User));
        [DataMember(Name = "uniqueId")]
        public string UniqueId { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "figureString")]
        public string FigureId { get; set; }

        [DataMember(Name = "selectedBadges")]
        public IList<Badge> SelectedBadges { get; set; }

        [DataMember(Name = "motto")]
        public string Motto { get; set; }

        [DataMember(Name = "memberSince")]
        public string MemberSince { get; set; }

        [DataMember(Name = "profileVisible")]
        public bool IsProfileVisible { get; set; }

        [DataMember(Name = "lastWebAccess")]
        public string LastWebAccess { get; set; }

        public static User fromJSON(string data)
        {
            byte[] rawJson = Encoding.UTF8.GetBytes(data);
            using (var jsonStream = new MemoryStream(rawJson))
                return (User)_deserializer.ReadObject(jsonStream);
        }

        public override string ToString()
        {
            return string.Format(
                "uniqueID: {0}, name: {1}, figureString: {2}, selectedBadges: {3},  motto: {4}, memberSince: {5}, profileVisible: {6}, lastWebAccess: {7}",
                UniqueId, Name, FigureId, SelectedBadges.Count, Motto, MemberSince, IsProfileVisible, LastWebAccess
                );
        }
    }
}
