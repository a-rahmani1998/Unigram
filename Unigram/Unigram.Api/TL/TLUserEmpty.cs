// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUserEmpty : TLUserBase 
	{
		public TLUserEmpty() { }
		public TLUserEmpty(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UserEmpty; } }

		public override void Read(TLBinaryReader from)
		{
			Id = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x200250BA);
			to.Write(Id);
		}
	}
}