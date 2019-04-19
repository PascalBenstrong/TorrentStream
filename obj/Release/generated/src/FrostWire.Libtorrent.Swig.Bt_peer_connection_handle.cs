using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bt_peer_connection_handle']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/bt_peer_connection_handle", DoNotGenerateAcw=true)]
	public partial class Bt_peer_connection_handle : global::FrostWire.Libtorrent.Swig.Peer_connection_handle {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/bt_peer_connection_handle", typeof (Bt_peer_connection_handle));
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

		protected Bt_peer_connection_handle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bt_peer_connection_handle']/constructor[@name='bt_peer_connection_handle' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.peer_connection_handle']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/peer_connection_handle;)V", "")]
		public unsafe Bt_peer_connection_handle (global::FrostWire.Libtorrent.Swig.Peer_connection_handle pc)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/peer_connection_handle;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pc).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bt_peer_connection_handle']/constructor[@name='bt_peer_connection_handle' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Bt_peer_connection_handle (long cPtr, bool cMemoryOwn)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bt_peer_connection_handle']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.bt_peer_connection_handle']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/bt_peer_connection_handle;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Bt_peer_connection_handle obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/bt_peer_connection_handle;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_packet_finished;
#pragma warning disable 0169
		static Delegate GetPacket_finishedHandler ()
		{
			if (cb_packet_finished == null)
				cb_packet_finished = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Packet_finished);
			return cb_packet_finished;
		}

		static bool n_Packet_finished (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Bt_peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bt_peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Packet_finished ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bt_peer_connection_handle']/method[@name='packet_finished' and count(parameter)=0]"
		[Register ("packet_finished", "()Z", "GetPacket_finishedHandler")]
		public virtual unsafe bool Packet_finished ()
		{
			const string __id = "packet_finished.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_support_extensions;
#pragma warning disable 0169
		static Delegate GetSupport_extensionsHandler ()
		{
			if (cb_support_extensions == null)
				cb_support_extensions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Support_extensions);
			return cb_support_extensions;
		}

		static bool n_Support_extensions (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Bt_peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bt_peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Support_extensions ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bt_peer_connection_handle']/method[@name='support_extensions' and count(parameter)=0]"
		[Register ("support_extensions", "()Z", "GetSupport_extensionsHandler")]
		public virtual unsafe bool Support_extensions ()
		{
			const string __id = "support_extensions.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_supports_encryption;
#pragma warning disable 0169
		static Delegate GetSupports_encryptionHandler ()
		{
			if (cb_supports_encryption == null)
				cb_supports_encryption = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Supports_encryption);
			return cb_supports_encryption;
		}

		static bool n_Supports_encryption (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Bt_peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bt_peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Supports_encryption ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bt_peer_connection_handle']/method[@name='supports_encryption' and count(parameter)=0]"
		[Register ("supports_encryption", "()Z", "GetSupports_encryptionHandler")]
		public virtual unsafe bool Supports_encryption ()
		{
			const string __id = "supports_encryption.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
