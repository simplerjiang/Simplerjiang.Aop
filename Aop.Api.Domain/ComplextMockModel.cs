using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ComplextMockModel : AopObject
	{
		[XmlElement("biz_model")]
		public SimpleMockModel BizModel
		{
			get;
			set;
		}

		[XmlElement("biz_num")]
		public long BizNum
		{
			get;
			set;
		}

		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}
	}
}
