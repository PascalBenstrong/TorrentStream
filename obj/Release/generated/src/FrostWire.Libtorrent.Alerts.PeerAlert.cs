using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/PeerAlert", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.frostwire.jlibtorrent.swig.peer_alert"})]
	public partial class PeerAlert : global::FrostWire.Libtorrent.Alerts.TorrentAlert {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/PeerAlert", typeof (PeerAlert));
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

		protected PeerAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_endpoint;
#pragma warning disable 0169
		static Delegate GetEndpointHandler ()
		{
			if (cb_endpoint == null)
				cb_endpoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Endpoint);
			return cb_endpoint;
		}

		static IntPtr n_Endpoint (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Alerts.PeerAlert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PeerAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Endpoint ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerAlert']/method[@name='endpoint' and count(parameter)=0]"
		[Register ("endpoint", "()Lcom/frostwire/jlibtorrent/TcpEndpoint;", "GetEndpointHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.TcpEndpoint Endpoint ()
		{
			const string __id = "endpoint.()Lcom/frostwire/jlibtorrent/TcpEndpoint;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TcpEndpoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_peerId;
#pragma warning disable 0169
		static Delegate GetPeerIdHandler ()
		{
			if (cb_peerId == null)
				cb_peerId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_PeerId);
			return cb_peerId;
		}

		static IntPtr n_PeerId (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Alerts.PeerAlert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PeerAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PeerId ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerAlert']/method[@name='peerId' and count(parameter)=0]"
		[Register ("peerId", "()Lcom/frostwire/jlibtorrent/Sha1Hash;", "GetPeerIdHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Sha1Hash PeerId ()
		{
			const string __id = "peerId.()Lcom/frostwire/jlibtorrent/Sha1Hash;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Sha1Hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
