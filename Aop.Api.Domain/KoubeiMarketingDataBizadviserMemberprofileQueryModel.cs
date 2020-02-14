using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingDataBizadviserMemberprofileQueryModel : AopObject
	{
		[XmlElement("member_grade")]
		public string MemberGrade
		{
			get;
			set;
		}
	}
}
