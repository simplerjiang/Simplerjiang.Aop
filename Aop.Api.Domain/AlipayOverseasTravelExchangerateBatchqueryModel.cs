using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOverseasTravelExchangerateBatchqueryModel : AopObject
	{
		[XmlArray("currencies")]
		[XmlArrayItem("string")]
		public List<string> Currencies
		{
			get;
			set;
		}

		[XmlElement("extend_param")]
		public string ExtendParam
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
