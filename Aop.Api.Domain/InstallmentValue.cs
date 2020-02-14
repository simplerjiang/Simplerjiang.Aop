using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InstallmentValue : AopObject
	{
		[XmlArray("installment_values")]
		[XmlArrayItem("installment_meta_info")]
		public List<InstallmentMetaInfo> InstallmentValues
		{
			get;
			set;
		}
	}
}
