using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AntMerchantExpandIndirectTransferResponse : AopResponse
	{
		[XmlElement("transfer_result")]
		public bool TransferResult
		{
			get;
			set;
		}
	}
}
