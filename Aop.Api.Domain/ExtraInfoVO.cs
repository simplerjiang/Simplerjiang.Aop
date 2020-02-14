using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ExtraInfoVO : AopObject
	{
		[XmlElement("maomao_friend")]
		public bool MaomaoFriend
		{
			get;
			set;
		}

		[XmlElement("maomao_register")]
		public bool MaomaoRegister
		{
			get;
			set;
		}

		[XmlElement("taobao_id")]
		public string TaobaoId
		{
			get;
			set;
		}
	}
}
