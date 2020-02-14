using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayTradeMergePrecreateModel : AopObject
	{
		[XmlArray("order_details")]
		[XmlArrayItem("order_detail")]
		public List<OrderDetail> OrderDetails
		{
			get;
			set;
		}

		[XmlElement("out_merge_no")]
		public string OutMergeNo
		{
			get;
			set;
		}

		[XmlElement("timeout_express")]
		public string TimeoutExpress
		{
			get;
			set;
		}
	}
}
