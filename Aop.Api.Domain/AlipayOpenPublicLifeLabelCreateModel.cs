using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicLifeLabelCreateModel : AopObject
	{
		[XmlElement("data_type")]
		public string DataType
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
