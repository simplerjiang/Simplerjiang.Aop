using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiAdvertCommissionMissionPromoteModel : AopObject
	{
		[XmlElement("identify")]
		public string Identify
		{
			get;
			set;
		}

		[XmlElement("identify_type")]
		public string IdentifyType
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}
	}
}
