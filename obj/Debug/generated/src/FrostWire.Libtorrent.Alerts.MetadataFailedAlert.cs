using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='MetadataFailedAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/MetadataFailedAlert", DoNotGenerateAcw=true)]
	public sealed partial class MetadataFailedAlert : global::FrostWire.Libtorrent.Alerts.TorrentAlert {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/MetadataFailedAlert", typeof (MetadataFailedAlert));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal MetadataFailedAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe global::FrostWire.Libtorrent.ErrorCode Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='MetadataFailedAlert']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()Lcom/frostwire/jlibtorrent/ErrorCode;", "GetGetErrorHandler")]
			get {
				const string __id = "getError.()Lcom/frostwire/jlibtorrent/ErrorCode;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.ErrorCode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
