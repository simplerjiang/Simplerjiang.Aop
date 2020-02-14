using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FengdieEditorGetRespModel : AopObject
	{
		[XmlElement("url")]
		public string Url
		{
			get;
			set;
		}
	}
}
