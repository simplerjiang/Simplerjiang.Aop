using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppProdmodeTasknodeQueryModel : AopObject
	{
		[XmlElement("task_id")]
		public string TaskId
		{
			get;
			set;
		}
	}
}
