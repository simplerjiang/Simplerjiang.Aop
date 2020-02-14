using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaMerchantTestPracticeResponse : AopResponse
	{
		[XmlElement("dddd")]
		public XXXXsdasdasd Dddd
		{
			get;
			set;
		}

		[XmlElement("sss")]
		public string Sss
		{
			get;
			set;
		}
	}
}
