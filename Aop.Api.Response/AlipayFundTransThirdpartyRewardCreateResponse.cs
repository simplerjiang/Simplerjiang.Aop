using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFundTransThirdpartyRewardCreateResponse : AopResponse
	{
		[XmlElement("transfer_no")]
		public string TransferNo
		{
			get;
			set;
		}
	}
}
