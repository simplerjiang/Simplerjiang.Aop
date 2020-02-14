using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiRetailTopinstanceQueryModel : AopObject
	{
		[XmlElement("instance_type")]
		public string InstanceType
		{
			get;
			set;
		}
	}
}
