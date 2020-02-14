using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiAdvertCommissionSpecialadvcontentModifyResponse : AopResponse
	{
		[XmlArray("data")]
		[XmlArrayItem("kb_advert_special_adv_content_modify_response")]
		public List<KbAdvertSpecialAdvContentModifyResponse> Data
		{
			get;
			set;
		}
	}
}
