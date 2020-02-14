using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InteligentMerchantPromo : AopObject
	{
		[XmlElement("general_promo")]
		public InteligentGeneralMerchantPromo GeneralPromo
		{
			get;
			set;
		}

		[XmlElement("promo_type")]
		public string PromoType
		{
			get;
			set;
		}
	}
}
