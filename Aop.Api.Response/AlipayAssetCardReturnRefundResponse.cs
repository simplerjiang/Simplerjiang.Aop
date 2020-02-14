using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayAssetCardReturnRefundResponse : AopResponse
	{
		[XmlElement("account_dt")]
		public string AccountDt
		{
			get;
			set;
		}

		[XmlElement("order_no")]
		public string OrderNo
		{
			get;
			set;
		}

		[XmlElement("return_amount")]
		public string ReturnAmount
		{
			get;
			set;
		}

		[XmlElement("return_asset_amont")]
		public string ReturnAssetAmont
		{
			get;
			set;
		}

		[XmlElement("return_fee_amount")]
		public string ReturnFeeAmount
		{
			get;
			set;
		}

		[XmlElement("return_fee_asset_amount")]
		public string ReturnFeeAssetAmount
		{
			get;
			set;
		}
	}
}
