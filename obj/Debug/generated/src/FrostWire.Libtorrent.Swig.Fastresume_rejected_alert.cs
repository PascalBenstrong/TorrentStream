using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='fastresume_rejected_alert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/fastresume_rejected_alert", DoNotGenerateAcw=true)]
	public partial class Fastresume_rejected_alert : global::FrostWire.Libtorrent.Swig.Torrent_alert {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='fastresume_rejected_alert']/field[@name='alert_type']"
		[Register ("alert_type")]
		public static int AlertType {
			get {
				const string __id = "alert_type.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='fastresume_rejected_alert']/field[@name='priority']"
		[Register ("priority")]
		public static int Priority {
			get {
				const string __id = "priority.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='fastresume_rejected_alert']/field[@name='static_category']"
		[Register ("static_category")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t StaticCategory {
			get {
				const string __id = "static_category.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/fastresume_rejected_alert", typeof (Fastresume_rejected_alert));
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

		protected Fastresume_rejected_alert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='fastresume_rejected_alert']/constructor[@name='fastresume_rejected_alert' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Fastresume_rejected_alert (long cPtr, bool cMemoryOwn)
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
			global::FrostWire.Libtorrent.Swig.Fastresume_rejected_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Fastresume_rejected_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Error);
		}
#pragma warning restore 0169

		static Delegate cb_setError_Lcom_frostwire_jlibtorrent_swig_error_code_;
#pragma warning disable 0169
		static Delegate GetSetError_Lcom_frostwire_jlibtorrent_swig_error_code_Handler ()
		{
			if (cb_setError_Lcom_frostwire_jlibtorrent_swig_error_code_ == null)
				cb_setError_Lcom_frostwire_jlibtorrent_swig_error_code_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetError_Lcom_frostwire_jlibtorrent_swig_error_code_);
			return cb_setError_Lcom_frostwire_jlibtorrent_swig_error_code_;
		}

		static void n_SetError_Lcom_frostwire_jlibtorrent_swig_error_code_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Fastresume_rejected_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Fastresume_rejected_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Error_code value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Error_code> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Error = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Error_code Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='fastresume_rejected_alert']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()Lcom/frostwire/jlibtorrent/swig/error_code;", "GetGetErrorHandler")]
			get {
				const string __id = "getError.()Lcom/frostwire/jlibtorrent/swig/error_code;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Error_code> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='fastresume_rejected_alert']/method[@name='setError' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.error_code']]"
			[Register ("setError", "(Lcom/frostwire/jlibtorrent/swig/error_code;)V", "GetSetError_Lcom_frostwire_jlibtorrent_swig_error_code_Handler")]
			set {
				const string __id = "setError.(Lcom/frostwire/jlibtorrent/swig/error_code;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::FrostWire.Libtorrent.Swig.Fastresume_rejected_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Fastresume_rejected_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::FrostWire.Libtorrent.Swig.Fastresume_rejected_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Fastresume_rejected_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Operation_t value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Operation_t> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Op = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Operation_t Op {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='fastresume_rejected_alert']/method[@name='getOp' and count(parameter)=0]"
			[Register ("getOp", "()Lcom/frostwire/jlibtorrent/swig/operation_t;", "GetGetOpHandler")]
			get {
				const string __id = "getOp.()Lcom/frostwire/jlibtorrent/swig/operation_t;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Operation_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='fastresume_rejected_alert']/method[@name='setOp' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.operation_t']]"
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

		static Delegate cb_file_path;
#pragma warning disable 0169
		static Delegate GetFile_pathHandler ()
		{
			if (cb_file_path == null)
				cb_file_path = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_File_path);
			return cb_file_path;
		}

		static IntPtr n_File_path (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Fastresume_rejected_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Fastresume_rejected_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.File_path ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='fastresume_rejected_alert']/method[@name='file_path' and count(parameter)=0]"
		[Register ("file_path", "()Ljava/lang/String;", "GetFile_pathHandler")]
		public virtual unsafe string File_path ()
		{
			const string __id = "file_path.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='fastresume_rejected_alert']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.fastresume_rejected_alert']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/fastresume_rejected_alert;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Fastresume_rejected_alert obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/fastresume_rejected_alert;)J";
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
