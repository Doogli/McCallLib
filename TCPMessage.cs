using System;
using ProtoBuf;
using System.Net;

namespace McCallLib
{
    public enum MessageCodes
    {
        OK = 0,
        AltServer,
        Subscribe,
        Unsubscribe
    }

    [ProtoContract]
    [ProtoInclude(2, typeof(AlternateServerMessage))]
    [ProtoInclude(3, typeof(SubscribeMessage))]
    [ProtoInclude(4, typeof(UnsubscribeMessage))]
    public class TCPMessage
    {
        [ProtoMember(1)]
        public MessageCodes MessageCode { get; set; }

        public TCPMessage(MessageCodes code)
        {
            MessageCode = code;
        }
    }

    [ProtoContract]
    public class AlternateServerMessage : TCPMessage
    {
        [ProtoMember(2)]
        public IPAddress IpAddress { get; set; }

        public AlternateServerMessage(IPAddress ip)
            : base(MessageCodes.AltServer)
        {
            IpAddress = ip;
        }
    }

    [ProtoContract]
    public class SubscribeMessage : TCPMessage
    {
        [ProtoMember(3)]
        public TelephoneNumber TelNo { get; set; }

        public SubscribeMessage(TelephoneNumber telNo)
            : base(MessageCodes.Subscribe)
        {
            TelNo = telNo;
        }
    }

    [ProtoContract]
    public class UnsubscribeMessage : TCPMessage
    {
        [ProtoMember(4)]
        public TelephoneNumber TelNo { get; set; }

        public UnsubscribeMessage(TelephoneNumber telNo)
            : base(MessageCodes.Unsubscribe)
        {
            TelNo = telNo;
        }
    }
}
