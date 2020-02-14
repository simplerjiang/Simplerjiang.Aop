using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicLifeLabelModifyModel : AopObject
	{
		[XmlElement("label_id")]
		public string LabelId
		{
			get;
			set;
		}

		[XmlElement("label_name")]
		public string LabelName
		{
			get;
			set;
		}
	}
}
