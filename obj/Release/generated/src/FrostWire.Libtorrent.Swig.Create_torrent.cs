using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/create_torrent", DoNotGenerateAcw=true)]
	public partial class Create_torrent : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/field[@name='merkle']"
		[Register ("merkle")]
		public static global::FrostWire.Libtorrent.Swig.Create_flags_t Merkle {
			get {
				const string __id = "merkle.Lcom/frostwire/jlibtorrent/swig/create_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/field[@name='modification_time']"
		[Register ("modification_time")]
		public static global::FrostWire.Libtorrent.Swig.Create_flags_t ModificationTime {
			get {
				const string __id = "modification_time.Lcom/frostwire/jlibtorrent/swig/create_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/field[@name='mutable_torrent_support']"
		[Register ("mutable_torrent_support")]
		public static global::FrostWire.Libtorrent.Swig.Create_flags_t MutableTorrentSupport {
			get {
				const string __id = "mutable_torrent_support.Lcom/frostwire/jlibtorrent/swig/create_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/field[@name='optimize_alignment']"
		[Register ("optimize_alignment")]
		public static global::FrostWire.Libtorrent.Swig.Create_flags_t OptimizeAlignment {
			get {
				const string __id = "optimize_alignment.Lcom/frostwire/jlibtorrent/swig/create_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/field[@name='swigCMemOwn']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/field[@name='symlinks']"
		[Register ("symlinks")]
		public static global::FrostWire.Libtorrent.Swig.Create_flags_t Symlinks {
			get {
				const string __id = "symlinks.Lcom/frostwire/jlibtorrent/swig/create_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/create_torrent", typeof (Create_torrent));
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

		protected Create_torrent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/constructor[@name='create_torrent' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.file_storage']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/file_storage;)V", "")]
		public unsafe Create_torrent (global::FrostWire.Libtorrent.Swig.File_storage fs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/file_storage;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/constructor[@name='create_torrent' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.file_storage'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/file_storage;I)V", "")]
		public unsafe Create_torrent (global::FrostWire.Libtorrent.Swig.File_storage fs, int piece_size)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/file_storage;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
				__args [1] = new JniArgumentValue (piece_size);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/constructor[@name='create_torrent' and count(parameter)=3 and parameter[1][@type='com.frostwire.jlibtorrent.swig.file_storage'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/file_storage;II)V", "")]
		public unsafe Create_torrent (global::FrostWire.Libtorrent.Swig.File_storage fs, int piece_size, int pad_file_limit)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/file_storage;II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
				__args [1] = new JniArgumentValue (piece_size);
				__args [2] = new JniArgumentValue (pad_file_limit);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/constructor[@name='create_torrent' and count(parameter)=4 and parameter[1][@type='com.frostwire.jlibtorrent.swig.file_storage'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.frostwire.jlibtorrent.swig.create_flags_t']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/file_storage;IILcom/frostwire/jlibtorrent/swig/create_flags_t;)V", "")]
		public unsafe Create_torrent (global::FrostWire.Libtorrent.Swig.File_storage fs, int piece_size, int pad_file_limit, global::FrostWire.Libtorrent.Swig.Create_flags_t flags)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/file_storage;IILcom/frostwire/jlibtorrent/swig/create_flags_t;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
				__args [1] = new JniArgumentValue (piece_size);
				__args [2] = new JniArgumentValue (pad_file_limit);
				__args [3] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/constructor[@name='create_torrent' and count(parameter)=5 and parameter[1][@type='com.frostwire.jlibtorrent.swig.file_storage'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.frostwire.jlibtorrent.swig.create_flags_t'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/file_storage;IILcom/frostwire/jlibtorrent/swig/create_flags_t;I)V", "")]
		public unsafe Create_torrent (global::FrostWire.Libtorrent.Swig.File_storage fs, int piece_size, int pad_file_limit, global::FrostWire.Libtorrent.Swig.Create_flags_t flags, int alignment)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/file_storage;IILcom/frostwire/jlibtorrent/swig/create_flags_t;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
				__args [1] = new JniArgumentValue (piece_size);
				__args [2] = new JniArgumentValue (pad_file_limit);
				__args [3] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				__args [4] = new JniArgumentValue (alignment);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/constructor[@name='create_torrent' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_info']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/torrent_info;)V", "")]
		public unsafe Create_torrent (global::FrostWire.Libtorrent.Swig.Torrent_info ti)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/torrent_info;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ti == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ti).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/constructor[@name='create_torrent' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Create_torrent (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_add_collection_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdd_collection_Ljava_lang_String_Handler ()
		{
			if (cb_add_collection_Ljava_lang_String_ == null)
				cb_add_collection_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_collection_Ljava_lang_String_);
			return cb_add_collection_Ljava_lang_String_;
		}

		static void n_Add_collection_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			global::FrostWire.Libtorrent.Swig.Create_torrent __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string c = JNIEnv.GetString (native_c, JniHandleOwnership.DoNotTransfer);
			__this.Add_collection (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/method[@name='add_collection' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("add_collection", "(Ljava/lang/String;)V", "GetAdd_collection_Ljava_lang_String_Handler")]
		public virtual unsafe void Add_collection (string c)
		{
			const string __id = "add_collection.(Ljava/lang/String;)V";
			IntPtr native_c = JNIEnv.NewString (c);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_c);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_c);
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
			global::FrostWire.Libtorrent.Swig.Create_torrent __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.Add_http_seed (url);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/method[@name='add_http_seed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::FrostWire.Libtorrent.Swig.Create_torrent __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.String_int_pair node = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_int_pair> (native_node, JniHandleOwnership.DoNotTransfer);
			__this.Add_node (node);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/method[@name='add_node' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.string_int_pair']]"
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

		static Delegate cb_add_similar_torrent_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
#pragma warning disable 0169
		static Delegate GetAdd_similar_torrent_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler ()
		{
			if (cb_add_similar_torrent_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ == null)
				cb_add_similar_torrent_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_similar_torrent_Lcom_frostwire_jlibtorrent_swig_sha1_hash_);
			return cb_add_similar_torrent_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
		}

		static void n_Add_similar_torrent_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ih)
		{
			global::FrostWire.Libtorrent.Swig.Create_torrent __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Sha1_hash ih = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (native_ih, JniHandleOwnership.DoNotTransfer);
			__this.Add_similar_torrent (ih);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/method[@name='add_similar_torrent' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.sha1_hash']]"
		[Register ("add_similar_torrent", "(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V", "GetAdd_similar_torrent_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler")]
		public virtual unsafe void Add_similar_torrent (global::FrostWire.Libtorrent.Swig.Sha1_hash ih)
		{
			const string __id = "add_similar_torrent.(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ih == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ih).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
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
			global::FrostWire.Libtorrent.Swig.Create_torrent __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.Add_tracker (url, tier);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/method[@name='add_tracker' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
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
			global::FrostWire.Libtorrent.Swig.Create_torrent __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.Add_url_seed (url);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/method[@name='add_url_seed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::FrostWire.Libtorrent.Swig.Create_torrent __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			global::FrostWire.Libtorrent.Swig.Create_torrent __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Files ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/method[@name='files' and count(parameter)=0]"
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

		static Delegate cb_generate;
#pragma warning disable 0169
		static Delegate GetGenerateHandler ()
		{
			if (cb_generate == null)
				cb_generate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Generate);
			return cb_generate;
		}

		static IntPtr n_Generate (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Create_torrent __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Generate ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/method[@name='generate' and count(parameter)=0]"
		[Register ("generate", "()Lcom/frostwire/jlibtorrent/swig/entry;", "GetGenerateHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Entry Generate ()
		{
			const string __id = "generate.()Lcom/frostwire/jlibtorrent/swig/entry;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.create_torrent']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/create_torrent;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Create_torrent obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/create_torrent;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
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
			global::FrostWire.Libtorrent.Swig.Create_torrent __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Merkle_tree ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/method[@name='merkle_tree' and count(parameter)=0]"
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
			global::FrostWire.Libtorrent.Swig.Create_torrent __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Num_pieces ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/method[@name='num_pieces' and count(parameter)=0]"
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
			global::FrostWire.Libtorrent.Swig.Create_torrent __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Piece_length ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/method[@name='piece_length' and count(parameter)=0]"
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

		static int n_Piece_size_I (IntPtr jnienv, IntPtr native__this, int i)
		{
			global::FrostWire.Libtorrent.Swig.Create_torrent __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Piece_size (i);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/method[@name='piece_size' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("piece_size", "(I)I", "GetPiece_size_IHandler")]
		public virtual unsafe int Piece_size (int i)
		{
			const string __id = "piece_size.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
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
			global::FrostWire.Libtorrent.Swig.Create_torrent __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Priv ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/method[@name='priv' and count(parameter)=0]"
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

		static Delegate cb_set_comment_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSet_comment_Ljava_lang_String_Handler ()
		{
			if (cb_set_comment_Ljava_lang_String_ == null)
				cb_set_comment_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_comment_Ljava_lang_String_);
			return cb_set_comment_Ljava_lang_String_;
		}

		static void n_Set_comment_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str)
		{
			global::FrostWire.Libtorrent.Swig.Create_torrent __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			__this.Set_comment (str);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/method[@name='set_comment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("set_comment", "(Ljava/lang/String;)V", "GetSet_comment_Ljava_lang_String_Handler")]
		public virtual unsafe void Set_comment (string str)
		{
			const string __id = "set_comment.(Ljava/lang/String;)V";
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_str);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static Delegate cb_set_creator_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSet_creator_Ljava_lang_String_Handler ()
		{
			if (cb_set_creator_Ljava_lang_String_ == null)
				cb_set_creator_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_creator_Ljava_lang_String_);
			return cb_set_creator_Ljava_lang_String_;
		}

		static void n_Set_creator_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_str)
		{
			global::FrostWire.Libtorrent.Swig.Create_torrent __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string str = JNIEnv.GetString (native_str, JniHandleOwnership.DoNotTransfer);
			__this.Set_creator (str);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/method[@name='set_creator' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("set_creator", "(Ljava/lang/String;)V", "GetSet_creator_Ljava_lang_String_Handler")]
		public virtual unsafe void Set_creator (string str)
		{
			const string __id = "set_creator.(Ljava/lang/String;)V";
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_str);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		static Delegate cb_set_file_hash_ILcom_frostwire_jlibtorrent_swig_sha1_hash_;
#pragma warning disable 0169
		static Delegate GetSet_file_hash_ILcom_frostwire_jlibtorrent_swig_sha1_hash_Handler ()
		{
			if (cb_set_file_hash_ILcom_frostwire_jlibtorrent_swig_sha1_hash_ == null)
				cb_set_file_hash_ILcom_frostwire_jlibtorrent_swig_sha1_hash_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Set_file_hash_ILcom_frostwire_jlibtorrent_swig_sha1_hash_);
			return cb_set_file_hash_ILcom_frostwire_jlibtorrent_swig_sha1_hash_;
		}

		static void n_Set_file_hash_ILcom_frostwire_jlibtorrent_swig_sha1_hash_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_h)
		{
			global::FrostWire.Libtorrent.Swig.Create_torrent __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Sha1_hash h = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (native_h, JniHandleOwnership.DoNotTransfer);
			__this.Set_file_hash (index, h);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/method[@name='set_file_hash' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.sha1_hash']]"
		[Register ("set_file_hash", "(ILcom/frostwire/jlibtorrent/swig/sha1_hash;)V", "GetSet_file_hash_ILcom_frostwire_jlibtorrent_swig_sha1_hash_Handler")]
		public virtual unsafe void Set_file_hash (int index, global::FrostWire.Libtorrent.Swig.Sha1_hash h)
		{
			const string __id = "set_file_hash.(ILcom/frostwire/jlibtorrent/swig/sha1_hash;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue ((h == null) ? IntPtr.Zero : ((global::Java.Lang.Object) h).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_hash_ILcom_frostwire_jlibtorrent_swig_sha1_hash_;
#pragma warning disable 0169
		static Delegate GetSet_hash_ILcom_frostwire_jlibtorrent_swig_sha1_hash_Handler ()
		{
			if (cb_set_hash_ILcom_frostwire_jlibtorrent_swig_sha1_hash_ == null)
				cb_set_hash_ILcom_frostwire_jlibtorrent_swig_sha1_hash_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Set_hash_ILcom_frostwire_jlibtorrent_swig_sha1_hash_);
			return cb_set_hash_ILcom_frostwire_jlibtorrent_swig_sha1_hash_;
		}

		static void n_Set_hash_ILcom_frostwire_jlibtorrent_swig_sha1_hash_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_h)
		{
			global::FrostWire.Libtorrent.Swig.Create_torrent __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Sha1_hash h = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (native_h, JniHandleOwnership.DoNotTransfer);
			__this.Set_hash (index, h);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/method[@name='set_hash' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.sha1_hash']]"
		[Register ("set_hash", "(ILcom/frostwire/jlibtorrent/swig/sha1_hash;)V", "GetSet_hash_ILcom_frostwire_jlibtorrent_swig_sha1_hash_Handler")]
		public virtual unsafe void Set_hash (int index, global::FrostWire.Libtorrent.Swig.Sha1_hash h)
		{
			const string __id = "set_hash.(ILcom/frostwire/jlibtorrent/swig/sha1_hash;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue ((h == null) ? IntPtr.Zero : ((global::Java.Lang.Object) h).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_priv_Z;
#pragma warning disable 0169
		static Delegate GetSet_priv_ZHandler ()
		{
			if (cb_set_priv_Z == null)
				cb_set_priv_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_Set_priv_Z);
			return cb_set_priv_Z;
		}

		static void n_Set_priv_Z (IntPtr jnienv, IntPtr native__this, bool p)
		{
			global::FrostWire.Libtorrent.Swig.Create_torrent __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_priv (p);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/method[@name='set_priv' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("set_priv", "(Z)V", "GetSet_priv_ZHandler")]
		public virtual unsafe void Set_priv (bool p)
		{
			const string __id = "set_priv.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_root_cert2_Lcom_frostwire_jlibtorrent_swig_byte_vector_;
#pragma warning disable 0169
		static Delegate GetSet_root_cert2_Lcom_frostwire_jlibtorrent_swig_byte_vector_Handler ()
		{
			if (cb_set_root_cert2_Lcom_frostwire_jlibtorrent_swig_byte_vector_ == null)
				cb_set_root_cert2_Lcom_frostwire_jlibtorrent_swig_byte_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_root_cert2_Lcom_frostwire_jlibtorrent_swig_byte_vector_);
			return cb_set_root_cert2_Lcom_frostwire_jlibtorrent_swig_byte_vector_;
		}

		static void n_Set_root_cert2_Lcom_frostwire_jlibtorrent_swig_byte_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pem)
		{
			global::FrostWire.Libtorrent.Swig.Create_torrent __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Byte_vector pem = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (native_pem, JniHandleOwnership.DoNotTransfer);
			__this.Set_root_cert2 (pem);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='create_torrent']/method[@name='set_root_cert2' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
		[Register ("set_root_cert2", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;)V", "GetSet_root_cert2_Lcom_frostwire_jlibtorrent_swig_byte_vector_Handler")]
		public virtual unsafe void Set_root_cert2 (global::FrostWire.Libtorrent.Swig.Byte_vector pem)
		{
			const string __id = "set_root_cert2.(Lcom/frostwire/jlibtorrent/swig/byte_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pem == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pem).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
