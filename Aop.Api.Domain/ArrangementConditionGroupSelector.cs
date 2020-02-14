using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ArrangementConditionGroupSelector : AopObject
	{
		[XmlElement("select_latest_pd_cd")]
		public bool SelectLatestPdCd
		{
			get;
			set;
		}
	}
}
