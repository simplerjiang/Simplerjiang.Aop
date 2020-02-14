using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class OperatorChannelInfo : AopObject
	{
		[XmlElement("item_code")]
		public string ItemCode
		{
			get;
			set;
		}

		[XmlElement("item_desc")]
		public string ItemDesc
		{
			get;
			set;
		}

		[XmlElement("item_name")]
		public string ItemName
		{
			get;
			set;
		}

		[XmlElement("item_status")]
		public string ItemStatus
		{
			get;
			set;
		}
	}
}
