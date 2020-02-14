using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaMerchantDataUploadInitializeModel : AopObject
	{
		[XmlElement("linked_merchant_id")]
		public string LinkedMerchantId
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
