using System.Runtime.Serialization;

namespace MatchingAPI.Helper
{
    public class CustomizeHelper
    {

        [DataMember]
        public string Message { get; set; }
        public string UserCode { get; set; }
        public long SOId { get; set; }
        public long UserId { get; set; }
        public int statuscode { get; set; }

    }
}
