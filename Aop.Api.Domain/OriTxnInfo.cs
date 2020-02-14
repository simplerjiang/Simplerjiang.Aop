using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class OriTxnInfo : AopObject
	{
		[XmlElement("category_type")]
		public string CategoryType
		{
			get;
			set;
		}

		[XmlElement("category_value")]
		public string CategoryValue
		{
			get;
			set;
		}

		[XmlElement("txn_info")]
		public string TxnInfo
		{
			get;
			set;
		}
	}
}
