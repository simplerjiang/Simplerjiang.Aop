using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingCampaignRetailDmQueryModel : AopObject
	{
		[XmlElement("content_id")]
		public string ContentId
		{
			get;
			set;
		}
	}
}
