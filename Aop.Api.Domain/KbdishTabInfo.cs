using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbdishTabInfo : AopObject
	{
		[XmlElement("area_id")]
		public string AreaId
		{
			get;
			set;
		}

		[XmlElement("create_user")]
		public string CreateUser
		{
			get;
			set;
		}

		[XmlElement("fee_price")]
		public string FeePrice
		{
			get;
			set;
		}

		[XmlElement("seat_count")]
		public string SeatCount
		{
			get;
			set;
		}

		[XmlElement("tab_id")]
		public string TabId
		{
			get;
			set;
		}

		[XmlElement("tab_name")]
		public string TabName
		{
			get;
			set;
		}

		[XmlElement("tab_sort")]
		public string TabSort
		{
			get;
			set;
		}

		[XmlElement("tab_tstatus")]
		public string TabTstatus
		{
			get;
			set;
		}

		[XmlElement("update_user")]
		public string UpdateUser
		{
			get;
			set;
		}
	}
}
