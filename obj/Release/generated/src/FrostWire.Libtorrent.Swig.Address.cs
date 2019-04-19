using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='address']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/address", DoNotGenerateAcw=true)]
	public partial class Address : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='address']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/address", typeof (Address));
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

		protected Address (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='address']/constructor[@name='address' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Address ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='address']/constructor[@name='address' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.address']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/address;)V", "")]
		public unsafe Address (global::FrostWire.Libtorrent.Swig.Address other)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/address;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='address']/constructor[@name='address' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Address (long cPtr, bool cMemoryOwn)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='address']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.address'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.address']]"
		[Register ("compare", "(Lcom/frostwire/jlibtorrent/swig/address;Lcom/frostwire/jlibtorrent/swig/address;)I", "")]
		public static unsafe int Compare (global::FrostWire.Libtorrent.Swig.Address a1, global::FrostWire.Libtorrent.Swig.Address a2)
		{
			const string __id = "compare.(Lcom/frostwire/jlibtorrent/swig/address;Lcom/frostwire/jlibtorrent/swig/address;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((a1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a1).Handle);
				__args [1] = new JniArgumentValue ((a2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a2).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
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
			global::FrostWire.Libtorrent.Swig.Address __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='address']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='address']/method[@name='from_string' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.error_code']]"
		[Register ("from_string", "(Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/error_code;)Lcom/frostwire/jlibtorrent/swig/address;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Address From_string (string str, global::FrostWire.Libtorrent.Swig.Error_code ec)
		{
			const string __id = "from_string.(Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/error_code;)Lcom/frostwire/jlibtorrent/swig/address;";
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_str);
				__args [1] = new JniArgumentValue ((ec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ec).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='address']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.address']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/address;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Address obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/address;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_is_loopback;
#pragma warning disable 0169
		static Delegate GetIs_loopbackHandler ()
		{
			if (cb_is_loopback == null)
				cb_is_loopback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Is_loopback);
			return cb_is_loopback;
		}

		static bool n_Is_loopback (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Address __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_loopback ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='address']/method[@name='is_loopback' and count(parameter)=0]"
		[Register ("is_loopback", "()Z", "GetIs_loopbackHandler")]
		public virtual unsafe bool Is_loopback ()
		{
			const string __id = "is_loopback.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_is_multicast;
#pragma warning disable 0169
		static Delegate GetIs_multicastHandler ()
		{
			if (cb_is_multicast == null)
				cb_is_multicast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Is_multicast);
			return cb_is_multicast;
		}

		static bool n_Is_multicast (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Address __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_multicast ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='address']/method[@name='is_multicast' and count(parameter)=0]"
		[Register ("is_multicast", "()Z", "GetIs_multicastHandler")]
		public virtual unsafe bool Is_multicast ()
		{
			const string __id = "is_multicast.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_is_unspecified;
#pragma warning disable 0169
		static Delegate GetIs_unspecifiedHandler ()
		{
			if (cb_is_unspecified == null)
				cb_is_unspecified = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Is_unspecified);
			return cb_is_unspecified;
		}

		static bool n_Is_unspecified (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Address __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_unspecified ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='address']/method[@name='is_unspecified' and count(parameter)=0]"
		[Register ("is_unspecified", "()Z", "GetIs_unspecifiedHandler")]
		public virtual unsafe bool Is_unspecified ()
		{
			const string __id = "is_unspecified.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_is_v4;
#pragma warning disable 0169
		static Delegate GetIs_v4Handler ()
		{
			if (cb_is_v4 == null)
				cb_is_v4 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Is_v4);
			return cb_is_v4;
		}

		static bool n_Is_v4 (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Address __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_v4 ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='address']/method[@name='is_v4' and count(parameter)=0]"
		[Register ("is_v4", "()Z", "GetIs_v4Handler")]
		public virtual unsafe bool Is_v4 ()
		{
			const string __id = "is_v4.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_is_v6;
#pragma warning disable 0169
		static Delegate GetIs_v6Handler ()
		{
			if (cb_is_v6 == null)
				cb_is_v6 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Is_v6);
			return cb_is_v6;
		}

		static bool n_Is_v6 (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Address __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_v6 ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='address']/method[@name='is_v6' and count(parameter)=0]"
		[Register ("is_v6", "()Z", "GetIs_v6Handler")]
		public virtual unsafe bool Is_v6 ()
		{
			const string __id = "is_v6.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_op_lt_Lcom_frostwire_jlibtorrent_swig_address_;
#pragma warning disable 0169
		static Delegate GetOp_lt_Lcom_frostwire_jlibtorrent_swig_address_Handler ()
		{
			if (cb_op_lt_Lcom_frostwire_jlibtorrent_swig_address_ == null)
				cb_op_lt_Lcom_frostwire_jlibtorrent_swig_address_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Op_lt_Lcom_frostwire_jlibtorrent_swig_address_);
			return cb_op_lt_Lcom_frostwire_jlibtorrent_swig_address_;
		}

		static bool n_Op_lt_Lcom_frostwire_jlibtorrent_swig_address_ (IntPtr jnienv, IntPtr native__this, IntPtr native_a2)
		{
			global::FrostWire.Libtorrent.Swig.Address __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Address a2 = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address> (native_a2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Op_lt (a2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='address']/method[@name='op_lt' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.address']]"
		[Register ("op_lt", "(Lcom/frostwire/jlibtorrent/swig/address;)Z", "GetOp_lt_Lcom_frostwire_jlibtorrent_swig_address_Handler")]
		public virtual unsafe bool Op_lt (global::FrostWire.Libtorrent.Swig.Address a2)
		{
			const string __id = "op_lt.(Lcom/frostwire/jlibtorrent/swig/address;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a2).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_to_string_Lcom_frostwire_jlibtorrent_swig_error_code_;
#pragma warning disable 0169
		static Delegate GetTo_string_Lcom_frostwire_jlibtorrent_swig_error_code_Handler ()
		{
			if (cb_to_string_Lcom_frostwire_jlibtorrent_swig_error_code_ == null)
				cb_to_string_Lcom_frostwire_jlibtorrent_swig_error_code_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_To_string_Lcom_frostwire_jlibtorrent_swig_error_code_);
			return cb_to_string_Lcom_frostwire_jlibtorrent_swig_error_code_;
		}

		static IntPtr n_To_string_Lcom_frostwire_jlibtorrent_swig_error_code_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ec)
		{
			global::FrostWire.Libtorrent.Swig.Address __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Error_code ec = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Error_code> (native_ec, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.To_string (ec));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='address']/method[@name='to_string' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.error_code']]"
		[Register ("to_string", "(Lcom/frostwire/jlibtorrent/swig/error_code;)Ljava/lang/String;", "GetTo_string_Lcom_frostwire_jlibtorrent_swig_error_code_Handler")]
		public virtual unsafe string To_string (global::FrostWire.Libtorrent.Swig.Error_code ec)
		{
			const string __id = "to_string.(Lcom/frostwire/jlibtorrent/swig/error_code;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ec).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
