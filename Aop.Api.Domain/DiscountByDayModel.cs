using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DiscountByDayModel : AopObject
	{
		[XmlElement("begin_day")]
		public long BeginDay
		{
			get;
			set;
		}

		[XmlElement("discount")]
		public string Discount
		{
			get;
			set;
		}

		[XmlElement("end_day")]
		public long EndDay
		{
			get;
			set;
		}
	}
}
