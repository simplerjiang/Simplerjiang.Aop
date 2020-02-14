using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCreditPeLawsuitRecordGetResponse : AopResponse
	{
		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlElement("lawsuit_person_record")]
		public LawsuitPersonRecord LawsuitPersonRecord
		{
			get;
			set;
		}
	}
}
