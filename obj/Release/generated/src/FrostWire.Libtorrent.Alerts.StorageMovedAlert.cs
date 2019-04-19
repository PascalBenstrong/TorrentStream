using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='StorageMovedAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/StorageMovedAlert", DoNotGenerateAcw=true)]
	public sealed partial class StorageMovedAlert : global::FrostWire.Libtorrent.Alerts.TorrentAlert {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/StorageMovedAlert", typeof (StorageMovedAlert));
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

		internal StorageMovedAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='StorageMovedAlert']/constructor[@name='StorageMovedAlert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.storage_moved_alert']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/storage_moved_alert;)V", "")]
		public unsafe StorageMovedAlert (global::FrostWire.Libtorrent.Swig.Storage_moved_alert alert)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/storage_moved_alert;)V";

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='StorageMovedAlert']/method[@name='storagePath' and count(parameter)=0]"
		[Register ("storagePath", "()Ljava/lang/String;", "")]
		public unsafe string StoragePath ()
		{
			const string __id = "storagePath.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
