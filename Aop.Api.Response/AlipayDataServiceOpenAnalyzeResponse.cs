using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayDataServiceOpenAnalyzeResponse : AopResponse
	{
		[XmlElement("result")]
		public AlipayDataServiceResult Result
		{
			get;
			set;
		}
	}
}
