using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsSceneApplicationIssueConfirmModel : AopObject
	{
		[XmlElement("application_no")]
		public string ApplicationNo
		{
			get;
			set;
		}
	}
}
