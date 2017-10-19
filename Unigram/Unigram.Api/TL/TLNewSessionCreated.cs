// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLNewSessionCreated : TLNewSessionBase 
	{
		public Int64 FirstMsgId { get; set; }
		public Int64 UniqueId { get; set; }
		public Int64 ServerSalt { get; set; }

		public TLNewSessionCreated() { }
		public TLNewSessionCreated(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.NewSessionCreated; } }

		public override void Read(TLBinaryReader from)
		{
			FirstMsgId = from.ReadInt64();
			UniqueId = from.ReadInt64();
			ServerSalt = from.ReadInt64();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x9EC20908);
			to.Write(FirstMsgId);
			to.Write(UniqueId);
			to.Write(ServerSalt);
		}
	}
}