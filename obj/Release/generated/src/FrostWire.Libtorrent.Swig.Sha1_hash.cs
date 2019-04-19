using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='sha1_hash']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/sha1_hash", DoNotGenerateAcw=true)]
	public partial class Sha1_hash : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='sha1_hash']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/sha1_hash", typeof (Sha1_hash));
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

		protected Sha1_hash (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='sha1_hash']/constructor[@name='sha1_hash' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Sha1_hash ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='sha1_hash']/constructor[@name='sha1_hash' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;)V", "")]
		public unsafe Sha1_hash (global::FrostWire.Libtorrent.Swig.Byte_vector s)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/byte_vector;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((s == null) ? IntPtr.Zero : ((global::Java.Lang.Object) s).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='sha1_hash']/constructor[@name='sha1_hash' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.sha1_hash']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V", "")]
		public unsafe Sha1_hash (global::FrostWire.Libtorrent.Swig.Sha1_hash other)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V";

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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='sha1_hash']/constructor[@name='sha1_hash' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Sha1_hash (long cPtr, bool cMemoryOwn)
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
			global::FrostWire.Libtorrent.Swig.Sha1_hash __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='sha1_hash']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='sha1_hash']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.sha1_hash'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.sha1_hash']]"
		[Register ("compare", "(Lcom/frostwire/jlibtorrent/swig/sha1_hash;Lcom/frostwire/jlibtorrent/swig/sha1_hash;)I", "")]
		public static unsafe int Compare (global::FrostWire.Libtorrent.Swig.Sha1_hash h1, global::FrostWire.Libtorrent.Swig.Sha1_hash h2)
		{
			const string __id = "compare.(Lcom/frostwire/jlibtorrent/swig/sha1_hash;Lcom/frostwire/jlibtorrent/swig/sha1_hash;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((h1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) h1).Handle);
				__args [1] = new JniArgumentValue ((h2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) h2).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_count_leading_zeroes;
#pragma warning disable 0169
		static Delegate GetCount_leading_zeroesHandler ()
		{
			if (cb_count_leading_zeroes == null)
				cb_count_leading_zeroes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Count_leading_zeroes);
			return cb_count_leading_zeroes;
		}

		static int n_Count_leading_zeroes (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Sha1_hash __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count_leading_zeroes ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='sha1_hash']/method[@name='count_leading_zeroes' and count(parameter)=0]"
		[Register ("count_leading_zeroes", "()I", "GetCount_leading_zeroesHandler")]
		public virtual unsafe int Count_leading_zeroes ()
		{
			const string __id = "count_leading_zeroes.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
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
			global::FrostWire.Libtorrent.Swig.Sha1_hash __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='sha1_hash']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='sha1_hash']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.sha1_hash']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Sha1_hash obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_hash_code;
#pragma warning disable 0169
		static Delegate GetHash_codeHandler ()
		{
			if (cb_hash_code == null)
				cb_hash_code = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Hash_code);
			return cb_hash_code;
		}

		static int n_Hash_code (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Sha1_hash __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Hash_code ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='sha1_hash']/method[@name='hash_code' and count(parameter)=0]"
		[Register ("hash_code", "()I", "GetHash_codeHandler")]
		public virtual unsafe int Hash_code ()
		{
			const string __id = "hash_code.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_is_all_zeros;
#pragma warning disable 0169
		static Delegate GetIs_all_zerosHandler ()
		{
			if (cb_is_all_zeros == null)
				cb_is_all_zeros = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Is_all_zeros);
			return cb_is_all_zeros;
		}

		static bool n_Is_all_zeros (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Sha1_hash __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_all_zeros ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='sha1_hash']/method[@name='is_all_zeros' and count(parameter)=0]"
		[Register ("is_all_zeros", "()Z", "GetIs_all_zerosHandler")]
		public virtual unsafe bool Is_all_zeros ()
		{
			const string __id = "is_all_zeros.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='sha1_hash']/method[@name='max' and count(parameter)=0]"
		[Register ("max", "()Lcom/frostwire/jlibtorrent/swig/sha1_hash;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Sha1_hash Max ()
		{
			const string __id = "max.()Lcom/frostwire/jlibtorrent/swig/sha1_hash;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='sha1_hash']/method[@name='min' and count(parameter)=0]"
		[Register ("min", "()Lcom/frostwire/jlibtorrent/swig/sha1_hash;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Sha1_hash Min ()
		{
			const string __id = "min.()Lcom/frostwire/jlibtorrent/swig/sha1_hash;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_op_eq_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
#pragma warning disable 0169
		static Delegate GetOp_eq_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler ()
		{
			if (cb_op_eq_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ == null)
				cb_op_eq_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Op_eq_Lcom_frostwire_jlibtorrent_swig_sha1_hash_);
			return cb_op_eq_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
		}

		static bool n_Op_eq_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ (IntPtr jnienv, IntPtr native__this, IntPtr native_n)
		{
			global::FrostWire.Libtorrent.Swig.Sha1_hash __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Sha1_hash n = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (native_n, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Op_eq (n);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='sha1_hash']/method[@name='op_eq' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.sha1_hash']]"
		[Register ("op_eq", "(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)Z", "GetOp_eq_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler")]
		public virtual unsafe bool Op_eq (global::FrostWire.Libtorrent.Swig.Sha1_hash n)
		{
			const string __id = "op_eq.(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((n == null) ? IntPtr.Zero : ((global::Java.Lang.Object) n).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_op_lt_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
#pragma warning disable 0169
		static Delegate GetOp_lt_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler ()
		{
			if (cb_op_lt_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ == null)
				cb_op_lt_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Op_lt_Lcom_frostwire_jlibtorrent_swig_sha1_hash_);
			return cb_op_lt_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
		}

		static bool n_Op_lt_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ (IntPtr jnienv, IntPtr native__this, IntPtr native_n)
		{
			global::FrostWire.Libtorrent.Swig.Sha1_hash __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Sha1_hash n = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (native_n, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Op_lt (n);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='sha1_hash']/method[@name='op_lt' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.sha1_hash']]"
		[Register ("op_lt", "(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)Z", "GetOp_lt_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler")]
		public virtual unsafe bool Op_lt (global::FrostWire.Libtorrent.Swig.Sha1_hash n)
		{
			const string __id = "op_lt.(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((n == null) ? IntPtr.Zero : ((global::Java.Lang.Object) n).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_op_ne_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
#pragma warning disable 0169
		static Delegate GetOp_ne_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler ()
		{
			if (cb_op_ne_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ == null)
				cb_op_ne_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Op_ne_Lcom_frostwire_jlibtorrent_swig_sha1_hash_);
			return cb_op_ne_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
		}

		static bool n_Op_ne_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ (IntPtr jnienv, IntPtr native__this, IntPtr native_n)
		{
			global::FrostWire.Libtorrent.Swig.Sha1_hash __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Sha1_hash n = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (native_n, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Op_ne (n);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='sha1_hash']/method[@name='op_ne' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.sha1_hash']]"
		[Register ("op_ne", "(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)Z", "GetOp_ne_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler")]
		public virtual unsafe bool Op_ne (global::FrostWire.Libtorrent.Swig.Sha1_hash n)
		{
			const string __id = "op_ne.(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((n == null) ? IntPtr.Zero : ((global::Java.Lang.Object) n).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='sha1_hash']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()J", "")]
		public static unsafe long Size ()
		{
			const string __id = "size.()J";
			try {
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_to_bytes;
#pragma warning disable 0169
		static Delegate GetTo_bytesHandler ()
		{
			if (cb_to_bytes == null)
				cb_to_bytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_To_bytes);
			return cb_to_bytes;
		}

		static IntPtr n_To_bytes (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Sha1_hash __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.To_bytes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='sha1_hash']/method[@name='to_bytes' and count(parameter)=0]"
		[Register ("to_bytes", "()Lcom/frostwire/jlibtorrent/swig/byte_vector;", "GetTo_bytesHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Byte_vector To_bytes ()
		{
			const string __id = "to_bytes.()Lcom/frostwire/jlibtorrent/swig/byte_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_to_hex;
#pragma warning disable 0169
		static Delegate GetTo_hexHandler ()
		{
			if (cb_to_hex == null)
				cb_to_hex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_To_hex);
			return cb_to_hex;
		}

		static IntPtr n_To_hex (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Sha1_hash __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.To_hex ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='sha1_hash']/method[@name='to_hex' and count(parameter)=0]"
		[Register ("to_hex", "()Ljava/lang/String;", "GetTo_hexHandler")]
		public virtual unsafe string To_hex ()
		{
			const string __id = "to_hex.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
