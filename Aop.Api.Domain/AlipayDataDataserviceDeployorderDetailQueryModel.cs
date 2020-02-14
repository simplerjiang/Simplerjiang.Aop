using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayDataDataserviceDeployorderDetailQueryModel : AopObject
	{
		[XmlElement("biz_create_begin")]
		public string BizCreateBegin
		{
			get;
			set;
		}

		[XmlElement("biz_ins_name")]
		public string BizInsName
		{
			get;
			set;
		}

		[XmlElement("page")]
		public long Page
		{
			get;
			set;
		}

		[XmlElement("size")]
		public long Size
		{
			get;
			set;
		}
	}
}
