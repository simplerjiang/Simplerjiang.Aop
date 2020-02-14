using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppIsvProdmodeCreateModel : AopObject
	{
		[XmlElement("biz_data")]
		public string BizData
		{
			get;
			set;
		}
	}
}
