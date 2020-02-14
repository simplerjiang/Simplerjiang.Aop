using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditUserRoleCreateModel : AopObject
	{
		[XmlElement("entity_code")]
		public string EntityCode
		{
			get;
			set;
		}

		[XmlElement("entity_name")]
		public string EntityName
		{
			get;
			set;
		}

		[XmlElement("entity_type")]
		public string EntityType
		{
			get;
			set;
		}

		[XmlElement("ext_data")]
		public string ExtData
		{
			get;
			set;
		}

		[XmlElement("scene_type")]
		public string SceneType
		{
			get;
			set;
		}
	}
}
