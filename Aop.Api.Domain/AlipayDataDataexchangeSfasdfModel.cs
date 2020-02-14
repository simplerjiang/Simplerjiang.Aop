using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayDataDataexchangeSfasdfModel : AopObject
	{
		[XmlElement("adsfghjf")]
		public AlipayItemVoucherTemplete Adsfghjf
		{
			get;
			set;
		}

		[XmlArray("easadasfd")]
		[XmlArrayItem("string")]
		public List<string> Easadasfd
		{
			get;
			set;
		}

		[XmlArray("gdfsa")]
		[XmlArrayItem("string")]
		public List<string> Gdfsa
		{
			get;
			set;
		}

		[XmlElement("hjgdfs")]
		public string Hjgdfs
		{
			get;
			set;
		}

		[XmlArray("sdfgsdfg")]
		[XmlArrayItem("string")]
		public List<string> Sdfgsdfg
		{
			get;
			set;
		}

		[XmlArray("wehtegf")]
		[XmlArrayItem("string")]
		public List<string> Wehtegf
		{
			get;
			set;
		}
	}
}
