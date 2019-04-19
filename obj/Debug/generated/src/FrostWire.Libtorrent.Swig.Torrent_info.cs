using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/torrent_info", DoNotGenerateAcw=true)]
	public partial class Torrent_info : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/torrent_info", typeof (Torrent_info));
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

		protected Torrent_info (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/constructor[@name='torrent_info' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.bdecode_node'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.error_code']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/bdecode_node;Lcom/frostwire/jlibtorrent/swig/error_code;)V", "")]
		public unsafe Torrent_info (global::FrostWire.Libtorrent.Swig.Bdecode_node torrent_file, global::FrostWire.Libtorrent.Swig.Error_code ec)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/bdecode_node;Lcom/frostwire/jlibtorrent/swig/error_code;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((torrent_file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) torrent_file).Handle);
				__args [1] = new JniArgumentValue ((ec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ec).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/constructor[@name='torrent_info' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.sha1_hash']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V", "")]
		public unsafe Torrent_info (global::FrostWire.Libtorrent.Swig.Sha1_hash info_hash)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((info_hash == null) ? IntPtr.Zero : ((global::Java.Lang.Object) info_hash).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/constructor[@name='torrent_info' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_info']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/torrent_info;)V", "")]
		public unsafe Torrent_info (global::FrostWire.Libtorrent.Swig.Torrent_info t)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/torrent_info;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Object) t).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/constructor[@name='torrent_info' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.error_code']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/error_code;)V", "")]
		public unsafe Torrent_info (string filename, global::FrostWire.Libtorrent.Swig.Error_code ec)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/error_code;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_filename = JNIEnv.NewString (filename);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_filename);
				__args [1] = new JniArgumentValue ((ec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ec).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_filename);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/constructor[@name='torrent_info' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Torrent_info (long cPtr, bool cMemoryOwn)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/constructor[@name='torrent_info' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='com.frostwire.jlibtorrent.swig.error_code']]"
		[Register (".ctor", "(JILcom/frostwire/jlibtorrent/swig/error_code;)V", "")]
		public unsafe Torrent_info (long buffer_ptr, int size, global::FrostWire.Libtorrent.Swig.Error_code ec)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JILcom/frostwire/jlibtorrent/swig/error_code;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (buffer_ptr);
				__args [1] = new JniArgumentValue (size);
				__args [2] = new JniArgumentValue ((ec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ec).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_add_http_seed_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdd_http_seed_Ljava_lang_String_Handler ()
		{
			if (cb_add_http_seed_Ljava_lang_String_ == null)
				cb_add_http_seed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_http_seed_Ljava_lang_String_);
			return cb_add_http_seed_Ljava_lang_String_;
		}

		static void n_Add_http_seed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.Add_http_seed (url);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='add_http_seed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("add_http_seed", "(Ljava/lang/String;)V", "GetAdd_http_seed_Ljava_lang_String_Handler")]
		public virtual unsafe void Add_http_seed (string url)
		{
			const string __id = "add_http_seed.(Ljava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_add_http_seed_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdd_http_seed_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_add_http_seed_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_add_http_seed_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_http_seed_Ljava_lang_String_Ljava_lang_String_);
			return cb_add_http_seed_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Add_http_seed_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_extern_auth)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			string extern_auth = JNIEnv.GetString (native_extern_auth, JniHandleOwnership.DoNotTransfer);
			__this.Add_http_seed (url, extern_auth);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='add_http_seed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("add_http_seed", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAdd_http_seed_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Add_http_seed (string url, string extern_auth)
		{
			const string __id = "add_http_seed.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_extern_auth = JNIEnv.NewString (extern_auth);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_extern_auth);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_extern_auth);
			}
		}

		static Delegate cb_add_http_seed_Ljava_lang_String_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_string_string_pair_vector_;
#pragma warning disable 0169
		static Delegate GetAdd_http_seed_Ljava_lang_String_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_string_string_pair_vector_Handler ()
		{
			if (cb_add_http_seed_Ljava_lang_String_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_string_string_pair_vector_ == null)
				cb_add_http_seed_Ljava_lang_String_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_string_string_pair_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_http_seed_Ljava_lang_String_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_string_string_pair_vector_);
			return cb_add_http_seed_Ljava_lang_String_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_string_string_pair_vector_;
		}

		static void n_Add_http_seed_Ljava_lang_String_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_string_string_pair_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_extern_auth, IntPtr native_extra_headers)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			string extern_auth = JNIEnv.GetString (native_extern_auth, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.String_string_pair_vector extra_headers = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_string_pair_vector> (native_extra_headers, JniHandleOwnership.DoNotTransfer);
			__this.Add_http_seed (url, extern_auth, extra_headers);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='add_http_seed' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.frostwire.jlibtorrent.swig.string_string_pair_vector']]"
		[Register ("add_http_seed", "(Ljava/lang/String;Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/string_string_pair_vector;)V", "GetAdd_http_seed_Ljava_lang_String_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_string_string_pair_vector_Handler")]
		public virtual unsafe void Add_http_seed (string url, string extern_auth, global::FrostWire.Libtorrent.Swig.String_string_pair_vector extra_headers)
		{
			const string __id = "add_http_seed.(Ljava/lang/String;Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/string_string_pair_vector;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_extern_auth = JNIEnv.NewString (extern_auth);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_extern_auth);
				__args [2] = new JniArgumentValue ((extra_headers == null) ? IntPtr.Zero : ((global::Java.Lang.Object) extra_headers).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_extern_auth);
			}
		}

		static Delegate cb_add_node_Lcom_frostwire_jlibtorrent_swig_string_int_pair_;
#pragma warning disable 0169
		static Delegate GetAdd_node_Lcom_frostwire_jlibtorrent_swig_string_int_pair_Handler ()
		{
			if (cb_add_node_Lcom_frostwire_jlibtorrent_swig_string_int_pair_ == null)
				cb_add_node_Lcom_frostwire_jlibtorrent_swig_string_int_pair_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_node_Lcom_frostwire_jlibtorrent_swig_string_int_pair_);
			return cb_add_node_Lcom_frostwire_jlibtorrent_swig_string_int_pair_;
		}

		static void n_Add_node_Lcom_frostwire_jlibtorrent_swig_string_int_pair_ (IntPtr jnienv, IntPtr native__this, IntPtr native_node)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.String_int_pair node = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_int_pair> (native_node, JniHandleOwnership.DoNotTransfer);
			__this.Add_node (node);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='add_node' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.string_int_pair']]"
		[Register ("add_node", "(Lcom/frostwire/jlibtorrent/swig/string_int_pair;)V", "GetAdd_node_Lcom_frostwire_jlibtorrent_swig_string_int_pair_Handler")]
		public virtual unsafe void Add_node (global::FrostWire.Libtorrent.Swig.String_int_pair node)
		{
			const string __id = "add_node.(Lcom/frostwire/jlibtorrent/swig/string_int_pair;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((node == null) ? IntPtr.Zero : ((global::Java.Lang.Object) node).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_add_tracker_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdd_tracker_Ljava_lang_String_Handler ()
		{
			if (cb_add_tracker_Ljava_lang_String_ == null)
				cb_add_tracker_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_tracker_Ljava_lang_String_);
			return cb_add_tracker_Ljava_lang_String_;
		}

		static void n_Add_tracker_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.Add_tracker (url);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='add_tracker' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("add_tracker", "(Ljava/lang/String;)V", "GetAdd_tracker_Ljava_lang_String_Handler")]
		public virtual unsafe void Add_tracker (string url)
		{
			const string __id = "add_tracker.(Ljava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_add_tracker_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetAdd_tracker_Ljava_lang_String_IHandler ()
		{
			if (cb_add_tracker_Ljava_lang_String_I == null)
				cb_add_tracker_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Add_tracker_Ljava_lang_String_I);
			return cb_add_tracker_Ljava_lang_String_I;
		}

		static void n_Add_tracker_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_url, int tier)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.Add_tracker (url, tier);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='add_tracker' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("add_tracker", "(Ljava/lang/String;I)V", "GetAdd_tracker_Ljava_lang_String_IHandler")]
		public virtual unsafe void Add_tracker (string url, int tier)
		{
			const string __id = "add_tracker.(Ljava/lang/String;I)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (tier);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_add_url_seed_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdd_url_seed_Ljava_lang_String_Handler ()
		{
			if (cb_add_url_seed_Ljava_lang_String_ == null)
				cb_add_url_seed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_url_seed_Ljava_lang_String_);
			return cb_add_url_seed_Ljava_lang_String_;
		}

		static void n_Add_url_seed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.Add_url_seed (url);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='add_url_seed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("add_url_seed", "(Ljava/lang/String;)V", "GetAdd_url_seed_Ljava_lang_String_Handler")]
		public virtual unsafe void Add_url_seed (string url)
		{
			const string __id = "add_url_seed.(Ljava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_add_url_seed_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdd_url_seed_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_add_url_seed_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_add_url_seed_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_url_seed_Ljava_lang_String_Ljava_lang_String_);
			return cb_add_url_seed_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Add_url_seed_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_extern_auth)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			string extern_auth = JNIEnv.GetString (native_extern_auth, JniHandleOwnership.DoNotTransfer);
			__this.Add_url_seed (url, extern_auth);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='add_url_seed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("add_url_seed", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAdd_url_seed_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Add_url_seed (string url, string extern_auth)
		{
			const string __id = "add_url_seed.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_extern_auth = JNIEnv.NewString (extern_auth);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_extern_auth);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_extern_auth);
			}
		}

		static Delegate cb_add_url_seed_Ljava_lang_String_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_string_string_pair_vector_;
#pragma warning disable 0169
		static Delegate GetAdd_url_seed_Ljava_lang_String_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_string_string_pair_vector_Handler ()
		{
			if (cb_add_url_seed_Ljava_lang_String_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_string_string_pair_vector_ == null)
				cb_add_url_seed_Ljava_lang_String_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_string_string_pair_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_url_seed_Ljava_lang_String_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_string_string_pair_vector_);
			return cb_add_url_seed_Ljava_lang_String_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_string_string_pair_vector_;
		}

		static void n_Add_url_seed_Ljava_lang_String_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_string_string_pair_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_extern_auth, IntPtr native_extra_headers)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			string extern_auth = JNIEnv.GetString (native_extern_auth, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.String_string_pair_vector extra_headers = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_string_pair_vector> (native_extra_headers, JniHandleOwnership.DoNotTransfer);
			__this.Add_url_seed (url, extern_auth, extra_headers);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='add_url_seed' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.frostwire.jlibtorrent.swig.string_string_pair_vector']]"
		[Register ("add_url_seed", "(Ljava/lang/String;Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/string_string_pair_vector;)V", "GetAdd_url_seed_Ljava_lang_String_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_string_string_pair_vector_Handler")]
		public virtual unsafe void Add_url_seed (string url, string extern_auth, global::FrostWire.Libtorrent.Swig.String_string_pair_vector extra_headers)
		{
			const string __id = "add_url_seed.(Ljava/lang/String;Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/string_string_pair_vector;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_extern_auth = JNIEnv.NewString (extern_auth);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_extern_auth);
				__args [2] = new JniArgumentValue ((extra_headers == null) ? IntPtr.Zero : ((global::Java.Lang.Object) extra_headers).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_extern_auth);
			}
		}

		static Delegate cb_collections;
#pragma warning disable 0169
		static Delegate GetCollectionsHandler ()
		{
			if (cb_collections == null)
				cb_collections = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Collections);
			return cb_collections;
		}

		static IntPtr n_Collections (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Collections ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='collections' and count(parameter)=0]"
		[Register ("collections", "()Lcom/frostwire/jlibtorrent/swig/string_vector;", "GetCollectionsHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.String_vector Collections ()
		{
			const string __id = "collections.()Lcom/frostwire/jlibtorrent/swig/string_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_comment;
#pragma warning disable 0169
		static Delegate GetCommentHandler ()
		{
			if (cb_comment == null)
				cb_comment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Comment);
			return cb_comment;
		}

		static IntPtr n_Comment (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Comment ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='comment' and count(parameter)=0]"
		[Register ("comment", "()Ljava/lang/String;", "GetCommentHandler")]
		public virtual unsafe string Comment ()
		{
			const string __id = "comment.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_creation_date;
#pragma warning disable 0169
		static Delegate GetCreation_dateHandler ()
		{
			if (cb_creation_date == null)
				cb_creation_date = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Creation_date);
			return cb_creation_date;
		}

		static long n_Creation_date (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Creation_date ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='creation_date' and count(parameter)=0]"
		[Register ("creation_date", "()J", "GetCreation_dateHandler")]
		public virtual unsafe long Creation_date ()
		{
			const string __id = "creation_date.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_creator;
#pragma warning disable 0169
		static Delegate GetCreatorHandler ()
		{
			if (cb_creator == null)
				cb_creator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Creator);
			return cb_creator;
		}

		static IntPtr n_Creator (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Creator ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='creator' and count(parameter)=0]"
		[Register ("creator", "()Ljava/lang/String;", "GetCreatorHandler")]
		public virtual unsafe string Creator ()
		{
			const string __id = "creator.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.End_piece ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='end_piece' and count(parameter)=0]"
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

		static Delegate cb_files;
#pragma warning disable 0169
		static Delegate GetFilesHandler ()
		{
			if (cb_files == null)
				cb_files = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Files);
			return cb_files;
		}

		static IntPtr n_Files (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Files ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='files' and count(parameter)=0]"
		[Register ("files", "()Lcom/frostwire/jlibtorrent/swig/file_storage;", "GetFilesHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.File_storage Files ()
		{
			const string __id = "files.()Lcom/frostwire/jlibtorrent/swig/file_storage;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_info']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/torrent_info;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Torrent_info obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/torrent_info;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_hash_for_piece_I;
#pragma warning disable 0169
		static Delegate GetHash_for_piece_IHandler ()
		{
			if (cb_hash_for_piece_I == null)
				cb_hash_for_piece_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Hash_for_piece_I);
			return cb_hash_for_piece_I;
		}

		static IntPtr n_Hash_for_piece_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Hash_for_piece (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='hash_for_piece' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hash_for_piece", "(I)Lcom/frostwire/jlibtorrent/swig/sha1_hash;", "GetHash_for_piece_IHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Sha1_hash Hash_for_piece (int index)
		{
			const string __id = "hash_for_piece.(I)Lcom/frostwire/jlibtorrent/swig/sha1_hash;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_info_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInfo_Ljava_lang_String_Handler ()
		{
			if (cb_info_Ljava_lang_String_ == null)
				cb_info_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Info_Ljava_lang_String_);
			return cb_info_Ljava_lang_String_;
		}

		static IntPtr n_Info_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Info (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='info' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("info", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/swig/bdecode_node;", "GetInfo_Ljava_lang_String_Handler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Bdecode_node Info (string key)
		{
			const string __id = "info.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/swig/bdecode_node;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_info_hash;
#pragma warning disable 0169
		static Delegate GetInfo_hashHandler ()
		{
			if (cb_info_hash == null)
				cb_info_hash = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Info_hash);
			return cb_info_hash;
		}

		static IntPtr n_Info_hash (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Info_hash ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='info_hash' and count(parameter)=0]"
		[Register ("info_hash", "()Lcom/frostwire/jlibtorrent/swig/sha1_hash;", "GetInfo_hashHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Sha1_hash Info_hash ()
		{
			const string __id = "info_hash.()Lcom/frostwire/jlibtorrent/swig/sha1_hash;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_is_i2p;
#pragma warning disable 0169
		static Delegate GetIs_i2pHandler ()
		{
			if (cb_is_i2p == null)
				cb_is_i2p = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Is_i2p);
			return cb_is_i2p;
		}

		static bool n_Is_i2p (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_i2p ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='is_i2p' and count(parameter)=0]"
		[Register ("is_i2p", "()Z", "GetIs_i2pHandler")]
		public virtual unsafe bool Is_i2p ()
		{
			const string __id = "is_i2p.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_is_loaded;
#pragma warning disable 0169
		static Delegate GetIs_loadedHandler ()
		{
			if (cb_is_loaded == null)
				cb_is_loaded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Is_loaded);
			return cb_is_loaded;
		}

		static bool n_Is_loaded (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_loaded ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='is_loaded' and count(parameter)=0]"
		[Register ("is_loaded", "()Z", "GetIs_loadedHandler")]
		public virtual unsafe bool Is_loaded ()
		{
			const string __id = "is_loaded.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_is_merkle_torrent;
#pragma warning disable 0169
		static Delegate GetIs_merkle_torrentHandler ()
		{
			if (cb_is_merkle_torrent == null)
				cb_is_merkle_torrent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Is_merkle_torrent);
			return cb_is_merkle_torrent;
		}

		static bool n_Is_merkle_torrent (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_merkle_torrent ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='is_merkle_torrent' and count(parameter)=0]"
		[Register ("is_merkle_torrent", "()Z", "GetIs_merkle_torrentHandler")]
		public virtual unsafe bool Is_merkle_torrent ()
		{
			const string __id = "is_merkle_torrent.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
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
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_valid ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='is_valid' and count(parameter)=0]"
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
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Last_piece ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='last_piece' and count(parameter)=0]"
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
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Map_block (piece, offset, size));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='map_block' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
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
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Map_file (file, offset, size));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='map_file' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
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

		static Delegate cb_merkle_tree;
#pragma warning disable 0169
		static Delegate GetMerkle_treeHandler ()
		{
			if (cb_merkle_tree == null)
				cb_merkle_tree = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Merkle_tree);
			return cb_merkle_tree;
		}

		static IntPtr n_Merkle_tree (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Merkle_tree ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='merkle_tree' and count(parameter)=0]"
		[Register ("merkle_tree", "()Lcom/frostwire/jlibtorrent/swig/sha1_hash_vector;", "GetMerkle_treeHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Sha1_hash_vector Merkle_tree ()
		{
			const string __id = "merkle_tree.()Lcom/frostwire/jlibtorrent/swig/sha1_hash_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_metadata_size;
#pragma warning disable 0169
		static Delegate GetMetadata_sizeHandler ()
		{
			if (cb_metadata_size == null)
				cb_metadata_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Metadata_size);
			return cb_metadata_size;
		}

		static int n_Metadata_size (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Metadata_size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='metadata_size' and count(parameter)=0]"
		[Register ("metadata_size", "()I", "GetMetadata_sizeHandler")]
		public virtual unsafe int Metadata_size ()
		{
			const string __id = "metadata_size.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
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
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='name' and count(parameter)=0]"
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

		static Delegate cb_nodes;
#pragma warning disable 0169
		static Delegate GetNodesHandler ()
		{
			if (cb_nodes == null)
				cb_nodes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Nodes);
			return cb_nodes;
		}

		static IntPtr n_Nodes (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Nodes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='nodes' and count(parameter)=0]"
		[Register ("nodes", "()Lcom/frostwire/jlibtorrent/swig/string_int_pair_vector;", "GetNodesHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.String_int_pair_vector Nodes ()
		{
			const string __id = "nodes.()Lcom/frostwire/jlibtorrent/swig/string_int_pair_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_int_pair_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Num_files ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='num_files' and count(parameter)=0]"
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
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Num_pieces ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='num_pieces' and count(parameter)=0]"
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

		static Delegate cb_orig_files;
#pragma warning disable 0169
		static Delegate GetOrig_filesHandler ()
		{
			if (cb_orig_files == null)
				cb_orig_files = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Orig_files);
			return cb_orig_files;
		}

		static IntPtr n_Orig_files (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Orig_files ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='orig_files' and count(parameter)=0]"
		[Register ("orig_files", "()Lcom/frostwire/jlibtorrent/swig/file_storage;", "GetOrig_filesHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.File_storage Orig_files ()
		{
			const string __id = "orig_files.()Lcom/frostwire/jlibtorrent/swig/file_storage;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Piece_length ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='piece_length' and count(parameter)=0]"
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
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Piece_size (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='piece_size' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_priv;
#pragma warning disable 0169
		static Delegate GetPrivHandler ()
		{
			if (cb_priv == null)
				cb_priv = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Priv);
			return cb_priv;
		}

		static bool n_Priv (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Priv ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='priv' and count(parameter)=0]"
		[Register ("priv", "()Z", "GetPrivHandler")]
		public virtual unsafe bool Priv ()
		{
			const string __id = "priv.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_remap_files_Lcom_frostwire_jlibtorrent_swig_file_storage_;
#pragma warning disable 0169
		static Delegate GetRemap_files_Lcom_frostwire_jlibtorrent_swig_file_storage_Handler ()
		{
			if (cb_remap_files_Lcom_frostwire_jlibtorrent_swig_file_storage_ == null)
				cb_remap_files_Lcom_frostwire_jlibtorrent_swig_file_storage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remap_files_Lcom_frostwire_jlibtorrent_swig_file_storage_);
			return cb_remap_files_Lcom_frostwire_jlibtorrent_swig_file_storage_;
		}

		static void n_Remap_files_Lcom_frostwire_jlibtorrent_swig_file_storage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_f)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.File_storage f = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (native_f, JniHandleOwnership.DoNotTransfer);
			__this.Remap_files (f);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='remap_files' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.file_storage']]"
		[Register ("remap_files", "(Lcom/frostwire/jlibtorrent/swig/file_storage;)V", "GetRemap_files_Lcom_frostwire_jlibtorrent_swig_file_storage_Handler")]
		public virtual unsafe void Remap_files (global::FrostWire.Libtorrent.Swig.File_storage f)
		{
			const string __id = "remap_files.(Lcom/frostwire/jlibtorrent/swig/file_storage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string new_filename = JNIEnv.GetString (native_new_filename, JniHandleOwnership.DoNotTransfer);
			__this.Rename_file (index, new_filename);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='rename_file' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
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

		static Delegate cb_set_merkle_tree_Lcom_frostwire_jlibtorrent_swig_sha1_hash_vector_;
#pragma warning disable 0169
		static Delegate GetSet_merkle_tree_Lcom_frostwire_jlibtorrent_swig_sha1_hash_vector_Handler ()
		{
			if (cb_set_merkle_tree_Lcom_frostwire_jlibtorrent_swig_sha1_hash_vector_ == null)
				cb_set_merkle_tree_Lcom_frostwire_jlibtorrent_swig_sha1_hash_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_merkle_tree_Lcom_frostwire_jlibtorrent_swig_sha1_hash_vector_);
			return cb_set_merkle_tree_Lcom_frostwire_jlibtorrent_swig_sha1_hash_vector_;
		}

		static void n_Set_merkle_tree_Lcom_frostwire_jlibtorrent_swig_sha1_hash_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_h)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Sha1_hash_vector h = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash_vector> (native_h, JniHandleOwnership.DoNotTransfer);
			__this.Set_merkle_tree (h);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='set_merkle_tree' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.sha1_hash_vector']]"
		[Register ("set_merkle_tree", "(Lcom/frostwire/jlibtorrent/swig/sha1_hash_vector;)V", "GetSet_merkle_tree_Lcom_frostwire_jlibtorrent_swig_sha1_hash_vector_Handler")]
		public virtual unsafe void Set_merkle_tree (global::FrostWire.Libtorrent.Swig.Sha1_hash_vector h)
		{
			const string __id = "set_merkle_tree.(Lcom/frostwire/jlibtorrent/swig/sha1_hash_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((h == null) ? IntPtr.Zero : ((global::Java.Lang.Object) h).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_web_seeds_Lcom_frostwire_jlibtorrent_swig_web_seed_entry_vector_;
#pragma warning disable 0169
		static Delegate GetSet_web_seeds_Lcom_frostwire_jlibtorrent_swig_web_seed_entry_vector_Handler ()
		{
			if (cb_set_web_seeds_Lcom_frostwire_jlibtorrent_swig_web_seed_entry_vector_ == null)
				cb_set_web_seeds_Lcom_frostwire_jlibtorrent_swig_web_seed_entry_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_web_seeds_Lcom_frostwire_jlibtorrent_swig_web_seed_entry_vector_);
			return cb_set_web_seeds_Lcom_frostwire_jlibtorrent_swig_web_seed_entry_vector_;
		}

		static void n_Set_web_seeds_Lcom_frostwire_jlibtorrent_swig_web_seed_entry_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_seeds)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Web_seed_entry_vector seeds = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Web_seed_entry_vector> (native_seeds, JniHandleOwnership.DoNotTransfer);
			__this.Set_web_seeds (seeds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='set_web_seeds' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.web_seed_entry_vector']]"
		[Register ("set_web_seeds", "(Lcom/frostwire/jlibtorrent/swig/web_seed_entry_vector;)V", "GetSet_web_seeds_Lcom_frostwire_jlibtorrent_swig_web_seed_entry_vector_Handler")]
		public virtual unsafe void Set_web_seeds (global::FrostWire.Libtorrent.Swig.Web_seed_entry_vector seeds)
		{
			const string __id = "set_web_seeds.(Lcom/frostwire/jlibtorrent/swig/web_seed_entry_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((seeds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) seeds).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_similar_torrents;
#pragma warning disable 0169
		static Delegate GetSimilar_torrentsHandler ()
		{
			if (cb_similar_torrents == null)
				cb_similar_torrents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Similar_torrents);
			return cb_similar_torrents;
		}

		static IntPtr n_Similar_torrents (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Similar_torrents ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='similar_torrents' and count(parameter)=0]"
		[Register ("similar_torrents", "()Lcom/frostwire/jlibtorrent/swig/sha1_hash_vector;", "GetSimilar_torrentsHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Sha1_hash_vector Similar_torrents ()
		{
			const string __id = "similar_torrents.()Lcom/frostwire/jlibtorrent/swig/sha1_hash_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_ssl_cert;
#pragma warning disable 0169
		static Delegate GetSsl_certHandler ()
		{
			if (cb_ssl_cert == null)
				cb_ssl_cert = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Ssl_cert);
			return cb_ssl_cert;
		}

		static IntPtr n_Ssl_cert (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Ssl_cert ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='ssl_cert' and count(parameter)=0]"
		[Register ("ssl_cert", "()Lcom/frostwire/jlibtorrent/swig/string_view;", "GetSsl_certHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.String_view Ssl_cert ()
		{
			const string __id = "ssl_cert.()Lcom/frostwire/jlibtorrent/swig/string_view;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_view> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Total_size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='total_size' and count(parameter)=0]"
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

		static Delegate cb_trackers;
#pragma warning disable 0169
		static Delegate GetTrackersHandler ()
		{
			if (cb_trackers == null)
				cb_trackers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Trackers);
			return cb_trackers;
		}

		static IntPtr n_Trackers (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Trackers ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='trackers' and count(parameter)=0]"
		[Register ("trackers", "()Lcom/frostwire/jlibtorrent/swig/announce_entry_vector;", "GetTrackersHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Announce_entry_vector Trackers ()
		{
			const string __id = "trackers.()Lcom/frostwire/jlibtorrent/swig/announce_entry_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_entry_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_web_seeds;
#pragma warning disable 0169
		static Delegate GetWeb_seedsHandler ()
		{
			if (cb_web_seeds == null)
				cb_web_seeds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Web_seeds);
			return cb_web_seeds;
		}

		static IntPtr n_Web_seeds (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Web_seeds ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_info']/method[@name='web_seeds' and count(parameter)=0]"
		[Register ("web_seeds", "()Lcom/frostwire/jlibtorrent/swig/web_seed_entry_vector;", "GetWeb_seedsHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Web_seed_entry_vector Web_seeds ()
		{
			const string __id = "web_seeds.()Lcom/frostwire/jlibtorrent/swig/web_seed_entry_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Web_seed_entry_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
