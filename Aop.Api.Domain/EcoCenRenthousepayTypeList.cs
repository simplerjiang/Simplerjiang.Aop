using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class EcoCenRenthousepayTypeList : AopObject
	{
		[XmlElement("foregift_amount")]
		public string ForegiftAmount
		{
			get;
			set;
		}

		[XmlElement("max_amount")]
		public string MaxAmount
		{
			get;
			set;
		}

		[XmlElement("max_deposit_amount")]
		public string MaxDepositAmount
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
	}
}
