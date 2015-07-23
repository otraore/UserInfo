using System.Runtime.Serialization;

namespace UserInfo
{
    [DataContract]
    public class Friend
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "motto")]
        public string Motto { get; set; }

        [DataMember(Name = "uniqueId")]
        public string UniqueID { get; set; }

        [DataMember(Name = "figureString")]
        public string FigureId;
    }
}
