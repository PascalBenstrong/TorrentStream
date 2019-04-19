using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_state']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/dht_state", DoNotGenerateAcw=true)]
	public partial class Dht_state : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_state']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/dht_state", typeof (Dht_state));
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

		protected Dht_state (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_state']/constructor[@name='dht_state' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Dht_state ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_state']/constructor[@name='dht_state' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Dht_state (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getNids;
#pragma warning disable 0169
		static Delegate GetGetNidsHandler ()
		{
			if (cb_getNids == null)
				cb_getNids = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNids);
			return cb_getNids;
		}

		static IntPtr n_GetNids (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_state __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_state> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Nids);
		}
#pragma warning restore 0169

		static Delegate cb_setNids_Lcom_frostwire_jlibtorrent_swig_address_sha1_hash_pair_vector_;
#pragma warning disable 0169
		static Delegate GetSetNids_Lcom_frostwire_jlibtorrent_swig_address_sha1_hash_pair_vector_Handler ()
		{
			if (cb_setNids_Lcom_frostwire_jlibtorrent_swig_address_sha1_hash_pair_vector_ == null)
				cb_setNids_Lcom_frostwire_jlibtorrent_swig_address_sha1_hash_pair_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNids_Lcom_frostwire_jlibtorrent_swig_address_sha1_hash_pair_vector_);
			return cb_setNids_Lcom_frostwire_jlibtorrent_swig_address_sha1_hash_pair_vector_;
		}

		static void n_SetNids_Lcom_frostwire_jlibtorrent_swig_address_sha1_hash_pair_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_state __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_state> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Address_sha1_hash_pair_vector value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address_sha1_hash_pair_vector> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Nids = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Address_sha1_hash_pair_vector Nids {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_state']/method[@name='getNids' and count(parameter)=0]"
			[Register ("getNids", "()Lcom/frostwire/jlibtorrent/swig/address_sha1_hash_pair_vector;", "GetGetNidsHandler")]
			get {
				const string __id = "getNids.()Lcom/frostwire/jlibtorrent/swig/address_sha1_hash_pair_vector;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address_sha1_hash_pair_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_state']/method[@name='setNids' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.address_sha1_hash_pair_vector']]"
			[Register ("setNids", "(Lcom/frostwire/jlibtorrent/swig/address_sha1_hash_pair_vector;)V", "GetSetNids_Lcom_frostwire_jlibtorrent_swig_address_sha1_hash_pair_vector_Handler")]
			set {
				const string __id = "setNids.(Lcom/frostwire/jlibtorrent/swig/address_sha1_hash_pair_vector;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNodes;
#pragma warning disable 0169
		static Delegate GetGetNodesHandler ()
		{
			if (cb_getNodes == null)
				cb_getNodes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNodes);
			return cb_getNodes;
		}

		static IntPtr n_GetNodes (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_state __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_state> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Nodes);
		}
#pragma warning restore 0169

		static Delegate cb_setNodes_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_vector_;
#pragma warning disable 0169
		static Delegate GetSetNodes_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_vector_Handler ()
		{
			if (cb_setNodes_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_vector_ == null)
				cb_setNodes_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNodes_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_vector_);
			return cb_setNodes_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_vector_;
		}

		static void n_SetNodes_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_state __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_state> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Udp_endpoint_vector value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Udp_endpoint_vector> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Nodes = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Udp_endpoint_vector Nodes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_state']/method[@name='getNodes' and count(parameter)=0]"
			[Register ("getNodes", "()Lcom/frostwire/jlibtorrent/swig/udp_endpoint_vector;", "GetGetNodesHandler")]
			get {
				const string __id = "getNodes.()Lcom/frostwire/jlibtorrent/swig/udp_endpoint_vector;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Udp_endpoint_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_state']/method[@name='setNodes' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.udp_endpoint_vector']]"
			[Register ("setNodes", "(Lcom/frostwire/jlibtorrent/swig/udp_endpoint_vector;)V", "GetSetNodes_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_vector_Handler")]
			set {
				const string __id = "setNodes.(Lcom/frostwire/jlibtorrent/swig/udp_endpoint_vector;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNodes6;
#pragma warning disable 0169
		static Delegate GetGetNodes6Handler ()
		{
			if (cb_getNodes6 == null)
				cb_getNodes6 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNodes6);
			return cb_getNodes6;
		}

		static IntPtr n_GetNodes6 (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_state __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_state> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Nodes6);
		}
#pragma warning restore 0169

		static Delegate cb_setNodes6_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_vector_;
#pragma warning disable 0169
		static Delegate GetSetNodes6_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_vector_Handler ()
		{
			if (cb_setNodes6_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_vector_ == null)
				cb_setNodes6_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNodes6_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_vector_);
			return cb_setNodes6_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_vector_;
		}

		static void n_SetNodes6_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_state __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_state> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Udp_endpoint_vector value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Udp_endpoint_vector> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Nodes6 = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Udp_endpoint_vector Nodes6 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_state']/method[@name='getNodes6' and count(parameter)=0]"
			[Register ("getNodes6", "()Lcom/frostwire/jlibtorrent/swig/udp_endpoint_vector;", "GetGetNodes6Handler")]
			get {
				const string __id = "getNodes6.()Lcom/frostwire/jlibtorrent/swig/udp_endpoint_vector;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Udp_endpoint_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_state']/method[@name='setNodes6' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.udp_endpoint_vector']]"
			[Register ("setNodes6", "(Lcom/frostwire/jlibtorrent/swig/udp_endpoint_vector;)V", "GetSetNodes6_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_vector_Handler")]
			set {
				const string __id = "setNodes6.(Lcom/frostwire/jlibtorrent/swig/udp_endpoint_vector;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_state __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_state> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_state']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
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
			global::FrostWire.Libtorrent.Swig.Dht_state __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_state> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_state']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_state']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.dht_state']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/dht_state;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Dht_state obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/dht_state;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
