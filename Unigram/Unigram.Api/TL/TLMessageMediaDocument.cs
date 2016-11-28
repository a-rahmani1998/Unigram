// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLMessageMediaDocument : TLMessageMediaBase, ITLMediaCaption 
	{
		public TLDocumentBase Document { get; set; }
		public String Caption { get; set; }

		public TLMessageMediaDocument() { }
		public TLMessageMediaDocument(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.MessageMediaDocument; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Document = TLFactory.Read<TLDocumentBase>(from, cache);
			Caption = from.ReadString();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xF3E02EA8);
			to.WriteObject(Document, cache);
			to.Write(Caption);
			if (cache) WriteToCache(to);
		}
	}
}