using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_index_string_map']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/file_index_string_map", DoNotGenerateAcw=true)]
	public partial class File_index_string_map : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_index_string_map']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/file_index_string_map", typeof (File_index_string_map));
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

		protected File_index_string_map (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_index_string_map']/constructor[@name='file_index_string_map' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe File_index_string_map ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_index_string_map']/constructor[@name='file_index_string_map' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.file_index_string_map']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/file_index_string_map;)V", "")]
		public unsafe File_index_string_map (global::FrostWire.Libtorrent.Swig.File_index_string_map arg0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/file_index_string_map;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((arg0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_index_string_map']/constructor[@name='file_index_string_map' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe File_index_string_map (long cPtr, bool cMemoryOwn)
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
			global::FrostWire.Libtorrent.Swig.File_index_string_map __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_index_string_map> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_index_string_map']/method[@name='clear' and count(parameter)=0]"
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
			global::FrostWire.Libtorrent.Swig.File_index_string_map __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_index_string_map> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_index_string_map']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_empty;
#pragma warning disable 0169
		static Delegate GetEmptyHandler ()
		{
			if (cb_empty == null)
				cb_empty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Empty);
			return cb_empty;
		}

		static bool n_Empty (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.File_index_string_map __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_index_string_map> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Empty ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_index_string_map']/method[@name='empty' and count(parameter)=0]"
		[Register ("empty", "()Z", "GetEmptyHandler")]
		public virtual unsafe bool Empty ()
		{
			const string __id = "empty.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_erase_I;
#pragma warning disable 0169
		static Delegate GetErase_IHandler ()
		{
			if (cb_erase_I == null)
				cb_erase_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Erase_I);
			return cb_erase_I;
		}

		static void n_Erase_I (IntPtr jnienv, IntPtr native__this, int key)
		{
			global::FrostWire.Libtorrent.Swig.File_index_string_map __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_index_string_map> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Erase (key);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_index_string_map']/method[@name='erase' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("erase", "(I)V", "GetErase_IHandler")]
		public virtual unsafe void Erase (int key)
		{
			const string __id = "erase.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (key);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_get_I;
#pragma warning disable 0169
		static Delegate GetGet_IHandler ()
		{
			if (cb_get_I == null)
				cb_get_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Get_I);
			return cb_get_I;
		}

		static IntPtr n_Get_I (IntPtr jnienv, IntPtr native__this, int key)
		{
			global::FrostWire.Libtorrent.Swig.File_index_string_map __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_index_string_map> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Get (key));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_index_string_map']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Ljava/lang/String;", "GetGet_IHandler")]
		public virtual unsafe string Get (int key)
		{
			const string __id = "get.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (key);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_index_string_map']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.file_index_string_map']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/file_index_string_map;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.File_index_string_map obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/file_index_string_map;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_has_key_I;
#pragma warning disable 0169
		static Delegate GetHas_key_IHandler ()
		{
			if (cb_has_key_I == null)
				cb_has_key_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_Has_key_I);
			return cb_has_key_I;
		}

		static bool n_Has_key_I (IntPtr jnienv, IntPtr native__this, int key)
		{
			global::FrostWire.Libtorrent.Swig.File_index_string_map __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_index_string_map> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Has_key (key);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_index_string_map']/method[@name='has_key' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("has_key", "(I)Z", "GetHas_key_IHandler")]
		public virtual unsafe bool Has_key (int key)
		{
			const string __id = "has_key.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (key);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_keys;
#pragma warning disable 0169
		static Delegate GetKeysHandler ()
		{
			if (cb_keys == null)
				cb_keys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Keys);
			return cb_keys;
		}

		static IntPtr n_Keys (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.File_index_string_map __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_index_string_map> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Keys ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_index_string_map']/method[@name='keys' and count(parameter)=0]"
		[Register ("keys", "()Lcom/frostwire/jlibtorrent/swig/file_index_vector;", "GetKeysHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.File_index_vector Keys ()
		{
			const string __id = "keys.()Lcom/frostwire/jlibtorrent/swig/file_index_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_index_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_set_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSet_ILjava_lang_String_Handler ()
		{
			if (cb_set_ILjava_lang_String_ == null)
				cb_set_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Set_ILjava_lang_String_);
			return cb_set_ILjava_lang_String_;
		}

		static void n_Set_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int key, IntPtr native_x)
		{
			global::FrostWire.Libtorrent.Swig.File_index_string_map __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_index_string_map> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string x = JNIEnv.GetString (native_x, JniHandleOwnership.DoNotTransfer);
			__this.Set (key, x);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_index_string_map']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("set", "(ILjava/lang/String;)V", "GetSet_ILjava_lang_String_Handler")]
		public virtual unsafe void Set (int key, string x)
		{
			const string __id = "set.(ILjava/lang/String;)V";
			IntPtr native_x = JNIEnv.NewString (x);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (key);
				__args [1] = new JniArgumentValue (native_x);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_x);
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Size);
			return cb_size;
		}

		static long n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.File_index_string_map __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_index_string_map> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_index_string_map']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()J", "GetSizeHandler")]
		public virtual unsafe long Size ()
		{
			const string __id = "size.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
