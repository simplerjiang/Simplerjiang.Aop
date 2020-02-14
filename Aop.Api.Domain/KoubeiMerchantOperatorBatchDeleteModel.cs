using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMerchantOperatorBatchDeleteModel : AopObject
	{
		[XmlElement("auth_code")]
		public string AuthCode
		{
			get;
			set;
		}

		[XmlArray("operators")]
		[XmlArrayItem("string")]
		public List<string> Operators
		{
			get;
			set;
		}
	}
}
