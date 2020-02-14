using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiAdvertCommissionAdvertQueryResponse : AopResponse
	{
		[XmlArray("data")]
		[XmlArrayItem("kb_advert_adv_response")]
		public List<KbAdvertAdvResponse> Data
		{
			get;
			set;
		}
	}
}
