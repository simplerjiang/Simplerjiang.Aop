using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySocialBaseRelationCombinedQueryModel : AopObject
	{
		[XmlElement("limit")]
		public long Limit
		{
			get;
			set;
		}

		[XmlElement("scene_code")]
		public string SceneCode
		{
			get;
			set;
		}
	}
}
