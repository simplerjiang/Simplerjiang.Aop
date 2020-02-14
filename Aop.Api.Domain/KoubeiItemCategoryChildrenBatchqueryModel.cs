using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiItemCategoryChildrenBatchqueryModel : AopObject
	{
		[XmlElement("root_category_id")]
		public string RootCategoryId
		{
			get;
			set;
		}
	}
}
