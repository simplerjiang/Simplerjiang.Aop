using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCustomerContractRecordSyncResponse : AopResponse
	{
		[XmlElement("record_no")]
		public string RecordNo
		{
			get;
			set;
		}
	}
}
