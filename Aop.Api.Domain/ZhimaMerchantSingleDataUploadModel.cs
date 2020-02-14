using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaMerchantSingleDataUploadModel : AopObject
	{
		[XmlElement("biz_ext_params")]
		public string BizExtParams
		{
			get;
			set;
		}

		[XmlElement("data")]
		public string Data
		{
			get;
			set;
		}

		[XmlElement("linked_merchant_id")]
		public string LinkedMerchantId
		{
			get;
			set;
		}

		[XmlElement("primary_keys")]
		public string PrimaryKeys
		{
			get;
			set;
		}

		[XmlElement("scene_code")]
		public string SceneCode
		{
			get;
			set;
		}
	}
}
