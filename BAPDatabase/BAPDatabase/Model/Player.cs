using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BAPDatabase
{
    [DataContract]
    public class Player
    {
        [DataMember]
        public int PlayerID { get; set; }
        [DataMember]
        public string PlayerPrivateName { get; set; }
        [DataMember]
        public string PlayerFamilyName { get; set; }
        [DataMember]
        public double PlayerAge { get; set; }
        [DataMember]
        public double PlayerHeight { get; set; }
        [DataMember]
        public double PlayerWeight { get; set; }
        [DataMember]
        public string PlayerPassward { get; set; }
        [DataMember]
        public string PlayerUserName { get; set; }
        [DataMember]
        public bool PlayerRememberMe { get; set; }
    }
}
