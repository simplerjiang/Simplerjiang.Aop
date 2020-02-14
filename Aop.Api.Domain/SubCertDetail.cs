using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SubCertDetail : AopObject
	{
		[XmlElement("lot_num")]
		public string LotNum
		{
			get;
			set;
		}

		[XmlElement("lot_point")]
		public string LotPoint
		{
			get;
			set;
		}

		[XmlElement("sub_lotnum")]
		public string SubLotnum
		{
			get;
			set;
		}
	}
}
