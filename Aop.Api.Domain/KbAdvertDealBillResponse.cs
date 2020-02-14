using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertDealBillResponse : AopObject
	{
		[XmlElement("download_url")]
		public string DownloadUrl
		{
			get;
			set;
		}
	}
}
