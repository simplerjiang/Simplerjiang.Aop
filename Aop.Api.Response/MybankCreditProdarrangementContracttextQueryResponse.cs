using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditProdarrangementContracttextQueryResponse : AopResponse
	{
		[XmlElement("text")]
		public string Text
		{
			get;
			set;
		}
	}
}
