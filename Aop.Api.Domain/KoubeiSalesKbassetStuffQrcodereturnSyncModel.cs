using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiSalesKbassetStuffQrcodereturnSyncModel : AopObject
	{
		[XmlArray("return_qrcodes")]
		[XmlArrayItem("access_return_qrcode")]
		public List<AccessReturnQrcode> ReturnQrcodes
		{
			get;
			set;
		}
	}
}
