using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoEduKtStudentModifyResponse : AopResponse
	{
		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
