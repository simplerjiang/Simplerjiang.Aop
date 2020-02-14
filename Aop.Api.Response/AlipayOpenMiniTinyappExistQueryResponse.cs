using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenMiniTinyappExistQueryResponse : AopResponse
	{
		[XmlElement("exist_mini")]
		public string ExistMini
		{
			get;
			set;
		}
	}
}
