using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcardEduPublicBindResponse : AopResponse
	{
		[XmlElement("agent_code")]
		public string AgentCode
		{
			get;
			set;
		}

		[XmlElement("card_no")]
		public string CardNo
		{
			get;
			set;
		}

		[XmlElement("return_code")]
		public string ReturnCode
		{
			get;
			set;
		}
	}
}
