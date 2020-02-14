using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserAntpaasAddtesttagModifyModel : AopObject
	{
		[XmlElement("account_no")]
		public string AccountNo
		{
			get;
			set;
		}
	}
}
