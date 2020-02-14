using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayFundTransAacollectBatchCloseModel : AopObject
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

		[XmlElement("current_user_id")]
		public string CurrentUserId
		{
			get;
			set;
		}
	}
}
