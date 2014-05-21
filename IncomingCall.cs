using System;
using ProtoBuf;

namespace McCallLib
{
	[ProtoContract]
	public class IncomingCall
	{
		[ProtoMember(1, IsRequired = true)]
		public TelephoneNumber Originator { get; set; }
		[ProtoMember(2, IsRequired = true)]
		public DateTime CallArrivalTime { get; set; }

		public IncomingCall ()
		{
		}

		public IncomingCall (TelephoneNumber originator, DateTime callArrivalTime)
		{
			Originator = originator;
			CallArrivalTime = callArrivalTime;
		}
	}
}

