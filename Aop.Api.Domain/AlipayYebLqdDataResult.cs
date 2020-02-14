using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayYebLqdDataResult : AopObject
	{
		[XmlElement("predict_purchase_amt")]
		public string PredictPurchaseAmt
		{
			get;
			set;
		}

		[XmlElement("predict_redeem_amt")]
		public string PredictRedeemAmt
		{
			get;
			set;
		}

		[XmlElement("target_date")]
		public string TargetDate
		{
			get;
			set;
		}
	}
}
