using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class BillInferenceResult : AopObject
	{
		[XmlElement("angle")]
		public long Angle
		{
			get;
			set;
		}

		[XmlElement("bill_score")]
		public long BillScore
		{
			get;
			set;
		}

		[XmlElement("bill_version")]
		public string BillVersion
		{
			get;
			set;
		}

		[XmlArray("capital_sum")]
		[XmlArrayItem("string")]
		public List<string> CapitalSum
		{
			get;
			set;
		}

		[XmlArray("date")]
		[XmlArrayItem("string")]
		public List<string> Date
		{
			get;
			set;
		}

		[XmlArray("name")]
		[XmlArrayItem("string")]
		public List<string> Name
		{
			get;
			set;
		}

		[XmlArray("no")]
		[XmlArrayItem("string")]
		public List<string> No
		{
			get;
			set;
		}

		[XmlArray("rotate_shape")]
		[XmlArrayItem("string")]
		public List<string> RotateShape
		{
			get;
			set;
		}

		[XmlArray("title")]
		[XmlArrayItem("string")]
		public List<string> Title
		{
			get;
			set;
		}
	}
}
