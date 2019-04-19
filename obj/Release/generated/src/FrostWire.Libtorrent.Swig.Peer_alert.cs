using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_alert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/peer_alert", DoNotGenerateAcw=true)]
	public partial class Peer_alert : global::FrostWire.Libtorrent.Swig.Torrent_alert {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/peer_alert", typeof (Peer_alert));
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

		protected Peer_alert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_alert']/constructor[@name='peer_alert' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Peer_alert (long cPtr, bool cMemoryOwn)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (cPtr);
				__args [1] = new JniArgumentValue (cMemoryOwn);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getPid;
#pragma warning disable 0169
		static Delegate GetGetPidHandler ()
		{
			if (cb_getPid == null)
				cb_getPid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPid);
			return cb_getPid;
		}

		static IntPtr n_GetPid (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Pid);
		}
#pragma warning restore 0169

		static Delegate cb_setPid_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
#pragma warning disable 0169
		static Delegate GetSetPid_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler ()
		{
			if (cb_setPid_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ == null)
				cb_setPid_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPid_Lcom_frostwire_jlibtorrent_swig_sha1_hash_);
			return cb_setPid_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
		}

		static void n_SetPid_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Sha1_hash value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Pid = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Sha1_hash Pid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_alert']/method[@name='getPid' and count(parameter)=0]"
			[Register ("getPid", "()Lcom/frostwire/jlibtorrent/swig/sha1_hash;", "GetGetPidHandler")]
			get {
				const string __id = "getPid.()Lcom/frostwire/jlibtorrent/swig/sha1_hash;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_alert']/method[@name='setPid' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.sha1_hash']]"
			[Register ("setPid", "(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V", "GetSetPid_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler")]
			set {
				const string __id = "setPid.(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_alert']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.peer_alert']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/peer_alert;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Peer_alert obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/peer_alert;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_endpoint;
#pragma warning disable 0169
		static Delegate GetGet_endpointHandler ()
		{
			if (cb_get_endpoint == null)
				cb_get_endpoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_endpoint);
			return cb_get_endpoint;
		}

		static IntPtr n_Get_endpoint (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_endpoint ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_alert']/method[@name='get_endpoint' and count(parameter)=0]"
		[Register ("get_endpoint", "()Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;", "GetGet_endpointHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Tcp_endpoint Get_endpoint ()
		{
			const string __id = "get_endpoint.()Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Tcp_endpoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
