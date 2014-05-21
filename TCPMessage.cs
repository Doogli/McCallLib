using System;
using ProtoBuf;
using System.Net;

namespace McCallLib
{
    [ProtoContract]
    [ProtoInclude(2, typeof(OKMessage))]
    [ProtoInclude(3, typeof(AlternateServerMessage))]
    [ProtoInclude(4, typeof(ContractSubscribeMessage))]
    [ProtoInclude(5, typeof(ContractUnsubscribeMessage))]
    [ProtoInclude(6, typeof(LatencyMessage))]
    [ProtoInclude(7, typeof(NetworkOperatorMessage))]
	[ProtoInclude(8, typeof(ExchangeSubscribeMessage))]
	[ProtoInclude(9, typeof(ExchangeUnsubscribeMessage))]
    public abstract class TCPMessage
    {
		[ProtoMember(1, IsRequired = true)]
		public TelephoneNumber MyTelNo { get; set; }

        public TCPMessage()
        {
        }

		public TCPMessage(TelephoneNumber myTelNo)
		{
			MyTelNo = myTelNo;
		}
    }

    [ProtoContract]
    public class OKMessage : TCPMessage
    {
        public OKMessage()
            : base()
        {
        }

		public OKMessage(TelephoneNumber myTelNo)
			: base (myTelNo)
		{
		}
    }

    [ProtoContract]
    public class AlternateServerMessage : TCPMessage
    {
        [ProtoMember(1, IsRequired = true)]
        public string IpAddress { get; set; }

        public AlternateServerMessage()
            : base()
        {
        }

        public AlternateServerMessage(string ip)
            : base()
        {
            IpAddress = ip;
        }
    }

    [ProtoContract]
    public class ContractSubscribeMessage : TCPMessage
    {
        [ProtoMember(1, IsRequired = true)]
        public TelephoneNumber TelNo { get; set; }

        public ContractSubscribeMessage()
            : base()
        {
        }

		public ContractSubscribeMessage(TelephoneNumber myTelNo, TelephoneNumber telNo)
			: base(myTelNo)
        {
            TelNo = telNo;
        }
    }

    [ProtoContract]
    public class ContractUnsubscribeMessage : TCPMessage
    {
        [ProtoMember(1, IsRequired = true)]
        public TelephoneNumber TelNo { get; set; }

        public ContractUnsubscribeMessage()
            : base()
        {
        }

		public ContractUnsubscribeMessage(TelephoneNumber myTelNo, TelephoneNumber telNo)
			: base(myTelNo)
		{
			TelNo = telNo;
		}
    }

    [ProtoContract]
    public class LatencyMessage : TCPMessage
    {
		[ProtoMember(1, IsRequired = true)]
        public TelephoneNumber SourceTelNo { get; set; }

		[ProtoMember(2, IsRequired = true)]
        public int LatencyMS { get; set; }

        public LatencyMessage()
            : base()
        {
        }

        public LatencyMessage(TelephoneNumber myTelNo, TelephoneNumber sourceTelNo, int latencyMS)
			: base(myTelNo)
        {
            SourceTelNo = sourceTelNo;
            LatencyMS = latencyMS;
        }
    }

    [ProtoContract]
    public class NetworkOperatorMessage : TCPMessage
    {
        [ProtoMember(1, IsRequired = true)]
        public NetworkOperator Operator { get; set; }

		public NetworkOperatorMessage()
            : base()
        {
        }

		public NetworkOperatorMessage(TelephoneNumber myTelNo, NetworkOperator op)
			: base(myTelNo)
        {
            Operator = op;
        }
    }

	[ProtoContract]
	public class ExchangeSubscribeMessage : TCPMessage
	{
		public ExchangeSubscribeMessage()
			: base()
		{
		}

		public ExchangeSubscribeMessage(TelephoneNumber myTelNo)
			: base(myTelNo)
		{
		}
	}

	[ProtoContract]
	public class ExchangeUnsubscribeMessage : TCPMessage
	{
		public ExchangeUnsubscribeMessage()
			: base()
		{
		}

		public ExchangeUnsubscribeMessage(TelephoneNumber myTelNo)
			: base(myTelNo)
		{
		}
	}
}
