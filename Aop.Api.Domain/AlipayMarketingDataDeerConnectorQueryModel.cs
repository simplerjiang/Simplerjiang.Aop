using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingDataDeerConnectorQueryModel : AopObject
	{
		[XmlElement("connector_id")]
		public string ConnectorId
		{
			get;
			set;
		}

		[XmlElement("params")]
		public string Params
		{
			get;
			set;
		}
	}
}
