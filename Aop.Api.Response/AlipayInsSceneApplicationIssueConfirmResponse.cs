using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsSceneApplicationIssueConfirmResponse : AopResponse
	{
		[XmlElement("application_no")]
		public string ApplicationNo
		{
			get;
			set;
		}
	}
}
