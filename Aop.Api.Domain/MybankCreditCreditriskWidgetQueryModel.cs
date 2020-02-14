using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditCreditriskWidgetQueryModel : AopObject
	{
		[XmlElement("alipay_user_id")]
		public string AlipayUserId
		{
			get;
			set;
		}
	}
}
