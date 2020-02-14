using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZolozAuthenticationCustomerFacemanageDeleteResponse : AopResponse
	{
		[XmlElement("result")]
		public string Result
		{
			get;
			set;
		}

		[XmlElement("retcode")]
		public string Retcode
		{
			get;
			set;
		}

		[XmlElement("retcodesub")]
		public string Retcodesub
		{
			get;
			set;
		}

		[XmlElement("retmessage")]
		public string Retmessage
		{
			get;
			set;
		}

		[XmlElement("retmessagesub")]
		public string Retmessagesub
		{
			get;
			set;
		}
	}
}
