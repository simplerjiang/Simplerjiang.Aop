using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaMerchantSingleDataUploadResponse : AopResponse
	{
		[XmlElement("biz_ext_params")]
		public string BizExtParams
		{
			get;
			set;
		}

		[XmlElement("task_id")]
		public string TaskId
		{
			get;
			set;
		}
	}
}
