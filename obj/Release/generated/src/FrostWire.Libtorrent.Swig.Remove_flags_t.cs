using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='remove_flags_t']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/remove_flags_t", DoNotGenerateAcw=true)]
	public partial class Remove_flags_t : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='remove_flags_t']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/remove_flags_t", typeof (Remove_flags_t));
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

		protected Remove_flags_t (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='remove_flags_t']/constructor[@name='remove_flags_t' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Remove_flags_t ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='remove_flags_t']/constructor[@name='remove_flags_t' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Remove_flags_t (long cPtr, bool cMemoryOwn)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='remove_flags_t']/method[@name='all' and count(parameter)=0]"
		[Register ("all", "()Lcom/frostwire/jlibtorrent/swig/remove_flags_t;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Remove_flags_t All ()
		{
			const string __id = "all.()Lcom/frostwire/jlibtorrent/swig/remove_flags_t;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Remove_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_and__Lcom_frostwire_jlibtorrent_swig_remove_flags_t_;
#pragma warning disable 0169
		static Delegate GetAnd__Lcom_frostwire_jlibtorrent_swig_remove_flags_t_Handler ()
		{
			if (cb_and__Lcom_frostwire_jlibtorrent_swig_remove_flags_t_ == null)
				cb_and__Lcom_frostwire_jlibtorrent_swig_remove_flags_t_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_And__Lcom_frostwire_jlibtorrent_swig_remove_flags_t_);
			return cb_and__Lcom_frostwire_jlibtorrent_swig_remove_flags_t_;
		}

		static IntPtr n_And__Lcom_frostwire_jlibtorrent_swig_remove_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			global::FrostWire.Libtorrent.Swig.Remove_flags_t __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Remove_flags_t> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Remove_flags_t other = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Remove_flags_t> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.And_ (other));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='remove_flags_t']/method[@name='and_' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.remove_flags_t']]"
		[Register ("and_", "(Lcom/frostwire/jlibtorrent/swig/remove_flags_t;)Lcom/frostwire/jlibtorrent/swig/remove_flags_t;", "GetAnd__Lcom_frostwire_jlibtorrent_swig_remove_flags_t_Handler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Remove_flags_t And_ (global::FrostWire.Libtorrent.Swig.Remove_flags_t other)
		{
			const string __id = "and_.(Lcom/frostwire/jlibtorrent/swig/remove_flags_t;)Lcom/frostwire/jlibtorrent/swig/remove_flags_t;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Remove_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::FrostWire.Libtorrent.Swig.Remove_flags_t __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Remove_flags_t> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='remove_flags_t']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_eq_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_;
#pragma warning disable 0169
		static Delegate GetEq_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_Handler ()
		{
			if (cb_eq_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_ == null)
				cb_eq_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Eq_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_);
			return cb_eq_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_;
		}

		static bool n_Eq_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_f)
		{
			global::FrostWire.Libtorrent.Swig.Remove_flags_t __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Remove_flags_t> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Remove_flags_t f = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Remove_flags_t> (native_f, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Eq (f);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='remove_flags_t']/method[@name='eq' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.remove_flags_t']]"
		[Register ("eq", "(Lcom/frostwire/jlibtorrent/swig/remove_flags_t;)Z", "GetEq_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_Handler")]
		public virtual unsafe bool Eq (global::FrostWire.Libtorrent.Swig.Remove_flags_t f)
		{
			const string __id = "eq.(Lcom/frostwire/jlibtorrent/swig/remove_flags_t;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='remove_flags_t']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.remove_flags_t']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/remove_flags_t;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Remove_flags_t obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/remove_flags_t;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_inv;
#pragma warning disable 0169
		static Delegate GetInvHandler ()
		{
			if (cb_inv == null)
				cb_inv = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Inv);
			return cb_inv;
		}

		static IntPtr n_Inv (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Remove_flags_t __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Remove_flags_t> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Inv ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='remove_flags_t']/method[@name='inv' and count(parameter)=0]"
		[Register ("inv", "()Lcom/frostwire/jlibtorrent/swig/remove_flags_t;", "GetInvHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Remove_flags_t Inv ()
		{
			const string __id = "inv.()Lcom/frostwire/jlibtorrent/swig/remove_flags_t;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Remove_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_ne_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_;
#pragma warning disable 0169
		static Delegate GetNe_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_Handler ()
		{
			if (cb_ne_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_ == null)
				cb_ne_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Ne_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_);
			return cb_ne_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_;
		}

		static bool n_Ne_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_f)
		{
			global::FrostWire.Libtorrent.Swig.Remove_flags_t __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Remove_flags_t> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Remove_flags_t f = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Remove_flags_t> (native_f, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Ne (f);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='remove_flags_t']/method[@name='ne' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.remove_flags_t']]"
		[Register ("ne", "(Lcom/frostwire/jlibtorrent/swig/remove_flags_t;)Z", "GetNe_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_Handler")]
		public virtual unsafe bool Ne (global::FrostWire.Libtorrent.Swig.Remove_flags_t f)
		{
			const string __id = "ne.(Lcom/frostwire/jlibtorrent/swig/remove_flags_t;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_nonZero;
#pragma warning disable 0169
		static Delegate GetNonZeroHandler ()
		{
			if (cb_nonZero == null)
				cb_nonZero = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_NonZero);
			return cb_nonZero;
		}

		static bool n_NonZero (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Remove_flags_t __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Remove_flags_t> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NonZero ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='remove_flags_t']/method[@name='nonZero' and count(parameter)=0]"
		[Register ("nonZero", "()Z", "GetNonZeroHandler")]
		public virtual unsafe bool NonZero ()
		{
			const string __id = "nonZero.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_or__Lcom_frostwire_jlibtorrent_swig_remove_flags_t_;
#pragma warning disable 0169
		static Delegate GetOr__Lcom_frostwire_jlibtorrent_swig_remove_flags_t_Handler ()
		{
			if (cb_or__Lcom_frostwire_jlibtorrent_swig_remove_flags_t_ == null)
				cb_or__Lcom_frostwire_jlibtorrent_swig_remove_flags_t_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Or__Lcom_frostwire_jlibtorrent_swig_remove_flags_t_);
			return cb_or__Lcom_frostwire_jlibtorrent_swig_remove_flags_t_;
		}

		static IntPtr n_Or__Lcom_frostwire_jlibtorrent_swig_remove_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			global::FrostWire.Libtorrent.Swig.Remove_flags_t __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Remove_flags_t> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Remove_flags_t other = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Remove_flags_t> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Or_ (other));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='remove_flags_t']/method[@name='or_' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.remove_flags_t']]"
		[Register ("or_", "(Lcom/frostwire/jlibtorrent/swig/remove_flags_t;)Lcom/frostwire/jlibtorrent/swig/remove_flags_t;", "GetOr__Lcom_frostwire_jlibtorrent_swig_remove_flags_t_Handler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Remove_flags_t Or_ (global::FrostWire.Libtorrent.Swig.Remove_flags_t other)
		{
			const string __id = "or_.(Lcom/frostwire/jlibtorrent/swig/remove_flags_t;)Lcom/frostwire/jlibtorrent/swig/remove_flags_t;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Remove_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_to_int;
#pragma warning disable 0169
		static Delegate GetTo_intHandler ()
		{
			if (cb_to_int == null)
				cb_to_int = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_To_int);
			return cb_to_int;
		}

		static int n_To_int (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Remove_flags_t __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Remove_flags_t> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.To_int ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='remove_flags_t']/method[@name='to_int' and count(parameter)=0]"
		[Register ("to_int", "()I", "GetTo_intHandler")]
		public virtual unsafe int To_int ()
		{
			const string __id = "to_int.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_xor_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_;
#pragma warning disable 0169
		static Delegate GetXor_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_Handler ()
		{
			if (cb_xor_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_ == null)
				cb_xor_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Xor_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_);
			return cb_xor_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_;
		}

		static IntPtr n_Xor_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			global::FrostWire.Libtorrent.Swig.Remove_flags_t __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Remove_flags_t> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Remove_flags_t other = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Remove_flags_t> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Xor (other));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='remove_flags_t']/method[@name='xor' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.remove_flags_t']]"
		[Register ("xor", "(Lcom/frostwire/jlibtorrent/swig/remove_flags_t;)Lcom/frostwire/jlibtorrent/swig/remove_flags_t;", "GetXor_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_Handler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Remove_flags_t Xor (global::FrostWire.Libtorrent.Swig.Remove_flags_t other)
		{
			const string __id = "xor.(Lcom/frostwire/jlibtorrent/swig/remove_flags_t;)Lcom/frostwire/jlibtorrent/swig/remove_flags_t;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Remove_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
