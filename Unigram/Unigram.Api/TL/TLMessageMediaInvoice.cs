// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLMessageMediaInvoice : TLMessageMediaBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			ShippingAddressRequested = (1 << 1),
			Test = (1 << 3),
			Photo = (1 << 0),
			ReceiptMsgId = (1 << 2),
		}

		public bool IsShippingAddressRequested { get { return Flags.HasFlag(Flag.ShippingAddressRequested); } set { Flags = value ? (Flags | Flag.ShippingAddressRequested) : (Flags & ~Flag.ShippingAddressRequested); } }
		public bool IsTest { get { return Flags.HasFlag(Flag.Test); } set { Flags = value ? (Flags | Flag.Test) : (Flags & ~Flag.Test); } }
		public bool HasPhoto { get { return Flags.HasFlag(Flag.Photo); } set { Flags = value ? (Flags | Flag.Photo) : (Flags & ~Flag.Photo); } }
		public bool HasReceiptMsgId { get { return Flags.HasFlag(Flag.ReceiptMsgId); } set { Flags = value ? (Flags | Flag.ReceiptMsgId) : (Flags & ~Flag.ReceiptMsgId); } }

		public Flag Flags { get; set; }
		public String Title { get; set; }
		public String Description { get; set; }
		public TLWebDocument Photo { get; set; }
		public Int32? ReceiptMsgId { get; set; }
		public String Currency { get; set; }
		public Int64 TotalAmount { get; set; }
		public String StartParam { get; set; }

		public TLMessageMediaInvoice() { }
		public TLMessageMediaInvoice(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessageMediaInvoice; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Title = from.ReadString();
			Description = from.ReadString();
			if (HasPhoto) Photo = TLFactory.Read<TLWebDocument>(from);
			if (HasReceiptMsgId) ReceiptMsgId = from.ReadInt32();
			Currency = from.ReadString();
			TotalAmount = from.ReadInt64();
			StartParam = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.Write(0x84551347);
			to.Write((Int32)Flags);
			to.Write(Title);
			to.Write(Description);
			if (HasPhoto) to.WriteObject(Photo);
			if (HasReceiptMsgId) to.Write(ReceiptMsgId.Value);
			to.Write(Currency);
			to.Write(TotalAmount);
			to.Write(StartParam);
		}

		private void UpdateFlags()
		{
			HasPhoto = Photo != null;
			HasReceiptMsgId = ReceiptMsgId != null;
		}
	}
}