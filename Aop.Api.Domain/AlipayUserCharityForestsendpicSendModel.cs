using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserCharityForestsendpicSendModel : AopObject
	{
		[XmlElement("forest_id")]
		public string ForestId
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("pic_ext_info")]
		public string PicExtInfo
		{
			get;
			set;
		}

		[XmlElement("pic_url")]
		public string PicUrl
		{
			get;
			set;
		}

		[XmlElement("shoot_time")]
		public string ShootTime
		{
			get;
			set;
		}
	}
}
