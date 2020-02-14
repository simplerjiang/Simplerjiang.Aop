using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCreditEpLawsuitRecordGetResponse : AopResponse
	{
		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlElement("lawsuit_record")]
		public LawsuitRecord LawsuitRecord
		{
			get;
			set;
		}
	}
}
