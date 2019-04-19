using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='SaveResumeDataFailedAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/SaveResumeDataFailedAlert", DoNotGenerateAcw=true)]
	public sealed partial class SaveResumeDataFailedAlert : global::FrostWire.Libtorrent.Alerts.TorrentAlert {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/SaveResumeDataFailedAlert", typeof (SaveResumeDataFailedAlert));
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

		internal SaveResumeDataFailedAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='SaveResumeDataFailedAlert']/method[@name='error' and count(parameter)=0]"
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

	}
}
