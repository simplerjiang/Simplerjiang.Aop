using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbCodeBindInfoVO : AopObject
	{
		[XmlElement("area_name")]
		public string AreaName
		{
			get;
			set;
		}

		[XmlElement("max_pepole_num")]
		public long MaxPepoleNum
		{
			get;
			set;
		}

		[XmlElement("min_pepole_num")]
		public string MinPepoleNum
		{
			get;
			set;
		}

		[XmlElement("shop_id")]
		public string ShopId
		{
			get;
			set;
		}

		[XmlElement("table_name")]
		public string TableName
		{
			get;
			set;
		}

		[XmlElement("table_no")]
		public string TableNo
		{
			get;
			set;
		}
	}
}
