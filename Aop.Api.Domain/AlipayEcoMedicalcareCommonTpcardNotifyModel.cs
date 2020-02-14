using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMedicalcareCommonTpcardNotifyModel : AopObject
	{
		[XmlArray("action_info")]
		[XmlArrayItem("medical_sv_tp_card_action_info")]
		public List<MedicalSvTpCardActionInfo> ActionInfo
		{
			get;
			set;
		}

		[XmlArray("body_info")]
		[XmlArrayItem("medical_sv_tp_card_body_info")]
		public List<MedicalSvTpCardBodyInfo> BodyInfo
		{
			get;
			set;
		}

		[XmlElement("extend_params")]
		public string ExtendParams
		{
			get;
			set;
		}

		[XmlElement("header_info")]
		public MedicalSvTpCardHeadInfo HeaderInfo
		{
			get;
			set;
		}

		[XmlElement("notify_time")]
		public string NotifyTime
		{
			get;
			set;
		}

		[XmlElement("operate")]
		public string Operate
		{
			get;
			set;
		}

		[XmlElement("template_code")]
		public string TemplateCode
		{
			get;
			set;
		}

		[XmlElement("third_no")]
		public string ThirdNo
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
