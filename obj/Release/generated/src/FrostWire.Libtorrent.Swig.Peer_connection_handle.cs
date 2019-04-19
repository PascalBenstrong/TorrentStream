using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/peer_connection_handle", DoNotGenerateAcw=true)]
	public partial class Peer_connection_handle : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/field[@name='swigCMemOwn']"
		[Register ("swigCMemOwn")]
		protected bool SwigCMemOwn {
			get {
				const string __id = "swigCMemOwn.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "swigCMemOwn.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/peer_connection_handle", typeof (Peer_connection_handle));
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

		protected Peer_connection_handle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/constructor[@name='peer_connection_handle' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Peer_connection_handle (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_associated_torrent;
#pragma warning disable 0169
		static Delegate GetAssociated_torrentHandler ()
		{
			if (cb_associated_torrent == null)
				cb_associated_torrent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Associated_torrent);
			return cb_associated_torrent;
		}

		static IntPtr n_Associated_torrent (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Associated_torrent ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='associated_torrent' and count(parameter)=0]"
		[Register ("associated_torrent", "()Lcom/frostwire/jlibtorrent/swig/torrent_handle;", "GetAssociated_torrentHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Torrent_handle Associated_torrent ()
		{
			const string __id = "associated_torrent.()Lcom/frostwire/jlibtorrent/swig/torrent_handle;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_can_disconnect_Lcom_frostwire_jlibtorrent_swig_error_code_;
#pragma warning disable 0169
		static Delegate GetCan_disconnect_Lcom_frostwire_jlibtorrent_swig_error_code_Handler ()
		{
			if (cb_can_disconnect_Lcom_frostwire_jlibtorrent_swig_error_code_ == null)
				cb_can_disconnect_Lcom_frostwire_jlibtorrent_swig_error_code_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Can_disconnect_Lcom_frostwire_jlibtorrent_swig_error_code_);
			return cb_can_disconnect_Lcom_frostwire_jlibtorrent_swig_error_code_;
		}

		static bool n_Can_disconnect_Lcom_frostwire_jlibtorrent_swig_error_code_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ec)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Error_code ec = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Error_code> (native_ec, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Can_disconnect (ec);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='can_disconnect' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.error_code']]"
		[Register ("can_disconnect", "(Lcom/frostwire/jlibtorrent/swig/error_code;)Z", "GetCan_disconnect_Lcom_frostwire_jlibtorrent_swig_error_code_Handler")]
		public virtual unsafe bool Can_disconnect (global::FrostWire.Libtorrent.Swig.Error_code ec)
		{
			const string __id = "can_disconnect.(Lcom/frostwire/jlibtorrent/swig/error_code;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ec).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_choke_this_peer;
#pragma warning disable 0169
		static Delegate GetChoke_this_peerHandler ()
		{
			if (cb_choke_this_peer == null)
				cb_choke_this_peer = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Choke_this_peer);
			return cb_choke_this_peer;
		}

		static void n_Choke_this_peer (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Choke_this_peer ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='choke_this_peer' and count(parameter)=0]"
		[Register ("choke_this_peer", "()V", "GetChoke_this_peerHandler")]
		public virtual unsafe void Choke_this_peer ()
		{
			const string __id = "choke_this_peer.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_delete;
#pragma warning disable 0169
		static Delegate GetDeleteHandler ()
		{
			if (cb_delete == null)
				cb_delete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Delete);
			return cb_delete;
		}

		static void n_Delete (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_disconnect_Lcom_frostwire_jlibtorrent_swig_error_code_Lcom_frostwire_jlibtorrent_swig_operation_t_;
#pragma warning disable 0169
		static Delegate GetDisconnect_Lcom_frostwire_jlibtorrent_swig_error_code_Lcom_frostwire_jlibtorrent_swig_operation_t_Handler ()
		{
			if (cb_disconnect_Lcom_frostwire_jlibtorrent_swig_error_code_Lcom_frostwire_jlibtorrent_swig_operation_t_ == null)
				cb_disconnect_Lcom_frostwire_jlibtorrent_swig_error_code_Lcom_frostwire_jlibtorrent_swig_operation_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Disconnect_Lcom_frostwire_jlibtorrent_swig_error_code_Lcom_frostwire_jlibtorrent_swig_operation_t_);
			return cb_disconnect_Lcom_frostwire_jlibtorrent_swig_error_code_Lcom_frostwire_jlibtorrent_swig_operation_t_;
		}

		static void n_Disconnect_Lcom_frostwire_jlibtorrent_swig_error_code_Lcom_frostwire_jlibtorrent_swig_operation_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ec, IntPtr native_op)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Error_code ec = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Error_code> (native_ec, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Operation_t op = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Operation_t> (native_op, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect (ec, op);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='disconnect' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.error_code'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.operation_t']]"
		[Register ("disconnect", "(Lcom/frostwire/jlibtorrent/swig/error_code;Lcom/frostwire/jlibtorrent/swig/operation_t;)V", "GetDisconnect_Lcom_frostwire_jlibtorrent_swig_error_code_Lcom_frostwire_jlibtorrent_swig_operation_t_Handler")]
		public virtual unsafe void Disconnect (global::FrostWire.Libtorrent.Swig.Error_code ec, global::FrostWire.Libtorrent.Swig.Operation_t op)
		{
			const string __id = "disconnect.(Lcom/frostwire/jlibtorrent/swig/error_code;Lcom/frostwire/jlibtorrent/swig/operation_t;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((ec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ec).Handle);
				__args [1] = new JniArgumentValue ((op == null) ? IntPtr.Zero : ((global::Java.Lang.Object) op).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_disconnect_Lcom_frostwire_jlibtorrent_swig_error_code_Lcom_frostwire_jlibtorrent_swig_operation_t_I;
#pragma warning disable 0169
		static Delegate GetDisconnect_Lcom_frostwire_jlibtorrent_swig_error_code_Lcom_frostwire_jlibtorrent_swig_operation_t_IHandler ()
		{
			if (cb_disconnect_Lcom_frostwire_jlibtorrent_swig_error_code_Lcom_frostwire_jlibtorrent_swig_operation_t_I == null)
				cb_disconnect_Lcom_frostwire_jlibtorrent_swig_error_code_Lcom_frostwire_jlibtorrent_swig_operation_t_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Disconnect_Lcom_frostwire_jlibtorrent_swig_error_code_Lcom_frostwire_jlibtorrent_swig_operation_t_I);
			return cb_disconnect_Lcom_frostwire_jlibtorrent_swig_error_code_Lcom_frostwire_jlibtorrent_swig_operation_t_I;
		}

		static void n_Disconnect_Lcom_frostwire_jlibtorrent_swig_error_code_Lcom_frostwire_jlibtorrent_swig_operation_t_I (IntPtr jnienv, IntPtr native__this, IntPtr native_ec, IntPtr native_op, int arg2)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Error_code ec = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Error_code> (native_ec, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Operation_t op = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Operation_t> (native_op, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect (ec, op, arg2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='disconnect' and count(parameter)=3 and parameter[1][@type='com.frostwire.jlibtorrent.swig.error_code'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.operation_t'] and parameter[3][@type='int']]"
		[Register ("disconnect", "(Lcom/frostwire/jlibtorrent/swig/error_code;Lcom/frostwire/jlibtorrent/swig/operation_t;I)V", "GetDisconnect_Lcom_frostwire_jlibtorrent_swig_error_code_Lcom_frostwire_jlibtorrent_swig_operation_t_IHandler")]
		public virtual unsafe void Disconnect (global::FrostWire.Libtorrent.Swig.Error_code ec, global::FrostWire.Libtorrent.Swig.Operation_t op, int arg2)
		{
			const string __id = "disconnect.(Lcom/frostwire/jlibtorrent/swig/error_code;Lcom/frostwire/jlibtorrent/swig/operation_t;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((ec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ec).Handle);
				__args [1] = new JniArgumentValue ((op == null) ? IntPtr.Zero : ((global::Java.Lang.Object) op).Handle);
				__args [2] = new JniArgumentValue (arg2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_failed;
#pragma warning disable 0169
		static Delegate GetFailedHandler ()
		{
			if (cb_failed == null)
				cb_failed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Failed);
			return cb_failed;
		}

		static bool n_Failed (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Failed ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='failed' and count(parameter)=0]"
		[Register ("failed", "()Z", "GetFailedHandler")]
		public virtual unsafe bool Failed ()
		{
			const string __id = "failed.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.peer_connection_handle']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/peer_connection_handle;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Peer_connection_handle obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/peer_connection_handle;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_peer_info_Lcom_frostwire_jlibtorrent_swig_peer_info_;
#pragma warning disable 0169
		static Delegate GetGet_peer_info_Lcom_frostwire_jlibtorrent_swig_peer_info_Handler ()
		{
			if (cb_get_peer_info_Lcom_frostwire_jlibtorrent_swig_peer_info_ == null)
				cb_get_peer_info_Lcom_frostwire_jlibtorrent_swig_peer_info_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Get_peer_info_Lcom_frostwire_jlibtorrent_swig_peer_info_);
			return cb_get_peer_info_Lcom_frostwire_jlibtorrent_swig_peer_info_;
		}

		static void n_Get_peer_info_Lcom_frostwire_jlibtorrent_swig_peer_info_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Peer_info p = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (native_p, JniHandleOwnership.DoNotTransfer);
			__this.Get_peer_info (p);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='get_peer_info' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.peer_info']]"
		[Register ("get_peer_info", "(Lcom/frostwire/jlibtorrent/swig/peer_info;)V", "GetGet_peer_info_Lcom_frostwire_jlibtorrent_swig_peer_info_Handler")]
		public virtual unsafe void Get_peer_info (global::FrostWire.Libtorrent.Swig.Peer_info p)
		{
			const string __id = "get_peer_info.(Lcom/frostwire/jlibtorrent/swig/peer_info;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_get_time_of_last_unchoke;
#pragma warning disable 0169
		static Delegate GetGet_time_of_last_unchokeHandler ()
		{
			if (cb_get_time_of_last_unchoke == null)
				cb_get_time_of_last_unchoke = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Get_time_of_last_unchoke);
			return cb_get_time_of_last_unchoke;
		}

		static long n_Get_time_of_last_unchoke (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_time_of_last_unchoke ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='get_time_of_last_unchoke' and count(parameter)=0]"
		[Register ("get_time_of_last_unchoke", "()J", "GetGet_time_of_last_unchokeHandler")]
		public virtual unsafe long Get_time_of_last_unchoke ()
		{
			const string __id = "get_time_of_last_unchoke.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_has_metadata;
#pragma warning disable 0169
		static Delegate GetHas_metadataHandler ()
		{
			if (cb_has_metadata == null)
				cb_has_metadata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Has_metadata);
			return cb_has_metadata;
		}

		static bool n_Has_metadata (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Has_metadata ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='has_metadata' and count(parameter)=0]"
		[Register ("has_metadata", "()Z", "GetHas_metadataHandler")]
		public virtual unsafe bool Has_metadata ()
		{
			const string __id = "has_metadata.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_has_peer_choked;
#pragma warning disable 0169
		static Delegate GetHas_peer_chokedHandler ()
		{
			if (cb_has_peer_choked == null)
				cb_has_peer_choked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Has_peer_choked);
			return cb_has_peer_choked;
		}

		static bool n_Has_peer_choked (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Has_peer_choked ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='has_peer_choked' and count(parameter)=0]"
		[Register ("has_peer_choked", "()Z", "GetHas_peer_chokedHandler")]
		public virtual unsafe bool Has_peer_choked ()
		{
			const string __id = "has_peer_choked.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_has_piece_I;
#pragma warning disable 0169
		static Delegate GetHas_piece_IHandler ()
		{
			if (cb_has_piece_I == null)
				cb_has_piece_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_Has_piece_I);
			return cb_has_piece_I;
		}

		static bool n_Has_piece_I (IntPtr jnienv, IntPtr native__this, int i)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Has_piece (i);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='has_piece' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("has_piece", "(I)Z", "GetHas_piece_IHandler")]
		public virtual unsafe bool Has_piece (int i)
		{
			const string __id = "has_piece.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_ignore_unchoke_slots;
#pragma warning disable 0169
		static Delegate GetIgnore_unchoke_slotsHandler ()
		{
			if (cb_ignore_unchoke_slots == null)
				cb_ignore_unchoke_slots = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Ignore_unchoke_slots);
			return cb_ignore_unchoke_slots;
		}

		static bool n_Ignore_unchoke_slots (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Ignore_unchoke_slots ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='ignore_unchoke_slots' and count(parameter)=0]"
		[Register ("ignore_unchoke_slots", "()Z", "GetIgnore_unchoke_slotsHandler")]
		public virtual unsafe bool Ignore_unchoke_slots ()
		{
			const string __id = "ignore_unchoke_slots.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_in_handshake;
#pragma warning disable 0169
		static Delegate GetIn_handshakeHandler ()
		{
			if (cb_in_handshake == null)
				cb_in_handshake = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_In_handshake);
			return cb_in_handshake;
		}

		static bool n_In_handshake (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.In_handshake ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='in_handshake' and count(parameter)=0]"
		[Register ("in_handshake", "()Z", "GetIn_handshakeHandler")]
		public virtual unsafe bool In_handshake ()
		{
			const string __id = "in_handshake.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_is_choked;
#pragma warning disable 0169
		static Delegate GetIs_chokedHandler ()
		{
			if (cb_is_choked == null)
				cb_is_choked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Is_choked);
			return cb_is_choked;
		}

		static bool n_Is_choked (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_choked ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='is_choked' and count(parameter)=0]"
		[Register ("is_choked", "()Z", "GetIs_chokedHandler")]
		public virtual unsafe bool Is_choked ()
		{
			const string __id = "is_choked.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_is_connecting;
#pragma warning disable 0169
		static Delegate GetIs_connectingHandler ()
		{
			if (cb_is_connecting == null)
				cb_is_connecting = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Is_connecting);
			return cb_is_connecting;
		}

		static bool n_Is_connecting (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_connecting ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='is_connecting' and count(parameter)=0]"
		[Register ("is_connecting", "()Z", "GetIs_connectingHandler")]
		public virtual unsafe bool Is_connecting ()
		{
			const string __id = "is_connecting.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_is_disconnecting;
#pragma warning disable 0169
		static Delegate GetIs_disconnectingHandler ()
		{
			if (cb_is_disconnecting == null)
				cb_is_disconnecting = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Is_disconnecting);
			return cb_is_disconnecting;
		}

		static bool n_Is_disconnecting (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_disconnecting ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='is_disconnecting' and count(parameter)=0]"
		[Register ("is_disconnecting", "()Z", "GetIs_disconnectingHandler")]
		public virtual unsafe bool Is_disconnecting ()
		{
			const string __id = "is_disconnecting.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_is_interesting;
#pragma warning disable 0169
		static Delegate GetIs_interestingHandler ()
		{
			if (cb_is_interesting == null)
				cb_is_interesting = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Is_interesting);
			return cb_is_interesting;
		}

		static bool n_Is_interesting (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_interesting ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='is_interesting' and count(parameter)=0]"
		[Register ("is_interesting", "()Z", "GetIs_interestingHandler")]
		public virtual unsafe bool Is_interesting ()
		{
			const string __id = "is_interesting.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_is_outgoing;
#pragma warning disable 0169
		static Delegate GetIs_outgoingHandler ()
		{
			if (cb_is_outgoing == null)
				cb_is_outgoing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Is_outgoing);
			return cb_is_outgoing;
		}

		static bool n_Is_outgoing (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_outgoing ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='is_outgoing' and count(parameter)=0]"
		[Register ("is_outgoing", "()Z", "GetIs_outgoingHandler")]
		public virtual unsafe bool Is_outgoing ()
		{
			const string __id = "is_outgoing.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_is_peer_interested;
#pragma warning disable 0169
		static Delegate GetIs_peer_interestedHandler ()
		{
			if (cb_is_peer_interested == null)
				cb_is_peer_interested = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Is_peer_interested);
			return cb_is_peer_interested;
		}

		static bool n_Is_peer_interested (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_peer_interested ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='is_peer_interested' and count(parameter)=0]"
		[Register ("is_peer_interested", "()Z", "GetIs_peer_interestedHandler")]
		public virtual unsafe bool Is_peer_interested ()
		{
			const string __id = "is_peer_interested.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_is_seed;
#pragma warning disable 0169
		static Delegate GetIs_seedHandler ()
		{
			if (cb_is_seed == null)
				cb_is_seed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Is_seed);
			return cb_is_seed;
		}

		static bool n_Is_seed (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_seed ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='is_seed' and count(parameter)=0]"
		[Register ("is_seed", "()Z", "GetIs_seedHandler")]
		public virtual unsafe bool Is_seed ()
		{
			const string __id = "is_seed.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_last_seen_complete;
#pragma warning disable 0169
		static Delegate GetLast_seen_completeHandler ()
		{
			if (cb_last_seen_complete == null)
				cb_last_seen_complete = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Last_seen_complete);
			return cb_last_seen_complete;
		}

		static long n_Last_seen_complete (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Last_seen_complete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='last_seen_complete' and count(parameter)=0]"
		[Register ("last_seen_complete", "()J", "GetLast_seen_completeHandler")]
		public virtual unsafe long Last_seen_complete ()
		{
			const string __id = "last_seen_complete.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_local_endpoint;
#pragma warning disable 0169
		static Delegate GetLocal_endpointHandler ()
		{
			if (cb_local_endpoint == null)
				cb_local_endpoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Local_endpoint);
			return cb_local_endpoint;
		}

		static IntPtr n_Local_endpoint (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Local_endpoint ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='local_endpoint' and count(parameter)=0]"
		[Register ("local_endpoint", "()Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;", "GetLocal_endpointHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Tcp_endpoint Local_endpoint ()
		{
			const string __id = "local_endpoint.()Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Tcp_endpoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_maybe_unchoke_this_peer;
#pragma warning disable 0169
		static Delegate GetMaybe_unchoke_this_peerHandler ()
		{
			if (cb_maybe_unchoke_this_peer == null)
				cb_maybe_unchoke_this_peer = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Maybe_unchoke_this_peer);
			return cb_maybe_unchoke_this_peer;
		}

		static void n_Maybe_unchoke_this_peer (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Maybe_unchoke_this_peer ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='maybe_unchoke_this_peer' and count(parameter)=0]"
		[Register ("maybe_unchoke_this_peer", "()V", "GetMaybe_unchoke_this_peerHandler")]
		public virtual unsafe void Maybe_unchoke_this_peer ()
		{
			const string __id = "maybe_unchoke_this_peer.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_on_local_network;
#pragma warning disable 0169
		static Delegate GetOn_local_networkHandler ()
		{
			if (cb_on_local_network == null)
				cb_on_local_network = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_On_local_network);
			return cb_on_local_network;
		}

		static bool n_On_local_network (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.On_local_network ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='on_local_network' and count(parameter)=0]"
		[Register ("on_local_network", "()Z", "GetOn_local_networkHandler")]
		public virtual unsafe bool On_local_network ()
		{
			const string __id = "on_local_network.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_op_eq_Lcom_frostwire_jlibtorrent_swig_peer_connection_handle_;
#pragma warning disable 0169
		static Delegate GetOp_eq_Lcom_frostwire_jlibtorrent_swig_peer_connection_handle_Handler ()
		{
			if (cb_op_eq_Lcom_frostwire_jlibtorrent_swig_peer_connection_handle_ == null)
				cb_op_eq_Lcom_frostwire_jlibtorrent_swig_peer_connection_handle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Op_eq_Lcom_frostwire_jlibtorrent_swig_peer_connection_handle_);
			return cb_op_eq_Lcom_frostwire_jlibtorrent_swig_peer_connection_handle_;
		}

		static bool n_Op_eq_Lcom_frostwire_jlibtorrent_swig_peer_connection_handle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle o = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (native_o, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Op_eq (o);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='op_eq' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.peer_connection_handle']]"
		[Register ("op_eq", "(Lcom/frostwire/jlibtorrent/swig/peer_connection_handle;)Z", "GetOp_eq_Lcom_frostwire_jlibtorrent_swig_peer_connection_handle_Handler")]
		public virtual unsafe bool Op_eq (global::FrostWire.Libtorrent.Swig.Peer_connection_handle o)
		{
			const string __id = "op_eq.(Lcom/frostwire/jlibtorrent/swig/peer_connection_handle;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_op_lt_Lcom_frostwire_jlibtorrent_swig_peer_connection_handle_;
#pragma warning disable 0169
		static Delegate GetOp_lt_Lcom_frostwire_jlibtorrent_swig_peer_connection_handle_Handler ()
		{
			if (cb_op_lt_Lcom_frostwire_jlibtorrent_swig_peer_connection_handle_ == null)
				cb_op_lt_Lcom_frostwire_jlibtorrent_swig_peer_connection_handle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Op_lt_Lcom_frostwire_jlibtorrent_swig_peer_connection_handle_);
			return cb_op_lt_Lcom_frostwire_jlibtorrent_swig_peer_connection_handle_;
		}

		static bool n_Op_lt_Lcom_frostwire_jlibtorrent_swig_peer_connection_handle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle o = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (native_o, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Op_lt (o);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='op_lt' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.peer_connection_handle']]"
		[Register ("op_lt", "(Lcom/frostwire/jlibtorrent/swig/peer_connection_handle;)Z", "GetOp_lt_Lcom_frostwire_jlibtorrent_swig_peer_connection_handle_Handler")]
		public virtual unsafe bool Op_lt (global::FrostWire.Libtorrent.Swig.Peer_connection_handle o)
		{
			const string __id = "op_lt.(Lcom/frostwire/jlibtorrent/swig/peer_connection_handle;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_op_ne_Lcom_frostwire_jlibtorrent_swig_peer_connection_handle_;
#pragma warning disable 0169
		static Delegate GetOp_ne_Lcom_frostwire_jlibtorrent_swig_peer_connection_handle_Handler ()
		{
			if (cb_op_ne_Lcom_frostwire_jlibtorrent_swig_peer_connection_handle_ == null)
				cb_op_ne_Lcom_frostwire_jlibtorrent_swig_peer_connection_handle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Op_ne_Lcom_frostwire_jlibtorrent_swig_peer_connection_handle_);
			return cb_op_ne_Lcom_frostwire_jlibtorrent_swig_peer_connection_handle_;
		}

		static bool n_Op_ne_Lcom_frostwire_jlibtorrent_swig_peer_connection_handle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle o = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (native_o, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Op_ne (o);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='op_ne' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.peer_connection_handle']]"
		[Register ("op_ne", "(Lcom/frostwire/jlibtorrent/swig/peer_connection_handle;)Z", "GetOp_ne_Lcom_frostwire_jlibtorrent_swig_peer_connection_handle_Handler")]
		public virtual unsafe bool Op_ne (global::FrostWire.Libtorrent.Swig.Peer_connection_handle o)
		{
			const string __id = "op_ne.(Lcom/frostwire/jlibtorrent/swig/peer_connection_handle;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_pid;
#pragma warning disable 0169
		static Delegate GetPidHandler ()
		{
			if (cb_pid == null)
				cb_pid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Pid);
			return cb_pid;
		}

		static IntPtr n_Pid (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Pid ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='pid' and count(parameter)=0]"
		[Register ("pid", "()Lcom/frostwire/jlibtorrent/swig/sha1_hash;", "GetPidHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Sha1_hash Pid ()
		{
			const string __id = "pid.()Lcom/frostwire/jlibtorrent/swig/sha1_hash;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_remote;
#pragma warning disable 0169
		static Delegate GetRemoteHandler ()
		{
			if (cb_remote == null)
				cb_remote = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Remote);
			return cb_remote;
		}

		static IntPtr n_Remote (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Remote ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='remote' and count(parameter)=0]"
		[Register ("remote", "()Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;", "GetRemoteHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Tcp_endpoint Remote ()
		{
			const string __id = "remote.()Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Tcp_endpoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_send_buffer_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSend_buffer_Ljava_lang_String_IHandler ()
		{
			if (cb_send_buffer_Ljava_lang_String_I == null)
				cb_send_buffer_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Send_buffer_Ljava_lang_String_I);
			return cb_send_buffer_Ljava_lang_String_I;
		}

		static void n_Send_buffer_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_begin, int size)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string begin = JNIEnv.GetString (native_begin, JniHandleOwnership.DoNotTransfer);
			__this.Send_buffer (begin, size);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='send_buffer' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("send_buffer", "(Ljava/lang/String;I)V", "GetSend_buffer_Ljava_lang_String_IHandler")]
		public virtual unsafe void Send_buffer (string begin, int size)
		{
			const string __id = "send_buffer.(Ljava/lang/String;I)V";
			IntPtr native_begin = JNIEnv.NewString (begin);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_begin);
				__args [1] = new JniArgumentValue (size);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_begin);
			}
		}

		static Delegate cb_send_buffer_Ljava_lang_String_IJ;
#pragma warning disable 0169
		static Delegate GetSend_buffer_Ljava_lang_String_IJHandler ()
		{
			if (cb_send_buffer_Ljava_lang_String_IJ == null)
				cb_send_buffer_Ljava_lang_String_IJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, long>) n_Send_buffer_Ljava_lang_String_IJ);
			return cb_send_buffer_Ljava_lang_String_IJ;
		}

		static void n_Send_buffer_Ljava_lang_String_IJ (IntPtr jnienv, IntPtr native__this, IntPtr native_begin, int size, long flags)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string begin = JNIEnv.GetString (native_begin, JniHandleOwnership.DoNotTransfer);
			__this.Send_buffer (begin, size, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='send_buffer' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("send_buffer", "(Ljava/lang/String;IJ)V", "GetSend_buffer_Ljava_lang_String_IJHandler")]
		public virtual unsafe void Send_buffer (string begin, int size, long flags)
		{
			const string __id = "send_buffer.(Ljava/lang/String;IJ)V";
			IntPtr native_begin = JNIEnv.NewString (begin);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_begin);
				__args [1] = new JniArgumentValue (size);
				__args [2] = new JniArgumentValue (flags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_begin);
			}
		}

		static Delegate cb_type;
#pragma warning disable 0169
		static Delegate GetTypeHandler ()
		{
			if (cb_type == null)
				cb_type = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Type);
			return cb_type;
		}

		static IntPtr n_Type (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='type' and count(parameter)=0]"
		[Register ("type", "()Lcom/frostwire/jlibtorrent/swig/connection_type;", "GetTypeHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Connection_type Type ()
		{
			const string __id = "type.()Lcom/frostwire/jlibtorrent/swig/connection_type;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Connection_type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_upload_only;
#pragma warning disable 0169
		static Delegate GetUpload_onlyHandler ()
		{
			if (cb_upload_only == null)
				cb_upload_only = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Upload_only);
			return cb_upload_only;
		}

		static bool n_Upload_only (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connection_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connection_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Upload_only ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connection_handle']/method[@name='upload_only' and count(parameter)=0]"
		[Register ("upload_only", "()Z", "GetUpload_onlyHandler")]
		public virtual unsafe bool Upload_only ()
		{
			const string __id = "upload_only.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
