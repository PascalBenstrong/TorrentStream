using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bloom_filter_256']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/bloom_filter_256", DoNotGenerateAcw=true)]
	public partial class Bloom_filter_256 : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bloom_filter_256']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/bloom_filter_256", typeof (Bloom_filter_256));
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

		protected Bloom_filter_256 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bloom_filter_256']/constructor[@name='bloom_filter_256' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Bloom_filter_256 ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bloom_filter_256']/constructor[@name='bloom_filter_256' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Bloom_filter_256 (long cPtr, bool cMemoryOwn)
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
			global::FrostWire.Libtorrent.Swig.Bloom_filter_256 __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bloom_filter_256> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bloom_filter_256']/method[@name='clear' and count(parameter)=0]"
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
			global::FrostWire.Libtorrent.Swig.Bloom_filter_256 __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bloom_filter_256> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bloom_filter_256']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_find_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
#pragma warning disable 0169
		static Delegate GetFind_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler ()
		{
			if (cb_find_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ == null)
				cb_find_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Find_Lcom_frostwire_jlibtorrent_swig_sha1_hash_);
			return cb_find_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
		}

		static bool n_Find_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ (IntPtr jnienv, IntPtr native__this, IntPtr native_k)
		{
			global::FrostWire.Libtorrent.Swig.Bloom_filter_256 __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bloom_filter_256> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Sha1_hash k = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (native_k, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Find (k);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bloom_filter_256']/method[@name='find' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.sha1_hash']]"
		[Register ("find", "(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)Z", "GetFind_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler")]
		public virtual unsafe bool Find (global::FrostWire.Libtorrent.Swig.Sha1_hash k)
		{
			const string __id = "find.(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((k == null) ? IntPtr.Zero : ((global::Java.Lang.Object) k).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_from_bytes_Lcom_frostwire_jlibtorrent_swig_byte_vector_;
#pragma warning disable 0169
		static Delegate GetFrom_bytes_Lcom_frostwire_jlibtorrent_swig_byte_vector_Handler ()
		{
			if (cb_from_bytes_Lcom_frostwire_jlibtorrent_swig_byte_vector_ == null)
				cb_from_bytes_Lcom_frostwire_jlibtorrent_swig_byte_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_From_bytes_Lcom_frostwire_jlibtorrent_swig_byte_vector_);
			return cb_from_bytes_Lcom_frostwire_jlibtorrent_swig_byte_vector_;
		}

		static void n_From_bytes_Lcom_frostwire_jlibtorrent_swig_byte_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_v)
		{
			global::FrostWire.Libtorrent.Swig.Bloom_filter_256 __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bloom_filter_256> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Byte_vector v = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (native_v, JniHandleOwnership.DoNotTransfer);
			__this.From_bytes (v);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bloom_filter_256']/method[@name='from_bytes' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
		[Register ("from_bytes", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;)V", "GetFrom_bytes_Lcom_frostwire_jlibtorrent_swig_byte_vector_Handler")]
		public virtual unsafe void From_bytes (global::FrostWire.Libtorrent.Swig.Byte_vector v)
		{
			const string __id = "from_bytes.(Lcom/frostwire/jlibtorrent/swig/byte_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bloom_filter_256']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.bloom_filter_256']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/bloom_filter_256;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Bloom_filter_256 obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/bloom_filter_256;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_set_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
#pragma warning disable 0169
		static Delegate GetSet_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler ()
		{
			if (cb_set_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ == null)
				cb_set_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_Lcom_frostwire_jlibtorrent_swig_sha1_hash_);
			return cb_set_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
		}

		static void n_Set_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ (IntPtr jnienv, IntPtr native__this, IntPtr native_k)
		{
			global::FrostWire.Libtorrent.Swig.Bloom_filter_256 __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bloom_filter_256> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Sha1_hash k = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (native_k, JniHandleOwnership.DoNotTransfer);
			__this.Set (k);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bloom_filter_256']/method[@name='set' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.sha1_hash']]"
		[Register ("set", "(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V", "GetSet_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler")]
		public virtual unsafe void Set (global::FrostWire.Libtorrent.Swig.Sha1_hash k)
		{
			const string __id = "set.(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((k == null) ? IntPtr.Zero : ((global::Java.Lang.Object) k).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_Size);
			return cb_size;
		}

		static float n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Bloom_filter_256 __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bloom_filter_256> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bloom_filter_256']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()F", "GetSizeHandler")]
		public virtual unsafe float Size ()
		{
			const string __id = "size.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
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
			global::FrostWire.Libtorrent.Swig.Bloom_filter_256 __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bloom_filter_256> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.To_bytes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bloom_filter_256']/method[@name='to_bytes' and count(parameter)=0]"
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

	}
}
