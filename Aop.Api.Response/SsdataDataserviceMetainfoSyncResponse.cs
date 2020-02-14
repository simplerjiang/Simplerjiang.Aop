using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class SsdataDataserviceMetainfoSyncResponse : AopResponse
	{
		[XmlElement("is_sync_success")]
		public bool IsSyncSuccess
		{
			get;
			set;
		}

		[XmlElement("sync_result")]
		public string SyncResult
		{
			get;
			set;
		}
	}
}
