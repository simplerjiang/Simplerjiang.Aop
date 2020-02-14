using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditUserRoleQueryModel : AopObject
	{
		[XmlElement("member")]
		public Member Member
		{
			get;
			set;
		}
	}
}
