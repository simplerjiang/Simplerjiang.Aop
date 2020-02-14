using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCardTemplateQueryResponse : AopResponse
	{
		[XmlElement("biz_no_prefix")]
		public string BizNoPrefix
		{
			get;
			set;
		}

		[XmlElement("biz_no_suffix_len")]
		public string BizNoSuffixLen
		{
			get;
			set;
		}

		[XmlArray("card_action_list")]
		[XmlArrayItem("template_action_info_d_t_o")]
		public List<TemplateActionInfoDTO> CardActionList
		{
			get;
			set;
		}

		[XmlArray("card_level_confs")]
		[XmlArrayItem("template_card_level_conf_d_t_o")]
		public List<TemplateCardLevelConfDTO> CardLevelConfs
		{
			get;
			set;
		}

		[XmlElement("card_spec_tag")]
		public string CardSpecTag
		{
			get;
			set;
		}

		[XmlElement("card_type")]
		public string CardType
		{
			get;
			set;
		}

		[XmlArray("column_info_list")]
		[XmlArrayItem("template_column_info_d_t_o")]
		public List<TemplateColumnInfoDTO> ColumnInfoList
		{
			get;
			set;
		}

		[XmlArray("field_rule_list")]
		[XmlArrayItem("template_field_rule_d_t_o")]
		public List<TemplateFieldRuleDTO> FieldRuleList
		{
			get;
			set;
		}

		[XmlElement("mdcode_notify_conf")]
		public TemplateMdcodeNotifyConfDTO MdcodeNotifyConf
		{
			get;
			set;
		}

		[XmlElement("open_card_conf")]
		public TemplateOpenCardConfDTO OpenCardConf
		{
			get;
			set;
		}

		[XmlArray("pub_channels")]
		[XmlArrayItem("pub_channel_d_t_o")]
		public List<PubChannelDTO> PubChannels
		{
			get;
			set;
		}

		[XmlArray("service_label_list")]
		[XmlArrayItem("string")]
		public List<string> ServiceLabelList
		{
			get;
			set;
		}

		[XmlArray("shop_ids")]
		[XmlArrayItem("string")]
		public List<string> ShopIds
		{
			get;
			set;
		}

		[XmlArray("template_benefit_info")]
		[XmlArrayItem("template_benefit_info_d_t_o")]
		public List<TemplateBenefitInfoDTO> TemplateBenefitInfo
		{
			get;
			set;
		}

		[XmlElement("template_style_info")]
		public TemplateStyleInfoDTO TemplateStyleInfo
		{
			get;
			set;
		}
	}
}
