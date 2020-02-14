using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserCreditCard : AopObject
	{
		[XmlElement("card_no")]
		public string CardNo
		{
			get;
			set;
		}

		[XmlElement("inst_id")]
		public string InstId
		{
			get;
			set;
		}
	}
}
