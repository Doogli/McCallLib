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
    [ProtoInclude(2, typeof(OKMessage))]
    [ProtoInclude(3, typeof(AlternateServerMessage))]
    [ProtoInclude(4, typeof(SubscribeMessage))]
    [ProtoInclude(5, typeof(UnsubscribeMessage))]
    public abstract class TCPMessage
    {
        [ProtoMember(1, IsRequired = true)]
        public MessageCodes MessageCode { get; set; }

        public TCPMessage()
        {
        }

        public TCPMessage(MessageCodes code)
        {
            MessageCode = code;
        }
    }

    [ProtoContract]
    public class OKMessage : TCPMessage
    {
        public OKMessage()
            : base(MessageCodes.OK)
        {
        }
    }

    [ProtoContract]
    public class AlternateServerMessage : TCPMessage
    {
        [ProtoMember(1, IsRequired = true)]
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
        [ProtoMember(1, IsRequired = true)]
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
        [ProtoMember(1, IsRequired = true)]
        public TelephoneNumber TelNo { get; set; }

        public UnsubscribeMessage(TelephoneNumber telNo)
            : base(MessageCodes.Unsubscribe)
        {
            TelNo = telNo;
        }
    }
}
