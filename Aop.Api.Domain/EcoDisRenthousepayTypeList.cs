using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class EcoDisRenthousepayTypeList : AopObject
	{
		[XmlElement("foregift_amount")]
		public string ForegiftAmount
		{
			get;
			set;
		}

		[XmlElement("lease_term")]
		public long LeaseTerm
		{
			get;
			set;
		}

		[XmlArray("other_amount")]
		[XmlArrayItem("eco_renthouse_other_amount")]
		public List<EcoRenthouseOtherAmount> OtherAmount
		{
			get;
			set;
		}

		[XmlElement("pay_type")]
		public long PayType
		{
			get;
			set;
		}

		[XmlElement("room_amount")]
		public string RoomAmount
		{
			get;
			set;
		}

		[XmlElement("service_amount")]
		public string ServiceAmount
		{
			get;
			set;
		}

		[XmlElement("service_type")]
		public string ServiceType
		{
			get;
			set;
		}
	}
}
