// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputBotInlineResultPhoto : TLInputBotInlineResultBase 
	{
		public String Type { get; set; }
		public TLInputPhotoBase Photo { get; set; }

		public TLInputBotInlineResultPhoto() { }
		public TLInputBotInlineResultPhoto(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.InputBotInlineResultPhoto; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Id = from.ReadString();
			Type = from.ReadString();
			Photo = TLFactory.Read<TLInputPhotoBase>(from, cache);
			SendMessage = TLFactory.Read<TLInputBotInlineMessageBase>(from, cache);
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xA8D864A7);
			to.Write(Id);
			to.Write(Type);
			to.WriteObject(Photo, cache);
			to.WriteObject(SendMessage, cache);
			if (cache) WriteToCache(to);
		}
	}
}