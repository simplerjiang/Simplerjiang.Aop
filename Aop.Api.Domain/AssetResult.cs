using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AssetResult : AopObject
	{
		[XmlElement("assign_item_id")]
		public string AssignItemId
		{
			get;
			set;
		}

		[XmlElement("error_code")]
		public string ErrorCode
		{
			get;
			set;
		}

		[XmlElement("error_desc")]
		public string ErrorDesc
		{
			get;
			set;
		}

		[XmlElement("success")]
		public bool Success
		{
			get;
			set;
		}
	}
}
