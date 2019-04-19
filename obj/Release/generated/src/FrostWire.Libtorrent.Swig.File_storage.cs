using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/file_storage", DoNotGenerateAcw=true)]
	public partial class File_storage : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/field[@name='flag_executable']"
		[Register ("flag_executable")]
		public static global::FrostWire.Libtorrent.Swig.File_flags_t FlagExecutable {
			get {
				const string __id = "flag_executable.Lcom/frostwire/jlibtorrent/swig/file_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/field[@name='flag_hidden']"
		[Register ("flag_hidden")]
		public static global::FrostWire.Libtorrent.Swig.File_flags_t FlagHidden {
			get {
				const string __id = "flag_hidden.Lcom/frostwire/jlibtorrent/swig/file_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/field[@name='flag_pad_file']"
		[Register ("flag_pad_file")]
		public static global::FrostWire.Libtorrent.Swig.File_flags_t FlagPadFile {
			get {
				const string __id = "flag_pad_file.Lcom/frostwire/jlibtorrent/swig/file_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/field[@name='flag_symlink']"
		[Register ("flag_symlink")]
		public static global::FrostWire.Libtorrent.Swig.File_flags_t FlagSymlink {
			get {
				const string __id = "flag_symlink.Lcom/frostwire/jlibtorrent/swig/file_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/file_storage", typeof (File_storage));
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

		protected File_storage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/constructor[@name='file_storage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe File_storage ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/constructor[@name='file_storage' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.file_storage']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/file_storage;)V", "")]
		public unsafe File_storage (global::FrostWire.Libtorrent.Swig.File_storage arg0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/file_storage;)V";

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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/constructor[@name='file_storage' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe File_storage (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_add_file_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetAdd_file_Ljava_lang_String_JHandler ()
		{
			if (cb_add_file_Ljava_lang_String_J == null)
				cb_add_file_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_Add_file_Ljava_lang_String_J);
			return cb_add_file_Ljava_lang_String_J;
		}

		static void n_Add_file_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_path, long file_size)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			__this.Add_file (path, file_size);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='add_file' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("add_file", "(Ljava/lang/String;J)V", "GetAdd_file_Ljava_lang_String_JHandler")]
		public virtual unsafe void Add_file (string path, long file_size)
		{
			const string __id = "add_file.(Ljava/lang/String;J)V";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (file_size);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_add_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_;
#pragma warning disable 0169
		static Delegate GetAdd_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Handler ()
		{
			if (cb_add_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_ == null)
				cb_add_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_Add_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_);
			return cb_add_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_;
		}

		static void n_Add_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path, long file_size, IntPtr native_file_flags)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.File_flags_t file_flags = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_flags_t> (native_file_flags, JniHandleOwnership.DoNotTransfer);
			__this.Add_file (path, file_size, file_flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='add_file' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='com.frostwire.jlibtorrent.swig.file_flags_t']]"
		[Register ("add_file", "(Ljava/lang/String;JLcom/frostwire/jlibtorrent/swig/file_flags_t;)V", "GetAdd_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Handler")]
		public virtual unsafe void Add_file (string path, long file_size, global::FrostWire.Libtorrent.Swig.File_flags_t file_flags)
		{
			const string __id = "add_file.(Ljava/lang/String;JLcom/frostwire/jlibtorrent/swig/file_flags_t;)V";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (file_size);
				__args [2] = new JniArgumentValue ((file_flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file_flags).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_add_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_J;
#pragma warning disable 0169
		static Delegate GetAdd_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_JHandler ()
		{
			if (cb_add_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_J == null)
				cb_add_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr, long>) n_Add_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_J);
			return cb_add_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_J;
		}

		static void n_Add_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_J (IntPtr jnienv, IntPtr native__this, IntPtr native_path, long file_size, IntPtr native_file_flags, long mtime)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.File_flags_t file_flags = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_flags_t> (native_file_flags, JniHandleOwnership.DoNotTransfer);
			__this.Add_file (path, file_size, file_flags, mtime);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='add_file' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='com.frostwire.jlibtorrent.swig.file_flags_t'] and parameter[4][@type='long']]"
		[Register ("add_file", "(Ljava/lang/String;JLcom/frostwire/jlibtorrent/swig/file_flags_t;J)V", "GetAdd_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_JHandler")]
		public virtual unsafe void Add_file (string path, long file_size, global::FrostWire.Libtorrent.Swig.File_flags_t file_flags, long mtime)
		{
			const string __id = "add_file.(Ljava/lang/String;JLcom/frostwire/jlibtorrent/swig/file_flags_t;J)V";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (file_size);
				__args [2] = new JniArgumentValue ((file_flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file_flags).Handle);
				__args [3] = new JniArgumentValue (mtime);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_add_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_JLcom_frostwire_jlibtorrent_swig_string_view_;
#pragma warning disable 0169
		static Delegate GetAdd_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_JLcom_frostwire_jlibtorrent_swig_string_view_Handler ()
		{
			if (cb_add_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_JLcom_frostwire_jlibtorrent_swig_string_view_ == null)
				cb_add_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_JLcom_frostwire_jlibtorrent_swig_string_view_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr, long, IntPtr>) n_Add_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_JLcom_frostwire_jlibtorrent_swig_string_view_);
			return cb_add_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_JLcom_frostwire_jlibtorrent_swig_string_view_;
		}

		static void n_Add_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_JLcom_frostwire_jlibtorrent_swig_string_view_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path, long file_size, IntPtr native_file_flags, long mtime, IntPtr native_symlink_path)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.File_flags_t file_flags = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_flags_t> (native_file_flags, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.String_view symlink_path = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_view> (native_symlink_path, JniHandleOwnership.DoNotTransfer);
			__this.Add_file (path, file_size, file_flags, mtime, symlink_path);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='add_file' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='com.frostwire.jlibtorrent.swig.file_flags_t'] and parameter[4][@type='long'] and parameter[5][@type='com.frostwire.jlibtorrent.swig.string_view']]"
		[Register ("add_file", "(Ljava/lang/String;JLcom/frostwire/jlibtorrent/swig/file_flags_t;JLcom/frostwire/jlibtorrent/swig/string_view;)V", "GetAdd_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_JLcom_frostwire_jlibtorrent_swig_string_view_Handler")]
		public virtual unsafe void Add_file (string path, long file_size, global::FrostWire.Libtorrent.Swig.File_flags_t file_flags, long mtime, global::FrostWire.Libtorrent.Swig.String_view symlink_path)
		{
			const string __id = "add_file.(Ljava/lang/String;JLcom/frostwire/jlibtorrent/swig/file_flags_t;JLcom/frostwire/jlibtorrent/swig/string_view;)V";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (file_size);
				__args [2] = new JniArgumentValue ((file_flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file_flags).Handle);
				__args [3] = new JniArgumentValue (mtime);
				__args [4] = new JniArgumentValue ((symlink_path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) symlink_path).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_add_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdd_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_JLjava_lang_String_Handler ()
		{
			if (cb_add_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_JLjava_lang_String_ == null)
				cb_add_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr, long, IntPtr>) n_Add_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_JLjava_lang_String_);
			return cb_add_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_JLjava_lang_String_;
		}

		static void n_Add_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path, long file_size, IntPtr native_file_flags, long mtime, IntPtr native_symlink_path)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.File_flags_t file_flags = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_flags_t> (native_file_flags, JniHandleOwnership.DoNotTransfer);
			string symlink_path = JNIEnv.GetString (native_symlink_path, JniHandleOwnership.DoNotTransfer);
			__this.Add_file (path, file_size, file_flags, mtime, symlink_path);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='add_file' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='com.frostwire.jlibtorrent.swig.file_flags_t'] and parameter[4][@type='long'] and parameter[5][@type='java.lang.String']]"
		[Register ("add_file", "(Ljava/lang/String;JLcom/frostwire/jlibtorrent/swig/file_flags_t;JLjava/lang/String;)V", "GetAdd_file_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_JLjava_lang_String_Handler")]
		public virtual unsafe void Add_file (string path, long file_size, global::FrostWire.Libtorrent.Swig.File_flags_t file_flags, long mtime, string symlink_path)
		{
			const string __id = "add_file.(Ljava/lang/String;JLcom/frostwire/jlibtorrent/swig/file_flags_t;JLjava/lang/String;)V";
			IntPtr native_path = JNIEnv.NewString (path);
			IntPtr native_symlink_path = JNIEnv.NewString (symlink_path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (file_size);
				__args [2] = new JniArgumentValue ((file_flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file_flags).Handle);
				__args [3] = new JniArgumentValue (mtime);
				__args [4] = new JniArgumentValue (native_symlink_path);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				JNIEnv.DeleteLocalRef (native_symlink_path);
			}
		}

		static Delegate cb_add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetAdd_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JHandler ()
		{
			if (cb_add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_J == null)
				cb_add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long>) n_Add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_J);
			return cb_add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_J;
		}

		static void n_Add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_filename, IntPtr native_path, long file_size)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.String_view filename = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_view> (native_filename, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			__this.Add_file_borrow (filename, path, file_size);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='add_file_borrow' and count(parameter)=3 and parameter[1][@type='com.frostwire.jlibtorrent.swig.string_view'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("add_file_borrow", "(Lcom/frostwire/jlibtorrent/swig/string_view;Ljava/lang/String;J)V", "GetAdd_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JHandler")]
		public virtual unsafe void Add_file_borrow (global::FrostWire.Libtorrent.Swig.String_view filename, string path, long file_size)
		{
			const string __id = "add_file_borrow.(Lcom/frostwire/jlibtorrent/swig/string_view;Ljava/lang/String;J)V";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((filename == null) ? IntPtr.Zero : ((global::Java.Lang.Object) filename).Handle);
				__args [1] = new JniArgumentValue (native_path);
				__args [2] = new JniArgumentValue (file_size);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_;
#pragma warning disable 0169
		static Delegate GetAdd_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Handler ()
		{
			if (cb_add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_ == null)
				cb_add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr>) n_Add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_);
			return cb_add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_;
		}

		static void n_Add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filename, IntPtr native_path, long file_size, IntPtr native_file_flags)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.String_view filename = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_view> (native_filename, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.File_flags_t file_flags = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_flags_t> (native_file_flags, JniHandleOwnership.DoNotTransfer);
			__this.Add_file_borrow (filename, path, file_size, file_flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='add_file_borrow' and count(parameter)=4 and parameter[1][@type='com.frostwire.jlibtorrent.swig.string_view'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='com.frostwire.jlibtorrent.swig.file_flags_t']]"
		[Register ("add_file_borrow", "(Lcom/frostwire/jlibtorrent/swig/string_view;Ljava/lang/String;JLcom/frostwire/jlibtorrent/swig/file_flags_t;)V", "GetAdd_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Handler")]
		public virtual unsafe void Add_file_borrow (global::FrostWire.Libtorrent.Swig.String_view filename, string path, long file_size, global::FrostWire.Libtorrent.Swig.File_flags_t file_flags)
		{
			const string __id = "add_file_borrow.(Lcom/frostwire/jlibtorrent/swig/string_view;Ljava/lang/String;JLcom/frostwire/jlibtorrent/swig/file_flags_t;)V";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((filename == null) ? IntPtr.Zero : ((global::Java.Lang.Object) filename).Handle);
				__args [1] = new JniArgumentValue (native_path);
				__args [2] = new JniArgumentValue (file_size);
				__args [3] = new JniArgumentValue ((file_flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file_flags).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdd_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Ljava_lang_String_Handler ()
		{
			if (cb_add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Ljava_lang_String_ == null)
				cb_add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr, IntPtr>) n_Add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Ljava_lang_String_);
			return cb_add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Ljava_lang_String_;
		}

		static void n_Add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filename, IntPtr native_path, long file_size, IntPtr native_file_flags, IntPtr native_filehash)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.String_view filename = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_view> (native_filename, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.File_flags_t file_flags = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_flags_t> (native_file_flags, JniHandleOwnership.DoNotTransfer);
			string filehash = JNIEnv.GetString (native_filehash, JniHandleOwnership.DoNotTransfer);
			__this.Add_file_borrow (filename, path, file_size, file_flags, filehash);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='add_file_borrow' and count(parameter)=5 and parameter[1][@type='com.frostwire.jlibtorrent.swig.string_view'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='com.frostwire.jlibtorrent.swig.file_flags_t'] and parameter[5][@type='java.lang.String']]"
		[Register ("add_file_borrow", "(Lcom/frostwire/jlibtorrent/swig/string_view;Ljava/lang/String;JLcom/frostwire/jlibtorrent/swig/file_flags_t;Ljava/lang/String;)V", "GetAdd_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Ljava_lang_String_Handler")]
		public virtual unsafe void Add_file_borrow (global::FrostWire.Libtorrent.Swig.String_view filename, string path, long file_size, global::FrostWire.Libtorrent.Swig.File_flags_t file_flags, string filehash)
		{
			const string __id = "add_file_borrow.(Lcom/frostwire/jlibtorrent/swig/string_view;Ljava/lang/String;JLcom/frostwire/jlibtorrent/swig/file_flags_t;Ljava/lang/String;)V";
			IntPtr native_path = JNIEnv.NewString (path);
			IntPtr native_filehash = JNIEnv.NewString (filehash);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((filename == null) ? IntPtr.Zero : ((global::Java.Lang.Object) filename).Handle);
				__args [1] = new JniArgumentValue (native_path);
				__args [2] = new JniArgumentValue (file_size);
				__args [3] = new JniArgumentValue ((file_flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file_flags).Handle);
				__args [4] = new JniArgumentValue (native_filehash);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				JNIEnv.DeleteLocalRef (native_filehash);
			}
		}

		static Delegate cb_add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetAdd_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Ljava_lang_String_JHandler ()
		{
			if (cb_add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Ljava_lang_String_J == null)
				cb_add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr, IntPtr, long>) n_Add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Ljava_lang_String_J);
			return cb_add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Ljava_lang_String_J;
		}

		static void n_Add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_filename, IntPtr native_path, long file_size, IntPtr native_file_flags, IntPtr native_filehash, long mtime)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.String_view filename = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_view> (native_filename, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.File_flags_t file_flags = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_flags_t> (native_file_flags, JniHandleOwnership.DoNotTransfer);
			string filehash = JNIEnv.GetString (native_filehash, JniHandleOwnership.DoNotTransfer);
			__this.Add_file_borrow (filename, path, file_size, file_flags, filehash, mtime);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='add_file_borrow' and count(parameter)=6 and parameter[1][@type='com.frostwire.jlibtorrent.swig.string_view'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='com.frostwire.jlibtorrent.swig.file_flags_t'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='long']]"
		[Register ("add_file_borrow", "(Lcom/frostwire/jlibtorrent/swig/string_view;Ljava/lang/String;JLcom/frostwire/jlibtorrent/swig/file_flags_t;Ljava/lang/String;J)V", "GetAdd_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Ljava_lang_String_JHandler")]
		public virtual unsafe void Add_file_borrow (global::FrostWire.Libtorrent.Swig.String_view filename, string path, long file_size, global::FrostWire.Libtorrent.Swig.File_flags_t file_flags, string filehash, long mtime)
		{
			const string __id = "add_file_borrow.(Lcom/frostwire/jlibtorrent/swig/string_view;Ljava/lang/String;JLcom/frostwire/jlibtorrent/swig/file_flags_t;Ljava/lang/String;J)V";
			IntPtr native_path = JNIEnv.NewString (path);
			IntPtr native_filehash = JNIEnv.NewString (filehash);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((filename == null) ? IntPtr.Zero : ((global::Java.Lang.Object) filename).Handle);
				__args [1] = new JniArgumentValue (native_path);
				__args [2] = new JniArgumentValue (file_size);
				__args [3] = new JniArgumentValue ((file_flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file_flags).Handle);
				__args [4] = new JniArgumentValue (native_filehash);
				__args [5] = new JniArgumentValue (mtime);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				JNIEnv.DeleteLocalRef (native_filehash);
			}
		}

		static Delegate cb_add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_string_view_;
#pragma warning disable 0169
		static Delegate GetAdd_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_string_view_Handler ()
		{
			if (cb_add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_string_view_ == null)
				cb_add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_string_view_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr, IntPtr, long, IntPtr>) n_Add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_string_view_);
			return cb_add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_string_view_;
		}

		static void n_Add_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_string_view_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filename, IntPtr native_path, long file_size, IntPtr native_file_flags, IntPtr native_filehash, long mtime, IntPtr native_symlink_path)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.String_view filename = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_view> (native_filename, JniHandleOwnership.DoNotTransfer);
			string path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.File_flags_t file_flags = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_flags_t> (native_file_flags, JniHandleOwnership.DoNotTransfer);
			string filehash = JNIEnv.GetString (native_filehash, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.String_view symlink_path = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_view> (native_symlink_path, JniHandleOwnership.DoNotTransfer);
			__this.Add_file_borrow (filename, path, file_size, file_flags, filehash, mtime, symlink_path);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='add_file_borrow' and count(parameter)=7 and parameter[1][@type='com.frostwire.jlibtorrent.swig.string_view'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='com.frostwire.jlibtorrent.swig.file_flags_t'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='long'] and parameter[7][@type='com.frostwire.jlibtorrent.swig.string_view']]"
		[Register ("add_file_borrow", "(Lcom/frostwire/jlibtorrent/swig/string_view;Ljava/lang/String;JLcom/frostwire/jlibtorrent/swig/file_flags_t;Ljava/lang/String;JLcom/frostwire/jlibtorrent/swig/string_view;)V", "GetAdd_file_borrow_Lcom_frostwire_jlibtorrent_swig_string_view_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_file_flags_t_Ljava_lang_String_JLcom_frostwire_jlibtorrent_swig_string_view_Handler")]
		public virtual unsafe void Add_file_borrow (global::FrostWire.Libtorrent.Swig.String_view filename, string path, long file_size, global::FrostWire.Libtorrent.Swig.File_flags_t file_flags, string filehash, long mtime, global::FrostWire.Libtorrent.Swig.String_view symlink_path)
		{
			const string __id = "add_file_borrow.(Lcom/frostwire/jlibtorrent/swig/string_view;Ljava/lang/String;JLcom/frostwire/jlibtorrent/swig/file_flags_t;Ljava/lang/String;JLcom/frostwire/jlibtorrent/swig/string_view;)V";
			IntPtr native_path = JNIEnv.NewString (path);
			IntPtr native_filehash = JNIEnv.NewString (filehash);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((filename == null) ? IntPtr.Zero : ((global::Java.Lang.Object) filename).Handle);
				__args [1] = new JniArgumentValue (native_path);
				__args [2] = new JniArgumentValue (file_size);
				__args [3] = new JniArgumentValue ((file_flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file_flags).Handle);
				__args [4] = new JniArgumentValue (native_filehash);
				__args [5] = new JniArgumentValue (mtime);
				__args [6] = new JniArgumentValue ((symlink_path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) symlink_path).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				JNIEnv.DeleteLocalRef (native_filehash);
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
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_end_file;
#pragma warning disable 0169
		static Delegate GetEnd_fileHandler ()
		{
			if (cb_end_file == null)
				cb_end_file = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_End_file);
			return cb_end_file;
		}

		static int n_End_file (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.End_file ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='end_file' and count(parameter)=0]"
		[Register ("end_file", "()I", "GetEnd_fileHandler")]
		public virtual unsafe int End_file ()
		{
			const string __id = "end_file.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_end_piece;
#pragma warning disable 0169
		static Delegate GetEnd_pieceHandler ()
		{
			if (cb_end_piece == null)
				cb_end_piece = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_End_piece);
			return cb_end_piece;
		}

		static int n_End_piece (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.End_piece ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='end_piece' and count(parameter)=0]"
		[Register ("end_piece", "()I", "GetEnd_pieceHandler")]
		public virtual unsafe int End_piece ()
		{
			const string __id = "end_piece.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_file_absolute_path_I;
#pragma warning disable 0169
		static Delegate GetFile_absolute_path_IHandler ()
		{
			if (cb_file_absolute_path_I == null)
				cb_file_absolute_path_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_File_absolute_path_I);
			return cb_file_absolute_path_I;
		}

		static bool n_File_absolute_path_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.File_absolute_path (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='file_absolute_path' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("file_absolute_path", "(I)Z", "GetFile_absolute_path_IHandler")]
		public virtual unsafe bool File_absolute_path (int index)
		{
			const string __id = "file_absolute_path.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_file_flags_I;
#pragma warning disable 0169
		static Delegate GetFile_flags_IHandler ()
		{
			if (cb_file_flags_I == null)
				cb_file_flags_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_File_flags_I);
			return cb_file_flags_I;
		}

		static IntPtr n_File_flags_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.File_flags (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='file_flags' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("file_flags", "(I)Lcom/frostwire/jlibtorrent/swig/file_flags_t;", "GetFile_flags_IHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.File_flags_t File_flags (int index)
		{
			const string __id = "file_flags.(I)Lcom/frostwire/jlibtorrent/swig/file_flags_t;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_file_index_at_offset_J;
#pragma warning disable 0169
		static Delegate GetFile_index_at_offset_JHandler ()
		{
			if (cb_file_index_at_offset_J == null)
				cb_file_index_at_offset_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int>) n_File_index_at_offset_J);
			return cb_file_index_at_offset_J;
		}

		static int n_File_index_at_offset_J (IntPtr jnienv, IntPtr native__this, long offset)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.File_index_at_offset (offset);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='file_index_at_offset' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("file_index_at_offset", "(J)I", "GetFile_index_at_offset_JHandler")]
		public virtual unsafe int File_index_at_offset (long offset)
		{
			const string __id = "file_index_at_offset.(J)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (offset);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_file_name_I;
#pragma warning disable 0169
		static Delegate GetFile_name_IHandler ()
		{
			if (cb_file_name_I == null)
				cb_file_name_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_File_name_I);
			return cb_file_name_I;
		}

		static IntPtr n_File_name_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.File_name (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='file_name' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("file_name", "(I)Lcom/frostwire/jlibtorrent/swig/string_view;", "GetFile_name_IHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.String_view File_name (int index)
		{
			const string __id = "file_name.(I)Lcom/frostwire/jlibtorrent/swig/string_view;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_view> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_file_offset_I;
#pragma warning disable 0169
		static Delegate GetFile_offset_IHandler ()
		{
			if (cb_file_offset_I == null)
				cb_file_offset_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_File_offset_I);
			return cb_file_offset_I;
		}

		static long n_File_offset_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.File_offset (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='file_offset' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("file_offset", "(I)J", "GetFile_offset_IHandler")]
		public virtual unsafe long File_offset (int index)
		{
			const string __id = "file_offset.(I)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_file_path_I;
#pragma warning disable 0169
		static Delegate GetFile_path_IHandler ()
		{
			if (cb_file_path_I == null)
				cb_file_path_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_File_path_I);
			return cb_file_path_I;
		}

		static IntPtr n_File_path_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.File_path (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='file_path' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("file_path", "(I)Ljava/lang/String;", "GetFile_path_IHandler")]
		public virtual unsafe string File_path (int index)
		{
			const string __id = "file_path.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_file_path_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFile_path_ILjava_lang_String_Handler ()
		{
			if (cb_file_path_ILjava_lang_String_ == null)
				cb_file_path_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_File_path_ILjava_lang_String_);
			return cb_file_path_ILjava_lang_String_;
		}

		static IntPtr n_File_path_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_save_path)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string save_path = JNIEnv.GetString (native_save_path, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.File_path (index, save_path));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='file_path' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("file_path", "(ILjava/lang/String;)Ljava/lang/String;", "GetFile_path_ILjava_lang_String_Handler")]
		public virtual unsafe string File_path (int index, string save_path)
		{
			const string __id = "file_path.(ILjava/lang/String;)Ljava/lang/String;";
			IntPtr native_save_path = JNIEnv.NewString (save_path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (native_save_path);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_save_path);
			}
		}

		static Delegate cb_file_size_I;
#pragma warning disable 0169
		static Delegate GetFile_size_IHandler ()
		{
			if (cb_file_size_I == null)
				cb_file_size_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_File_size_I);
			return cb_file_size_I;
		}

		static long n_File_size_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.File_size (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='file_size' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("file_size", "(I)J", "GetFile_size_IHandler")]
		public virtual unsafe long File_size (int index)
		{
			const string __id = "file_size.(I)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.file_storage']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/file_storage;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.File_storage obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/file_storage;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_hash_I;
#pragma warning disable 0169
		static Delegate GetHash_IHandler ()
		{
			if (cb_hash_I == null)
				cb_hash_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Hash_I);
			return cb_hash_I;
		}

		static IntPtr n_Hash_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Hash (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='hash' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hash", "(I)Lcom/frostwire/jlibtorrent/swig/sha1_hash;", "GetHash_IHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Sha1_hash Hash (int index)
		{
			const string __id = "hash.(I)Lcom/frostwire/jlibtorrent/swig/sha1_hash;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_is_valid;
#pragma warning disable 0169
		static Delegate GetIs_validHandler ()
		{
			if (cb_is_valid == null)
				cb_is_valid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Is_valid);
			return cb_is_valid;
		}

		static bool n_Is_valid (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_valid ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='is_valid' and count(parameter)=0]"
		[Register ("is_valid", "()Z", "GetIs_validHandler")]
		public virtual unsafe bool Is_valid ()
		{
			const string __id = "is_valid.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_last_piece;
#pragma warning disable 0169
		static Delegate GetLast_pieceHandler ()
		{
			if (cb_last_piece == null)
				cb_last_piece = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Last_piece);
			return cb_last_piece;
		}

		static int n_Last_piece (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Last_piece ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='last_piece' and count(parameter)=0]"
		[Register ("last_piece", "()I", "GetLast_pieceHandler")]
		public virtual unsafe int Last_piece ()
		{
			const string __id = "last_piece.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_map_block_IJI;
#pragma warning disable 0169
		static Delegate GetMap_block_IJIHandler ()
		{
			if (cb_map_block_IJI == null)
				cb_map_block_IJI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long, int, IntPtr>) n_Map_block_IJI);
			return cb_map_block_IJI;
		}

		static IntPtr n_Map_block_IJI (IntPtr jnienv, IntPtr native__this, int piece, long offset, int size)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Map_block (piece, offset, size));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='map_block' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("map_block", "(IJI)Lcom/frostwire/jlibtorrent/swig/file_slice_vector;", "GetMap_block_IJIHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.File_slice_vector Map_block (int piece, long offset, int size)
		{
			const string __id = "map_block.(IJI)Lcom/frostwire/jlibtorrent/swig/file_slice_vector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (piece);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (size);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_slice_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_map_file_IJI;
#pragma warning disable 0169
		static Delegate GetMap_file_IJIHandler ()
		{
			if (cb_map_file_IJI == null)
				cb_map_file_IJI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long, int, IntPtr>) n_Map_file_IJI);
			return cb_map_file_IJI;
		}

		static IntPtr n_Map_file_IJI (IntPtr jnienv, IntPtr native__this, int file, long offset, int size)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Map_file (file, offset, size));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='map_file' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("map_file", "(IJI)Lcom/frostwire/jlibtorrent/swig/peer_request;", "GetMap_file_IJIHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Peer_request Map_file (int file, long offset, int size)
		{
			const string __id = "map_file.(IJI)Lcom/frostwire/jlibtorrent/swig/peer_request;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (file);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (size);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_request> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_mtime_I;
#pragma warning disable 0169
		static Delegate GetMtime_IHandler ()
		{
			if (cb_mtime_I == null)
				cb_mtime_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_Mtime_I);
			return cb_mtime_I;
		}

		static long n_Mtime_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Mtime (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='mtime' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("mtime", "(I)J", "GetMtime_IHandler")]
		public virtual unsafe long Mtime (int index)
		{
			const string __id = "mtime.(I)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_name;
#pragma warning disable 0169
		static Delegate GetNameHandler ()
		{
			if (cb_name == null)
				cb_name = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Name);
			return cb_name;
		}

		static IntPtr n_Name (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='name' and count(parameter)=0]"
		[Register ("name", "()Ljava/lang/String;", "GetNameHandler")]
		public virtual unsafe string Name ()
		{
			const string __id = "name.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_num_files;
#pragma warning disable 0169
		static Delegate GetNum_filesHandler ()
		{
			if (cb_num_files == null)
				cb_num_files = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Num_files);
			return cb_num_files;
		}

		static int n_Num_files (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Num_files ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='num_files' and count(parameter)=0]"
		[Register ("num_files", "()I", "GetNum_filesHandler")]
		public virtual unsafe int Num_files ()
		{
			const string __id = "num_files.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_num_pieces;
#pragma warning disable 0169
		static Delegate GetNum_piecesHandler ()
		{
			if (cb_num_pieces == null)
				cb_num_pieces = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Num_pieces);
			return cb_num_pieces;
		}

		static int n_Num_pieces (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Num_pieces ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='num_pieces' and count(parameter)=0]"
		[Register ("num_pieces", "()I", "GetNum_piecesHandler")]
		public virtual unsafe int Num_pieces ()
		{
			const string __id = "num_pieces.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_optimize;
#pragma warning disable 0169
		static Delegate GetOptimizeHandler ()
		{
			if (cb_optimize == null)
				cb_optimize = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Optimize);
			return cb_optimize;
		}

		static void n_Optimize (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Optimize ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='optimize' and count(parameter)=0]"
		[Register ("optimize", "()V", "GetOptimizeHandler")]
		public virtual unsafe void Optimize ()
		{
			const string __id = "optimize.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_optimize_I;
#pragma warning disable 0169
		static Delegate GetOptimize_IHandler ()
		{
			if (cb_optimize_I == null)
				cb_optimize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Optimize_I);
			return cb_optimize_I;
		}

		static void n_Optimize_I (IntPtr jnienv, IntPtr native__this, int pad_file_limit)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Optimize (pad_file_limit);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='optimize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("optimize", "(I)V", "GetOptimize_IHandler")]
		public virtual unsafe void Optimize (int pad_file_limit)
		{
			const string __id = "optimize.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pad_file_limit);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_optimize_II;
#pragma warning disable 0169
		static Delegate GetOptimize_IIHandler ()
		{
			if (cb_optimize_II == null)
				cb_optimize_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_Optimize_II);
			return cb_optimize_II;
		}

		static void n_Optimize_II (IntPtr jnienv, IntPtr native__this, int pad_file_limit, int alignment)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Optimize (pad_file_limit, alignment);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='optimize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("optimize", "(II)V", "GetOptimize_IIHandler")]
		public virtual unsafe void Optimize (int pad_file_limit, int alignment)
		{
			const string __id = "optimize.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (pad_file_limit);
				__args [1] = new JniArgumentValue (alignment);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_optimize_IIZ;
#pragma warning disable 0169
		static Delegate GetOptimize_IIZHandler ()
		{
			if (cb_optimize_IIZ == null)
				cb_optimize_IIZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, bool>) n_Optimize_IIZ);
			return cb_optimize_IIZ;
		}

		static void n_Optimize_IIZ (IntPtr jnienv, IntPtr native__this, int pad_file_limit, int alignment, bool tail_padding)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Optimize (pad_file_limit, alignment, tail_padding);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='optimize' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("optimize", "(IIZ)V", "GetOptimize_IIZHandler")]
		public virtual unsafe void Optimize (int pad_file_limit, int alignment, bool tail_padding)
		{
			const string __id = "optimize.(IIZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (pad_file_limit);
				__args [1] = new JniArgumentValue (alignment);
				__args [2] = new JniArgumentValue (tail_padding);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_pad_file_at_I;
#pragma warning disable 0169
		static Delegate GetPad_file_at_IHandler ()
		{
			if (cb_pad_file_at_I == null)
				cb_pad_file_at_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_Pad_file_at_I);
			return cb_pad_file_at_I;
		}

		static bool n_Pad_file_at_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Pad_file_at (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='pad_file_at' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("pad_file_at", "(I)Z", "GetPad_file_at_IHandler")]
		public virtual unsafe bool Pad_file_at (int index)
		{
			const string __id = "pad_file_at.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_paths;
#pragma warning disable 0169
		static Delegate GetPathsHandler ()
		{
			if (cb_paths == null)
				cb_paths = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Paths);
			return cb_paths;
		}

		static IntPtr n_Paths (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Paths ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='paths' and count(parameter)=0]"
		[Register ("paths", "()Lcom/frostwire/jlibtorrent/swig/string_vector;", "GetPathsHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.String_vector Paths ()
		{
			const string __id = "paths.()Lcom/frostwire/jlibtorrent/swig/string_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_piece_length;
#pragma warning disable 0169
		static Delegate GetPiece_lengthHandler ()
		{
			if (cb_piece_length == null)
				cb_piece_length = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Piece_length);
			return cb_piece_length;
		}

		static int n_Piece_length (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Piece_length ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='piece_length' and count(parameter)=0]"
		[Register ("piece_length", "()I", "GetPiece_lengthHandler")]
		public virtual unsafe int Piece_length ()
		{
			const string __id = "piece_length.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_piece_size_I;
#pragma warning disable 0169
		static Delegate GetPiece_size_IHandler ()
		{
			if (cb_piece_size_I == null)
				cb_piece_size_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_Piece_size_I);
			return cb_piece_size_I;
		}

		static int n_Piece_size_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Piece_size (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='piece_size' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("piece_size", "(I)I", "GetPiece_size_IHandler")]
		public virtual unsafe int Piece_size (int index)
		{
			const string __id = "piece_size.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_rename_file_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRename_file_ILjava_lang_String_Handler ()
		{
			if (cb_rename_file_ILjava_lang_String_ == null)
				cb_rename_file_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Rename_file_ILjava_lang_String_);
			return cb_rename_file_ILjava_lang_String_;
		}

		static void n_Rename_file_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_new_filename)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string new_filename = JNIEnv.GetString (native_new_filename, JniHandleOwnership.DoNotTransfer);
			__this.Rename_file (index, new_filename);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='rename_file' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("rename_file", "(ILjava/lang/String;)V", "GetRename_file_ILjava_lang_String_Handler")]
		public virtual unsafe void Rename_file (int index, string new_filename)
		{
			const string __id = "rename_file.(ILjava/lang/String;)V";
			IntPtr native_new_filename = JNIEnv.NewString (new_filename);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (native_new_filename);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_new_filename);
			}
		}

		static Delegate cb_reserve_I;
#pragma warning disable 0169
		static Delegate GetReserve_IHandler ()
		{
			if (cb_reserve_I == null)
				cb_reserve_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Reserve_I);
			return cb_reserve_I;
		}

		static void n_Reserve_I (IntPtr jnienv, IntPtr native__this, int num_files)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reserve (num_files);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='reserve' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("reserve", "(I)V", "GetReserve_IHandler")]
		public virtual unsafe void Reserve (int num_files)
		{
			const string __id = "reserve.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (num_files);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_name_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSet_name_Ljava_lang_String_Handler ()
		{
			if (cb_set_name_Ljava_lang_String_ == null)
				cb_set_name_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_name_Ljava_lang_String_);
			return cb_set_name_Ljava_lang_String_;
		}

		static void n_Set_name_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_n)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string n = JNIEnv.GetString (native_n, JniHandleOwnership.DoNotTransfer);
			__this.Set_name (n);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='set_name' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("set_name", "(Ljava/lang/String;)V", "GetSet_name_Ljava_lang_String_Handler")]
		public virtual unsafe void Set_name (string n)
		{
			const string __id = "set_name.(Ljava/lang/String;)V";
			IntPtr native_n = JNIEnv.NewString (n);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_n);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_n);
			}
		}

		static Delegate cb_set_num_pieces_I;
#pragma warning disable 0169
		static Delegate GetSet_num_pieces_IHandler ()
		{
			if (cb_set_num_pieces_I == null)
				cb_set_num_pieces_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Set_num_pieces_I);
			return cb_set_num_pieces_I;
		}

		static void n_Set_num_pieces_I (IntPtr jnienv, IntPtr native__this, int n)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_num_pieces (n);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='set_num_pieces' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("set_num_pieces", "(I)V", "GetSet_num_pieces_IHandler")]
		public virtual unsafe void Set_num_pieces (int n)
		{
			const string __id = "set_num_pieces.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (n);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_piece_length_I;
#pragma warning disable 0169
		static Delegate GetSet_piece_length_IHandler ()
		{
			if (cb_set_piece_length_I == null)
				cb_set_piece_length_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Set_piece_length_I);
			return cb_set_piece_length_I;
		}

		static void n_Set_piece_length_I (IntPtr jnienv, IntPtr native__this, int l)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_piece_length (l);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='set_piece_length' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("set_piece_length", "(I)V", "GetSet_piece_length_IHandler")]
		public virtual unsafe void Set_piece_length (int l)
		{
			const string __id = "set_piece_length.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (l);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_swap_Lcom_frostwire_jlibtorrent_swig_file_storage_;
#pragma warning disable 0169
		static Delegate GetSwap_Lcom_frostwire_jlibtorrent_swig_file_storage_Handler ()
		{
			if (cb_swap_Lcom_frostwire_jlibtorrent_swig_file_storage_ == null)
				cb_swap_Lcom_frostwire_jlibtorrent_swig_file_storage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Swap_Lcom_frostwire_jlibtorrent_swig_file_storage_);
			return cb_swap_Lcom_frostwire_jlibtorrent_swig_file_storage_;
		}

		static void n_Swap_Lcom_frostwire_jlibtorrent_swig_file_storage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ti)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.File_storage ti = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (native_ti, JniHandleOwnership.DoNotTransfer);
			__this.Swap (ti);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='swap' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.file_storage']]"
		[Register ("swap", "(Lcom/frostwire/jlibtorrent/swig/file_storage;)V", "GetSwap_Lcom_frostwire_jlibtorrent_swig_file_storage_Handler")]
		public virtual unsafe void Swap (global::FrostWire.Libtorrent.Swig.File_storage ti)
		{
			const string __id = "swap.(Lcom/frostwire/jlibtorrent/swig/file_storage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ti == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ti).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_symlink_I;
#pragma warning disable 0169
		static Delegate GetSymlink_IHandler ()
		{
			if (cb_symlink_I == null)
				cb_symlink_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Symlink_I);
			return cb_symlink_I;
		}

		static IntPtr n_Symlink_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Symlink (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='symlink' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("symlink", "(I)Ljava/lang/String;", "GetSymlink_IHandler")]
		public virtual unsafe string Symlink (int index)
		{
			const string __id = "symlink.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_total_size;
#pragma warning disable 0169
		static Delegate GetTotal_sizeHandler ()
		{
			if (cb_total_size == null)
				cb_total_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Total_size);
			return cb_total_size;
		}

		static long n_Total_size (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.File_storage __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Total_size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_storage']/method[@name='total_size' and count(parameter)=0]"
		[Register ("total_size", "()J", "GetTotal_sizeHandler")]
		public virtual unsafe long Total_size ()
		{
			const string __id = "total_size.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
