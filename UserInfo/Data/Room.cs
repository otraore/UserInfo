using System.Runtime.Serialization;

namespace UserInfo
{
    [DataContract]
    public class Room
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "ownerUniqueId")]
        public string OwnerUniqueId { get; set; }

    }
}
