using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='TrackerReplyAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/TrackerReplyAlert", DoNotGenerateAcw=true)]
	public sealed partial class TrackerReplyAlert : global::FrostWire.Libtorrent.Alerts.TrackerAlert {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/TrackerReplyAlert", typeof (TrackerReplyAlert));
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

		internal TrackerReplyAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='TrackerReplyAlert']/constructor[@name='TrackerReplyAlert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.tracker_reply_alert']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/tracker_reply_alert;)V", "")]
		public unsafe TrackerReplyAlert (global::FrostWire.Libtorrent.Swig.Tracker_reply_alert alert)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/tracker_reply_alert;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((alert == null) ? IntPtr.Zero : ((global::Java.Lang.Object) alert).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='TrackerReplyAlert']/method[@name='numPeers' and count(parameter)=0]"
		[Register ("numPeers", "()I", "")]
		public unsafe int NumPeers ()
		{
			const string __id = "numPeers.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
