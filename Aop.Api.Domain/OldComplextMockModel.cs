using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class OldComplextMockModel : AopObject
	{
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

		[XmlElement("simple_mock_model")]
		public SimpleMockModel SimpleMockModel
		{
			get;
			set;
		}
	}
}
