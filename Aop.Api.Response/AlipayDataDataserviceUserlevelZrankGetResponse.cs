using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayDataDataserviceUserlevelZrankGetResponse : AopResponse
	{
		[XmlElement("result")]
		public AlipayHighValueCustomerResult Result
		{
			get;
			set;
		}
	}
}
