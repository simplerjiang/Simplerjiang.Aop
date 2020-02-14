using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingToolFengdieEditorQueryModel : AopObject
	{
		[XmlElement("activity_id")]
		public long ActivityId
		{
			get;
			set;
		}

		[XmlElement("redirect_url")]
		public string RedirectUrl
		{
			get;
			set;
		}
	}
}
