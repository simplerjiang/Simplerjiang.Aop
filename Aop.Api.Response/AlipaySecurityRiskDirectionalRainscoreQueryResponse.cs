using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityRiskDirectionalRainscoreQueryResponse : AopResponse
	{
		[XmlArray("infocode")]
		[XmlArrayItem("info_code")]
		public List<InfoCode> Infocode
		{
			get;
			set;
		}

		[XmlElement("score")]
		public string Score
		{
			get;
			set;
		}

		[XmlElement("unique_id")]
		public string UniqueId
		{
			get;
			set;
		}
	}
}
