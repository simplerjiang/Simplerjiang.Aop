using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOverseasTravelContentCancelModel : AopObject
	{
		[XmlElement("content_id")]
		public string ContentId
		{
			get;
			set;
		}

		[XmlElement("modified_date")]
		public long ModifiedDate
		{
			get;
			set;
		}
	}
}
