using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserGradeQueryResponse : AopResponse
	{
		[XmlElement("balance")]
		public long Balance
		{
			get;
			set;
		}

		[XmlElement("grade")]
		public string Grade
		{
			get;
			set;
		}
	}
}
