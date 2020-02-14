using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbPosBillDishDetail : AopObject
	{
		[XmlElement("out_detail_no")]
		public string OutDetailNo
		{
			get;
			set;
		}

		[XmlElement("trans_amount")]
		public string TransAmount
		{
			get;
			set;
		}
	}
}
