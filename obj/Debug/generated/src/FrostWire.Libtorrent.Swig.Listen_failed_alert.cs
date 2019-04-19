using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='listen_failed_alert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/listen_failed_alert", DoNotGenerateAcw=true)]
	public partial class Listen_failed_alert : global::FrostWire.Libtorrent.Swig.Alert {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='listen_failed_alert']/field[@name='alert_type']"
		[Register ("alert_type")]
		public static int AlertType {
			get {
				const string __id = "alert_type.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='listen_failed_alert']/field[@name='priority']"
		[Register ("priority")]
		public static int Priority {
			get {
				const string __id = "priority.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='listen_failed_alert']/field[@name='static_category']"
		[Register ("static_category")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t StaticCategory {
			get {
				const string __id = "static_category.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/listen_failed_alert", typeof (Listen_failed_alert));
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

		protected Listen_failed_alert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='listen_failed_alert']/constructor[@name='listen_failed_alert' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Listen_failed_alert (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getError;
#pragma warning disable 0169
		static Delegate GetGetErrorHandler ()
		{
			if (cb_getError == null)
				cb_getError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetError);
			return cb_getError;
		}

		static IntPtr n_GetError (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Listen_failed_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Listen_failed_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Error);
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Error_code Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='listen_failed_alert']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()Lcom/frostwire/jlibtorrent/swig/error_code;", "GetGetErrorHandler")]
			get {
				const string __id = "getError.()Lcom/frostwire/jlibtorrent/swig/error_code;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Error_code> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOp;
#pragma warning disable 0169
		static Delegate GetGetOpHandler ()
		{
			if (cb_getOp == null)
				cb_getOp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOp);
			return cb_getOp;
		}

		static IntPtr n_GetOp (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Listen_failed_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Listen_failed_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Op);
		}
#pragma warning restore 0169

		static Delegate cb_setOp_Lcom_frostwire_jlibtorrent_swig_operation_t_;
#pragma warning disable 0169
		static Delegate GetSetOp_Lcom_frostwire_jlibtorrent_swig_operation_t_Handler ()
		{
			if (cb_setOp_Lcom_frostwire_jlibtorrent_swig_operation_t_ == null)
				cb_setOp_Lcom_frostwire_jlibtorrent_swig_operation_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOp_Lcom_frostwire_jlibtorrent_swig_operation_t_);
			return cb_setOp_Lcom_frostwire_jlibtorrent_swig_operation_t_;
		}

		static void n_SetOp_Lcom_frostwire_jlibtorrent_swig_operation_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Listen_failed_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Listen_failed_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Operation_t value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Operation_t> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Op = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Operation_t Op {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='listen_failed_alert']/method[@name='getOp' and count(parameter)=0]"
			[Register ("getOp", "()Lcom/frostwire/jlibtorrent/swig/operation_t;", "GetGetOpHandler")]
			get {
				const string __id = "getOp.()Lcom/frostwire/jlibtorrent/swig/operation_t;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Operation_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='listen_failed_alert']/method[@name='setOp' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.operation_t']]"
			[Register ("setOp", "(Lcom/frostwire/jlibtorrent/swig/operation_t;)V", "GetSetOp_Lcom_frostwire_jlibtorrent_swig_operation_t_Handler")]
			set {
				const string __id = "setOp.(Lcom/frostwire/jlibtorrent/swig/operation_t;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPort;
#pragma warning disable 0169
		static Delegate GetGetPortHandler ()
		{
			if (cb_getPort == null)
				cb_getPort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPort);
			return cb_getPort;
		}

		static int n_GetPort (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Listen_failed_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Listen_failed_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Port;
		}
#pragma warning restore 0169

		public virtual unsafe int Port {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='listen_failed_alert']/method[@name='getPort' and count(parameter)=0]"
			[Register ("getPort", "()I", "GetGetPortHandler")]
			get {
				const string __id = "getPort.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSocket_type;
#pragma warning disable 0169
		static Delegate GetGetSocket_typeHandler ()
		{
			if (cb_getSocket_type == null)
				cb_getSocket_type = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSocket_type);
			return cb_getSocket_type;
		}

		static IntPtr n_GetSocket_type (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Listen_failed_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Listen_failed_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Socket_type);
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Socket_type_t Socket_type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='listen_failed_alert']/method[@name='getSocket_type' and count(parameter)=0]"
			[Register ("getSocket_type", "()Lcom/frostwire/jlibtorrent/swig/socket_type_t;", "GetGetSocket_typeHandler")]
			get {
				const string __id = "getSocket_type.()Lcom/frostwire/jlibtorrent/swig/socket_type_t;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Socket_type_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='listen_failed_alert']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.listen_failed_alert']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/listen_failed_alert;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Listen_failed_alert obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/listen_failed_alert;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_address;
#pragma warning disable 0169
		static Delegate GetGet_addressHandler ()
		{
			if (cb_get_address == null)
				cb_get_address = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_address);
			return cb_get_address;
		}

		static IntPtr n_Get_address (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Listen_failed_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Listen_failed_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_address ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='listen_failed_alert']/method[@name='get_address' and count(parameter)=0]"
		[Register ("get_address", "()Lcom/frostwire/jlibtorrent/swig/address;", "GetGet_addressHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Address Get_address ()
		{
			const string __id = "get_address.()Lcom/frostwire/jlibtorrent/swig/address;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_listen_interface;
#pragma warning disable 0169
		static Delegate GetListen_interfaceHandler ()
		{
			if (cb_listen_interface == null)
				cb_listen_interface = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Listen_interface);
			return cb_listen_interface;
		}

		static IntPtr n_Listen_interface (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Listen_failed_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Listen_failed_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Listen_interface ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='listen_failed_alert']/method[@name='listen_interface' and count(parameter)=0]"
		[Register ("listen_interface", "()Ljava/lang/String;", "GetListen_interfaceHandler")]
		public virtual unsafe string Listen_interface ()
		{
			const string __id = "listen_interface.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
