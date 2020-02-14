using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingDataBizadviserMyreportQueryModel : AopObject
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

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
