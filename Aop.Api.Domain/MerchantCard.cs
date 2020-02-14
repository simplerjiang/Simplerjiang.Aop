using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MerchantCard : AopObject
	{
		[XmlElement("balance")]
		public string Balance
		{
			get;
			set;
		}

		[XmlElement("biz_card_no")]
		public string BizCardNo
		{
			get;
			set;
		}

		[XmlElement("external_card_no")]
		public string ExternalCardNo
		{
			get;
			set;
		}

		[XmlElement("front_image_id")]
		public string FrontImageId
		{
			get;
			set;
		}

		[XmlArray("front_text_list")]
		[XmlArrayItem("card_front_text_d_t_o")]
		public List<CardFrontTextDTO> FrontTextList
		{
			get;
			set;
		}

		[XmlElement("level")]
		public string Level
		{
			get;
			set;
		}

		[XmlElement("mdcode_info")]
		public MdCodeInfoDTO MdcodeInfo
		{
			get;
			set;
		}

		[XmlElement("open_date")]
		public string OpenDate
		{
			get;
			set;
		}

		[XmlElement("point")]
		public string Point
		{
			get;
			set;
		}

		[XmlElement("template_id")]
		public string TemplateId
		{
			get;
			set;
		}

		[XmlElement("valid_date")]
		public string ValidDate
		{
			get;
			set;
		}
	}
}
