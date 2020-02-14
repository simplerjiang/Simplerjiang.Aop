using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class RecResultInfo : AopObject
	{
		[XmlElement("code")]
		public string Code
		{
			get;
			set;
		}

		[XmlArray("items")]
		[XmlArrayItem("rec_item_info")]
		public List<RecItemInfo> Items
		{
			get;
			set;
		}

		[XmlElement("msg")]
		public string Msg
		{
			get;
			set;
		}

		[XmlElement("position_id")]
		public string PositionId
		{
			get;
			set;
		}

		[XmlElement("success")]
		public bool Success
		{
			get;
			set;
		}
	}
}
