using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingDataBizadviserMyddsreportQueryModel : AopObject
	{
		[XmlElement("req_parameters")]
		public string ReqParameters
		{
			get;
			set;
		}

		[XmlElement("uniq_key")]
		public string UniqKey
		{
			get;
			set;
		}
	}
}
