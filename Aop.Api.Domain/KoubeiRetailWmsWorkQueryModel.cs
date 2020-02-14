using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiRetailWmsWorkQueryModel : AopObject
	{
		[XmlElement("operate_context")]
		public OperateContext OperateContext
		{
			get;
			set;
		}

		[XmlElement("work_id")]
		public string WorkId
		{
			get;
			set;
		}
	}
}
