using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserSceneCooperationConsultModel : AopObject
	{
		[XmlElement("invite_scene")]
		public string InviteScene
		{
			get;
			set;
		}

		[XmlElement("partner_id")]
		public string PartnerId
		{
			get;
			set;
		}

		[XmlElement("pid")]
		public string Pid
		{
			get;
			set;
		}

		[XmlElement("principal")]
		public AlipayUserPrincipalInfo Principal
		{
			get;
			set;
		}

		[XmlElement("scene")]
		public string Scene
		{
			get;
			set;
		}
	}
}
