using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayDataDpcAlisisOlapprocessorResponse : AopResponse
	{
		[XmlElement("data")]
		public string Data
		{
			get;
			set;
		}
	}
}
