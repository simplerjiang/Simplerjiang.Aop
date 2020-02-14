using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZolozIdentificationZolozidGetResponse : AopResponse
	{
		[XmlElement("result_info")]
		public string ResultInfo
		{
			get;
			set;
		}
	}
}
