using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FengdiePreviewQueryRespModel : AopObject
	{
		[XmlArray("list")]
		[XmlArrayItem("fengdie_preview_pages_model")]
		public List<FengdiePreviewPagesModel> List
		{
			get;
			set;
		}
	}
}
