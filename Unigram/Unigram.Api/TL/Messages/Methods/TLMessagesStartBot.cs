// <auto-generated/>
using System;

namespace Telegram.Api.TL.Messages.Methods
{
	/// <summary>
	/// RCP method messages.startBot.
	/// Returns <see cref="Telegram.Api.TL.TLUpdatesBase"/>
	/// </summary>
	public partial class TLMessagesStartBot : TLObject
	{
		public TLInputUserBase Bot { get; set; }
		public TLInputPeerBase Peer { get; set; }
		public Int64 RandomId { get; set; }
		public String StartParam { get; set; }

		public TLMessagesStartBot() { }
		public TLMessagesStartBot(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesStartBot; } }

		public override void Read(TLBinaryReader from)
		{
			Bot = TLFactory.Read<TLInputUserBase>(from);
			Peer = TLFactory.Read<TLInputPeerBase>(from);
			RandomId = from.ReadInt64();
			StartParam = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xE6DF7378);
			to.WriteObject(Bot);
			to.WriteObject(Peer);
			to.Write(RandomId);
			to.Write(StartParam);
		}
	}
}