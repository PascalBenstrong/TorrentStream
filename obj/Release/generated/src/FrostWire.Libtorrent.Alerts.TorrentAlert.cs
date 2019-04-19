using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='TorrentAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/TorrentAlert", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.frostwire.jlibtorrent.swig.torrent_alert"})]
	public partial class TorrentAlert : global::FrostWire.Libtorrent.Alerts.AbstractAlert {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/TorrentAlert", typeof (TorrentAlert));
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

		protected TorrentAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_handle;
#pragma warning disable 0169
		static Delegate GetHandleHandler ()
		{
			if (cb_handle == null)
				cb_handle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Handle);
			return cb_handle;
		}

		static IntPtr n_Handle (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Alerts.TorrentAlert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.TorrentAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Handle ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='TorrentAlert']/method[@name='handle' and count(parameter)=0]"
		[Register ("handle", "()Lcom/frostwire/jlibtorrent/TorrentHandle;", "GetHandleHandler")]
		public new virtual unsafe global::FrostWire.Libtorrent.TorrentHandle Handle ()
		{
			const string __id = "handle.()Lcom/frostwire/jlibtorrent/TorrentHandle;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentHandle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_torrentName;
#pragma warning disable 0169
		static Delegate GetTorrentNameHandler ()
		{
			if (cb_torrentName == null)
				cb_torrentName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_TorrentName);
			return cb_torrentName;
		}

		static IntPtr n_TorrentName (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Alerts.TorrentAlert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.TorrentAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TorrentName ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='TorrentAlert']/method[@name='torrentName' and count(parameter)=0]"
		[Register ("torrentName", "()Ljava/lang/String;", "GetTorrentNameHandler")]
		public virtual unsafe string TorrentName ()
		{
			const string __id = "torrentName.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
