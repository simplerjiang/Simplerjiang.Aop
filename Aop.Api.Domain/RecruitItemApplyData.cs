using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class RecruitItemApplyData : AopObject
	{
		[XmlElement("activity_price")]
		public string ActivityPrice
		{
			get;
			set;
		}

		[XmlElement("activity_stock")]
		public string ActivityStock
		{
			get;
			set;
		}

		[XmlElement("item_id")]
		public string ItemId
		{
			get;
			set;
		}

		[XmlElement("original_price")]
		public string OriginalPrice
		{
			get;
			set;
		}

		[XmlElement("sales")]
		public string Sales
		{
			get;
			set;
		}
	}
}
