using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SceneExtParam : AopObject
	{
		[XmlElement("apply_reason")]
		public string ApplyReason
		{
			get;
			set;
		}

		[XmlElement("contract_no")]
		public string ContractNo
		{
			get;
			set;
		}

		[XmlElement("discountamt")]
		public string Discountamt
		{
			get;
			set;
		}

		[XmlElement("firstpayamt")]
		public string Firstpayamt
		{
			get;
			set;
		}

		[XmlElement("interestrate")]
		public string Interestrate
		{
			get;
			set;
		}

		[XmlElement("lastpayamt")]
		public string Lastpayamt
		{
			get;
			set;
		}

		[XmlElement("monthpayamt")]
		public string Monthpayamt
		{
			get;
			set;
		}

		[XmlElement("remark")]
		public string Remark
		{
			get;
			set;
		}
	}
}
