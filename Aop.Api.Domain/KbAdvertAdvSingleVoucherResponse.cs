using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertAdvSingleVoucherResponse : AopObject
	{
		[XmlArray("adv_content_list")]
		[XmlArrayItem("kb_advert_adv_content_response")]
		public List<KbAdvertAdvContentResponse> AdvContentList
		{
			get;
			set;
		}

		[XmlElement("content")]
		public KbAdvertAdvContent Content
		{
			get;
			set;
		}

		[XmlElement("voucher")]
		public KbAdvertSubjectVoucherResponse Voucher
		{
			get;
			set;
		}
	}
}
