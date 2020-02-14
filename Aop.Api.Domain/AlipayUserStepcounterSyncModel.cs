using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserStepcounterSyncModel : AopObject
	{
		[XmlElement("age")]
		public long Age
		{
			get;
			set;
		}

		[XmlElement("calorie")]
		public string Calorie
		{
			get;
			set;
		}

		[XmlElement("count")]
		public long Count
		{
			get;
			set;
		}

		[XmlElement("data_provider")]
		public string DataProvider
		{
			get;
			set;
		}

		[XmlElement("distance")]
		public long Distance
		{
			get;
			set;
		}

		[XmlElement("height")]
		public string Height
		{
			get;
			set;
		}

		[XmlElement("latitude")]
		public string Latitude
		{
			get;
			set;
		}

		[XmlElement("longitude")]
		public string Longitude
		{
			get;
			set;
		}

		[XmlElement("out_user_id")]
		public string OutUserId
		{
			get;
			set;
		}

		[XmlElement("time")]
		public string Time
		{
			get;
			set;
		}

		[XmlElement("time_zone")]
		public string TimeZone
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}

		[XmlElement("weight")]
		public string Weight
		{
			get;
			set;
		}
	}
}
