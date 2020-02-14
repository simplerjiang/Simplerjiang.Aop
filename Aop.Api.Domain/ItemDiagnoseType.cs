using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ItemDiagnoseType : AopObject
	{
		[XmlElement("item_diagnose")]
		public string ItemDiagnose
		{
			get;
			set;
		}

		[XmlElement("item_diagnose_desc")]
		public string ItemDiagnoseDesc
		{
			get;
			set;
		}
	}
}
