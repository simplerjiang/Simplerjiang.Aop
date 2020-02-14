using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertContentPasswordModify : AopObject
	{
		[XmlElement("background_img_id")]
		public string BackgroundImgId
		{
			get;
			set;
		}

		[XmlElement("brand_name")]
		public string BrandName
		{
			get;
			set;
		}

		[XmlElement("password")]
		public string Password
		{
			get;
			set;
		}

		[XmlElement("voucher_logo_id")]
		public string VoucherLogoId
		{
			get;
			set;
		}
	}
}
