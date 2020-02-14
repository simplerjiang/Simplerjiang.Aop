using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SsdataFindataOperatorUserinfoCertifyModel : AopObject
	{
		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlElement("form_map")]
		public LoginForm FormMap
		{
			get;
			set;
		}
	}
}
