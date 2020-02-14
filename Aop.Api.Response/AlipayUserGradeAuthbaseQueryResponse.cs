using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserGradeAuthbaseQueryResponse : AopResponse
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
