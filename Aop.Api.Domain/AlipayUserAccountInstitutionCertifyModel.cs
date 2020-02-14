using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserAccountInstitutionCertifyModel : AopObject
	{
		[XmlElement("institution_name")]
		public string InstitutionName
		{
			get;
			set;
		}

		[XmlElement("logon_id")]
		public string LogonId
		{
			get;
			set;
		}
	}
}
