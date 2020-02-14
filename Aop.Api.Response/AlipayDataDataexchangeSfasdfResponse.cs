using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayDataDataexchangeSfasdfResponse : AopResponse
	{
		[XmlArray("azxfghd")]
		[XmlArrayItem("string")]
		public List<string> Azxfghd
		{
			get;
			set;
		}

		[XmlArray("gfdhsdasafg")]
		[XmlArrayItem("string")]
		public List<string> Gfdhsdasafg
		{
			get;
			set;
		}

		[XmlArray("gfhjfdsa")]
		[XmlArrayItem("string")]
		public List<string> Gfhjfdsa
		{
			get;
			set;
		}

		[XmlArray("ghjfdsafgh")]
		[XmlArrayItem("string")]
		public List<string> Ghjfdsafgh
		{
			get;
			set;
		}

		[XmlElement("sdvsdv")]
		public string Sdvsdv
		{
			get;
			set;
		}

		[XmlArray("wrty")]
		[XmlArrayItem("alipay_item_goods_list")]
		public List<AlipayItemGoodsList> Wrty
		{
			get;
			set;
		}
	}
}
