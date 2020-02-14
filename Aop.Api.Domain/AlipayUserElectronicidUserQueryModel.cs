using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserElectronicidUserQueryModel : AopObject
	{
		[XmlElement("barcode")]
		public string Barcode
		{
			get;
			set;
		}
	}
}
