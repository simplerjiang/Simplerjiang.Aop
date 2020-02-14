using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MerchantApplyResultRecord : AopObject
	{
		[XmlElement("prod_name")]
		public string ProdName
		{
			get;
			set;
		}

		[XmlElement("prop_input_key")]
		public string PropInputKey
		{
			get;
			set;
		}

		[XmlElement("result_msg")]
		public string ResultMsg
		{
			get;
			set;
		}

		[XmlElement("result_status")]
		public string ResultStatus
		{
			get;
			set;
		}

		[XmlElement("result_type")]
		public string ResultType
		{
			get;
			set;
		}
	}
}
