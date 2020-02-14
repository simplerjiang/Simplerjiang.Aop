using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMpointprodBenefitDetailGetResponse : AopResponse
	{
		[XmlArray("benefit_infos")]
		[XmlArrayItem("benefit_info")]
		public List<BenefitInfo> BenefitInfos
		{
			get;
			set;
		}

		[XmlElement("code")]
		public new string Code
		{
			get;
			set;
		}

		[XmlElement("msg")]
		public new string Msg
		{
			get;
			set;
		}
	}
}
