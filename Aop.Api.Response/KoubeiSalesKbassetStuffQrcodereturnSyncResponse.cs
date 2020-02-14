using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiSalesKbassetStuffQrcodereturnSyncResponse : AopResponse
	{
		[XmlArray("return_qrcode_results")]
		[XmlArrayItem("access_return_qrcode_result")]
		public List<AccessReturnQrcodeResult> ReturnQrcodeResults
		{
			get;
			set;
		}
	}
}
