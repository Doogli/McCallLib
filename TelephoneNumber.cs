using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;

namespace McCallLib
{
    [ProtoContract]
    public class TelephoneNumber
    {
        [ProtoMember(1)]
        public string CountryCode { get; set; }
        [ProtoMember(2)]
        public string NetworkCode { get; set; }
        [ProtoMember(3)]
        public string UserNumber { get; set; }

        public TelephoneNumber(string country, string network, string user)
        {
            CountryCode = country;
            NetworkCode = network;
            UserNumber = user;
        }

        public string FullNumber
        {
            get{
                return "+" + CountryCode + NetworkCode + UserNumber;
            }
        }
    }
}
