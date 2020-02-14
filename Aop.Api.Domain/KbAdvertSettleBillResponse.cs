using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertSettleBillResponse : AopObject
	{
		[XmlElement("download_url")]
		public string DownloadUrl
		{
			get;
			set;
		}

		[XmlElement("paid_date")]
		public string PaidDate
		{
			get;
			set;
		}
	}
}
