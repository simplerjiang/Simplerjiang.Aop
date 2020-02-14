using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayFundTransAacollectBatchQueryModel : AopObject
	{
		[XmlElement("batch_no")]
		public string BatchNo
		{
			get;
			set;
		}

		[XmlElement("batch_token")]
		public string BatchToken
		{
			get;
			set;
		}
	}
}
