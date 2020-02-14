using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaAuthInfoAuthqueryResponse : AopResponse
	{
		[XmlElement("authorized")]
		public bool Authorized
		{
			get;
			set;
		}
	}
}
