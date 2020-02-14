using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FengdieSuccessRespModel : AopObject
	{
		[XmlElement("success")]
		public bool Success
		{
			get;
			set;
		}
	}
}
