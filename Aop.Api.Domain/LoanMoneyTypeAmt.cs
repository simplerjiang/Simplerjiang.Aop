using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class LoanMoneyTypeAmt : AopObject
	{
		[XmlElement("fee")]
		public string Fee
		{
			get;
			set;
		}

		[XmlElement("intr")]
		public string Intr
		{
			get;
			set;
		}

		[XmlElement("ovd_fine")]
		public string OvdFine
		{
			get;
			set;
		}

		[XmlElement("ovd_int")]
		public string OvdInt
		{
			get;
			set;
		}

		[XmlElement("ovd_int_pny")]
		public string OvdIntPny
		{
			get;
			set;
		}

		[XmlElement("ovd_prin")]
		public string OvdPrin
		{
			get;
			set;
		}

		[XmlElement("ovd_prin_pny")]
		public string OvdPrinPny
		{
			get;
			set;
		}

		[XmlElement("prin")]
		public string Prin
		{
			get;
			set;
		}
	}
}
