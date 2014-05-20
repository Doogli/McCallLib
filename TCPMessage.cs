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
<<<<<<< HEAD
    [ProtoInclude(7, typeof(NetworkOperatorMessage))]
=======
	[ProtoInclude(7, typeof(NetworkOperatorMessage))]
>>>>>>> d732a7830bd3225691fae818b4c469d6ea8355bc
    public abstract class TCPMessage
    {
        public TCPMessage()
        {
        }
    }

    [ProtoContract]
    public class OKMessage : TCPMessage
    {
        public OKMessage()
            : base()
        {
        }
    }

    [ProtoContract]
    public class AlternateServerMessage : TCPMessage
    {
        [ProtoMember(1, IsRequired = true)]
        public string IpAddress { get; set; }

        //public AlternateServerMessage()
        //    : base()
        //{
        //}

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

        //public ContractSubscribeMessage()
        //    : base()
        //{
        //}

        public ContractSubscribeMessage(TelephoneNumber telNo)
            : base()
        {
            TelNo = telNo;
        }
    }

    [ProtoContract]
    public class ContractUnsubscribeMessage : TCPMessage
    {
        [ProtoMember(1, IsRequired = true)]
        public TelephoneNumber TelNo { get; set; }

        //public ContractUnsubscribeMessage()
        //    : base()
        //{
        //}

        public ContractUnsubscribeMessage(TelephoneNumber telNo)
            : base()
        {
            TelNo = telNo;
        }
    }

    [ProtoContract]
    public class LatencyMessage : TCPMessage
    {
        [ProtoMember(1, IsRequired = true)]
        public TelephoneNumber MyTelNo { get; set; }

        [ProtoMember(2, IsRequired = true)]
        public TelephoneNumber SourceTelNo { get; set; }

        [ProtoMember(3, IsRequired = true)]
        public int LatencyMS { get; set; }

        //public LatencyMessage()
        //    : base()
        //{
        //}

        public LatencyMessage(TelephoneNumber myTelNo, TelephoneNumber sourceTelNo, int latencyMS)
            : base()
        {
            MyTelNo = myTelNo;
            SourceTelNo = sourceTelNo;
            LatencyMS = latencyMS;
        }
    }

<<<<<<< HEAD
    [ProtoContract]
    public class NetworkOperatorMessage : TCPMessage
    {
        [ProtoMember(1, IsRequired = true)]
        public NetworkOperator Operator { get; set; }


        //public LatencyMessage()
        //    : base()
        //{
        //}

        public NetworkOperatorMessage(NetworkOperator op)
            : base()
        {
            Operator = op;
        }
    }
=======
	[ProtoContract]
	public class NetworkOperatorMessage : TCPMessage
	{
		[ProtoMember(1, IsRequired = true)]
		public NetworkOperator Operator { get; set; }


		//public LatencyMessage()
		//    : base()
		//{
		//}

		public NetworkOperatorMessage(NetworkOperator op)
			: base()
		{
			Operator = op;
		}
	}
>>>>>>> d732a7830bd3225691fae818b4c469d6ea8355bc
}
