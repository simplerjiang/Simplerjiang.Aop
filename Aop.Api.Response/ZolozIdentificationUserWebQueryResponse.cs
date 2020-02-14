using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZolozIdentificationUserWebQueryResponse : AopResponse
	{
		[XmlElement("extern_info")]
		public string ExternInfo
		{
			get;
			set;
		}
	}
}
