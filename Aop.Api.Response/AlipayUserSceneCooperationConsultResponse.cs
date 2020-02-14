using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserSceneCooperationConsultResponse : AopResponse
	{
		[XmlElement("consult_result")]
		public bool ConsultResult
		{
			get;
			set;
		}

		[XmlElement("invite_result")]
		public bool InviteResult
		{
			get;
			set;
		}
	}
}
