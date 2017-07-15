// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputGameID : TLInputGameBase 
	{
		public Int64 Id { get; set; }
		public Int64 AccessHash { get; set; }

		public TLInputGameID() { }
		public TLInputGameID(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputGameID; } }

		public override void Read(TLBinaryReader from)
		{
			Id = from.ReadInt64();
			AccessHash = from.ReadInt64();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x32C3E77);
			to.Write(Id);
			to.Write(AccessHash);
		}
	}
}