using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityProdSeAppletQueryModel : AopObject
	{
		[XmlElement("opt_type")]
		public long OptType
		{
			get;
			set;
		}

		[XmlElement("param")]
		public string Param
		{
			get;
			set;
		}

		[XmlElement("partner_id")]
		public string PartnerId
		{
			get;
			set;
		}

		[XmlElement("se_id")]
		public string SeId
		{
			get;
			set;
		}

		[XmlElement("se_version")]
		public string SeVersion
		{
			get;
			set;
		}

		[XmlElement("sub_opt_type")]
		public long SubOptType
		{
			get;
			set;
		}
	}
}
