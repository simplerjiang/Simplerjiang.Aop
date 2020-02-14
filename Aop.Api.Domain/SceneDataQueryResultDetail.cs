using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SceneDataQueryResultDetail : AopObject
	{
		[XmlElement("app_seqno")]
		public string AppSeqno
		{
			get;
			set;
		}

		[XmlElement("result")]
		public string Result
		{
			get;
			set;
		}
	}
}
