using System;
using ProtoBuf;

namespace McCallLib
{
    [ProtoContract]
    public class NetworkOperator
    {
        [ProtoMember(1, IsRequired = true)]
        public string CountryISO { get; set; }

        [ProtoMember(2, IsRequired = true)]
        public string OperatorCode { get; set; }

        [ProtoMember(3, IsRequired = true)]
        public string OperatorName { get; set; }

        public NetworkOperator()
        {
        }

        public NetworkOperator(string countryISO, string operatorCode, string operatorName)
        {
            CountryISO = countryISO;
            OperatorCode = operatorCode;
            OperatorName = operatorName;
        }
    }
}
