using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarCarlibInfoPushModel : AopObject
	{
		[XmlElement("brand")]
		public string Brand
		{
			get;
			set;
		}

		[XmlElement("cc")]
		public string Cc
		{
			get;
			set;
		}

		[XmlElement("company")]
		public string Company
		{
			get;
			set;
		}

		[XmlElement("engine")]
		public string Engine
		{
			get;
			set;
		}

		[XmlElement("marker")]
		public string Marker
		{
			get;
			set;
		}

		[XmlElement("prod_year")]
		public string ProdYear
		{
			get;
			set;
		}

		[XmlElement("serie")]
		public string Serie
		{
			get;
			set;
		}

		[XmlElement("style")]
		public string Style
		{
			get;
			set;
		}
	}
}
