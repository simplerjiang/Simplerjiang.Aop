using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZolozIdentificationUserWebInitializeResponse : AopResponse
	{
		[XmlElement("extern_info")]
		public string ExternInfo
		{
			get;
			set;
		}

		[XmlElement("zim_id")]
		public string ZimId
		{
			get;
			set;
		}
	}
}
