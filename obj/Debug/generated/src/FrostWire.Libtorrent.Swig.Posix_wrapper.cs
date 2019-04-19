using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_wrapper']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/posix_wrapper", DoNotGenerateAcw=true)]
	public partial class Posix_wrapper : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_wrapper']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/posix_wrapper", typeof (Posix_wrapper));
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

		protected Posix_wrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_wrapper']/constructor[@name='posix_wrapper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Posix_wrapper ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_wrapper']/constructor[@name='posix_wrapper' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Posix_wrapper (long cPtr, bool cMemoryOwn)
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
			global::FrostWire.Libtorrent.Swig.Posix_wrapper __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Posix_wrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_wrapper']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_wrapper']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.posix_wrapper']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/posix_wrapper;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Posix_wrapper obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/posix_wrapper;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_mkdir_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetMkdir_Ljava_lang_String_IHandler ()
		{
			if (cb_mkdir_Ljava_lang_String_I == null)
				cb_mkdir_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_Mkdir_Ljava_lang_String_I);
			return cb_mkdir_Ljava_lang_String_I;
		}

		static int n_Mkdir_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_path, int mode)
		{
			global::FrostWire.Libtorrent.Swig.Posix_wrapper __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Posix_wrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Mkdir (path, mode);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_wrapper']/method[@name='mkdir' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("mkdir", "(Ljava/lang/String;I)I", "GetMkdir_Ljava_lang_String_IHandler")]
		public virtual unsafe int Mkdir (string path, int mode)
		{
			const string __id = "mkdir.(Ljava/lang/String;I)I";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (mode);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_open_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetOpen_Ljava_lang_String_IIHandler ()
		{
			if (cb_open_Ljava_lang_String_II == null)
				cb_open_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int>) n_Open_Ljava_lang_String_II);
			return cb_open_Ljava_lang_String_II;
		}

		static int n_Open_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_path, int flags, int mode)
		{
			global::FrostWire.Libtorrent.Swig.Posix_wrapper __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Posix_wrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Open (path, flags, mode);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_wrapper']/method[@name='open' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("open", "(Ljava/lang/String;II)I", "GetOpen_Ljava_lang_String_IIHandler")]
		public virtual unsafe int Open (string path, int flags, int mode)
		{
			const string __id = "open.(Ljava/lang/String;II)I";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (flags);
				__args [2] = new JniArgumentValue (mode);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_remove_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Handler ()
		{
			if (cb_remove_Ljava_lang_String_ == null)
				cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Remove_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_;
		}

		static int n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			global::FrostWire.Libtorrent.Swig.Posix_wrapper __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Posix_wrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Remove (path);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_wrapper']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)I", "GetRemove_Ljava_lang_String_Handler")]
		public virtual unsafe int Remove (string path)
		{
			const string __id = "remove.(Ljava/lang/String;)I";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_rename_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRename_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_rename_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_rename_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Rename_Ljava_lang_String_Ljava_lang_String_);
			return cb_rename_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_Rename_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_oldpath, IntPtr native_newpath)
		{
			global::FrostWire.Libtorrent.Swig.Posix_wrapper __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Posix_wrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string oldpath = JNIEnv.GetString (native_oldpath, JniHandleOwnership.DoNotTransfer);
			string newpath = JNIEnv.GetString (native_newpath, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Rename (oldpath, newpath);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_wrapper']/method[@name='rename' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("rename", "(Ljava/lang/String;Ljava/lang/String;)I", "GetRename_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int Rename (string oldpath, string newpath)
		{
			const string __id = "rename.(Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_oldpath = JNIEnv.NewString (oldpath);
			IntPtr native_newpath = JNIEnv.NewString (newpath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_oldpath);
				__args [1] = new JniArgumentValue (native_newpath);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_oldpath);
				JNIEnv.DeleteLocalRef (native_newpath);
			}
		}

		static Delegate cb_stat_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_posix_stat_t_;
#pragma warning disable 0169
		static Delegate GetStat_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_posix_stat_t_Handler ()
		{
			if (cb_stat_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_posix_stat_t_ == null)
				cb_stat_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_posix_stat_t_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Stat_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_posix_stat_t_);
			return cb_stat_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_posix_stat_t_;
		}

		static int n_Stat_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_posix_stat_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path, IntPtr native_buf)
		{
			global::FrostWire.Libtorrent.Swig.Posix_wrapper __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Posix_wrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Posix_stat_t buf = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Posix_stat_t> (native_buf, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Stat (path, buf);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_wrapper']/method[@name='stat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.posix_stat_t']]"
		[Register ("stat", "(Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/posix_stat_t;)I", "GetStat_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_posix_stat_t_Handler")]
		public virtual unsafe int Stat (string path, global::FrostWire.Libtorrent.Swig.Posix_stat_t buf)
		{
			const string __id = "stat.(Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/posix_stat_t;)I";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue ((buf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buf).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_swigDirectorDisconnect;
#pragma warning disable 0169
		static Delegate GetSwigDirectorDisconnectHandler ()
		{
			if (cb_swigDirectorDisconnect == null)
				cb_swigDirectorDisconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SwigDirectorDisconnect);
			return cb_swigDirectorDisconnect;
		}

		static void n_SwigDirectorDisconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Posix_wrapper __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Posix_wrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwigDirectorDisconnect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_wrapper']/method[@name='swigDirectorDisconnect' and count(parameter)=0]"
		[Register ("swigDirectorDisconnect", "()V", "GetSwigDirectorDisconnectHandler")]
		protected virtual unsafe void SwigDirectorDisconnect ()
		{
			const string __id = "swigDirectorDisconnect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_swigReleaseOwnership;
#pragma warning disable 0169
		static Delegate GetSwigReleaseOwnershipHandler ()
		{
			if (cb_swigReleaseOwnership == null)
				cb_swigReleaseOwnership = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SwigReleaseOwnership);
			return cb_swigReleaseOwnership;
		}

		static void n_SwigReleaseOwnership (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Posix_wrapper __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Posix_wrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwigReleaseOwnership ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_wrapper']/method[@name='swigReleaseOwnership' and count(parameter)=0]"
		[Register ("swigReleaseOwnership", "()V", "GetSwigReleaseOwnershipHandler")]
		public virtual unsafe void SwigReleaseOwnership ()
		{
			const string __id = "swigReleaseOwnership.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_swigTakeOwnership;
#pragma warning disable 0169
		static Delegate GetSwigTakeOwnershipHandler ()
		{
			if (cb_swigTakeOwnership == null)
				cb_swigTakeOwnership = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SwigTakeOwnership);
			return cb_swigTakeOwnership;
		}

		static void n_SwigTakeOwnership (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Posix_wrapper __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Posix_wrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwigTakeOwnership ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_wrapper']/method[@name='swigTakeOwnership' and count(parameter)=0]"
		[Register ("swigTakeOwnership", "()V", "GetSwigTakeOwnershipHandler")]
		public virtual unsafe void SwigTakeOwnership ()
		{
			const string __id = "swigTakeOwnership.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
