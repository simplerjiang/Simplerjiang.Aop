using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayZdataassetsFcdatalabZdatamergetaskResponse : AopResponse
	{
		[XmlElement("result")]
		public string Result
		{
			get;
			set;
		}
	}
}
