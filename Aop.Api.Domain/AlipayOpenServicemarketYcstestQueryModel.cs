using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenServicemarketYcstestQueryModel : AopObject
	{
		[XmlElement("in_1")]
		public string In1
		{
			get;
			set;
		}

		[XmlElement("in_2")]
		public bool In2
		{
			get;
			set;
		}

		[XmlElement("in_3")]
		public string In3
		{
			get;
			set;
		}

		[XmlElement("in_4")]
		public long In4
		{
			get;
			set;
		}

		[XmlElement("in_5")]
		public string In5
		{
			get;
			set;
		}

		[XmlElement("in_6")]
		public XwbTestData In6
		{
			get;
			set;
		}
	}
}
