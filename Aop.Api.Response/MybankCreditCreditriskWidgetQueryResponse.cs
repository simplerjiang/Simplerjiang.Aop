using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditCreditriskWidgetQueryResponse : AopResponse
	{
		[XmlElement("widgetjson")]
		public string Widgetjson
		{
			get;
			set;
		}
	}
}
