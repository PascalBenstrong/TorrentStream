using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='TrackerAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/TrackerAlert", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.frostwire.jlibtorrent.swig.tracker_alert"})]
	public partial class TrackerAlert : global::FrostWire.Libtorrent.Alerts.TorrentAlert {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/TrackerAlert", typeof (TrackerAlert));
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

		protected TrackerAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_localEndpoint;
#pragma warning disable 0169
		static Delegate GetLocalEndpointHandler ()
		{
			if (cb_localEndpoint == null)
				cb_localEndpoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_LocalEndpoint);
			return cb_localEndpoint;
		}

		static IntPtr n_LocalEndpoint (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Alerts.TrackerAlert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.TrackerAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LocalEndpoint ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='TrackerAlert']/method[@name='localEndpoint' and count(parameter)=0]"
		[Register ("localEndpoint", "()Lcom/frostwire/jlibtorrent/TcpEndpoint;", "GetLocalEndpointHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.TcpEndpoint LocalEndpoint ()
		{
			const string __id = "localEndpoint.()Lcom/frostwire/jlibtorrent/TcpEndpoint;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TcpEndpoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_trackerUrl;
#pragma warning disable 0169
		static Delegate GetTrackerUrlHandler ()
		{
			if (cb_trackerUrl == null)
				cb_trackerUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_TrackerUrl);
			return cb_trackerUrl;
		}

		static IntPtr n_TrackerUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Alerts.TrackerAlert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.TrackerAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TrackerUrl ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='TrackerAlert']/method[@name='trackerUrl' and count(parameter)=0]"
		[Register ("trackerUrl", "()Ljava/lang/String;", "GetTrackerUrlHandler")]
		public virtual unsafe string TrackerUrl ()
		{
			const string __id = "trackerUrl.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
