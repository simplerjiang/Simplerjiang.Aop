using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SmartAutomatAssociate : AopObject
	{
		[XmlElement("associate_type")]
		public string AssociateType
		{
			get;
			set;
		}

		[XmlElement("associate_user_id")]
		public string AssociateUserId
		{
			get;
			set;
		}
	}
}
