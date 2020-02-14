using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiItemExtitemInfoQueryResponse : AopResponse
	{
		[XmlElement("kb_ext_item_info")]
		public KbExtItemInfo KbExtItemInfo
		{
			get;
			set;
		}
	}
}
