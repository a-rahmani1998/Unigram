// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLDocumentAttributeImageSize : TLDocumentAttributeBase 
	{
		public Int32 W { get; set; }
		public Int32 H { get; set; }

		public TLDocumentAttributeImageSize() { }
		public TLDocumentAttributeImageSize(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.DocumentAttributeImageSize; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			W = from.ReadInt32();
			H = from.ReadInt32();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x6C37C15C);
			to.Write(W);
			to.Write(H);
			if (cache) WriteToCache(to);
		}
	}
}