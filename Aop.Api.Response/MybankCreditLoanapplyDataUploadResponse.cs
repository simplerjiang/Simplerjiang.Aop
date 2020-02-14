using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditLoanapplyDataUploadResponse : AopResponse
	{
		[XmlElement("data_id")]
		public string DataId
		{
			get;
			set;
		}
	}
}
