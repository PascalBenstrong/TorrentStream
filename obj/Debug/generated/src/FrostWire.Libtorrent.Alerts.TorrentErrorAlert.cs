using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='TorrentErrorAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/TorrentErrorAlert", DoNotGenerateAcw=true)]
	public sealed partial class TorrentErrorAlert : global::FrostWire.Libtorrent.Alerts.TorrentAlert {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/TorrentErrorAlert", typeof (TorrentErrorAlert));
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

		internal TorrentErrorAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='TorrentErrorAlert']/method[@name='error' and count(parameter)=0]"
		[Register ("error", "()Lcom/frostwire/jlibtorrent/ErrorCode;", "")]
		public unsafe global::FrostWire.Libtorrent.ErrorCode Error ()
		{
			const string __id = "error.()Lcom/frostwire/jlibtorrent/ErrorCode;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.ErrorCode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='TorrentErrorAlert']/method[@name='filename' and count(parameter)=0]"
		[Register ("filename", "()Ljava/lang/String;", "")]
		public unsafe string Filename ()
		{
			const string __id = "filename.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
