using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiAdvertCommissionAdvertPurchaseResponse : AopResponse
	{
		[XmlArray("identify_codes")]
		[XmlArrayItem("kb_advert_identify_response")]
		public List<KbAdvertIdentifyResponse> IdentifyCodes
		{
			get;
			set;
		}
	}
}
